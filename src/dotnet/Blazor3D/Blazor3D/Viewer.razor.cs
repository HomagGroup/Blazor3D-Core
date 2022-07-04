using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Blazor3D.Settings;
using Blazor3D.Scenes;
using Blazor3D.Cameras;
using Blazor3D.Controls;
using Newtonsoft.Json;
using Blazor3D.Helpers;
using Blazor3D.Math;
using Newtonsoft.Json.Linq;
using Blazor3D.Objects;
using Blazor3D.Enums;

namespace Blazor3D
{
    public partial class Viewer
    {
        private IJSObjectReference bundleModule = null!;

        [Parameter]
        public ViewerSettings ViewerSettings { get; set; } = new ViewerSettings();
        [Parameter]
        public Scene Scene { get; set; } = new Scene();
        public PerspectiveCamera Camera { get; } = new PerspectiveCamera();
        public OrbitControls OrbitControls { get; set; } = new OrbitControls();

        public event Func<object, EventArgs, Task> Load = null!;
        private async Task OnLoad()
        {
            Func<object, EventArgs, Task> handler = Load;

            if (handler == null)
            {
                return;
            }

            Delegate[] invocationList = handler.GetInvocationList();
            Task[] handlerTasks = new Task[invocationList.Length];

            for (int i = 0; i < invocationList.Length; i++)
            {
                handlerTasks[i] = ((Func<object, EventArgs, Task>)invocationList[i])(this, EventArgs.Empty);
            }

            await Task.WhenAll(handlerTasks);
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                bundleModule = await JSRuntime.InvokeAsync<IJSObjectReference>(
                    "import",
                    "./_content/Blazor3D/js/bundle.js")
                .AsTask();


                var json = JsonConvert.SerializeObject(new
                {
                    Scene = Scene,
                    ViewerSettings = ViewerSettings,
                    Camera = Camera,
                    OrbitControls = OrbitControls,
                },
                SerializationHelper.GetSerializerSettings());

                await bundleModule.InvokeVoidAsync("loadScene", json);
                // todo: return value only on loaders or call methods
                //var result = await bundleModule.InvokeAsync<string>("loadScene", json);
                //todo: custom deserialization needed. do we need deserialization??? we have guid in every object
                //var scene2 = JsonConvert.DeserializeObject<Scene>(result);
                await OnLoad();
            }
        }

        public async Task SetCameraPosition(Vector3 position)
        {
            await bundleModule.InvokeVoidAsync("setCameraPosition", position);
        }

        public async Task<Guid> Import3DModel(Import3DFormats format, string objUrl, string textureUrl, int delay = 200)
        {
            var guid = new Guid("00000000-0000-0000-0000-000000000011");
            await bundleModule.InvokeVoidAsync("import3DModel", format.ToString(), objUrl, textureUrl, guid);
            await Task.Delay(delay);
            var json = await bundleModule.InvokeAsync<string>("getSceneItemByGuid", "00000000-0000-0000-0000-000000000011");
            if (json.Contains("\"type\":\"Group\""))
            {
                var group = JsonConvert.DeserializeObject<Group>(json);
                if (group != null)
                {
                    Scene.Children.Add(group);
                }

            }
            return guid;
        }


    }
}
