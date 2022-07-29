using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Blazor3D.Settings;
using Blazor3D.Scenes;
using Blazor3D.Cameras;
using Blazor3D.Controls;
using Newtonsoft.Json;
using Blazor3D.Maths;
using Blazor3D.Objects;
using Blazor3D.Enums;
using Blazor3D.Lights;
using Blazor3D.ComponentHelpers;

namespace Blazor3D.Viewers
{
    /// <summary>
    /// <para>Blazor3D viewer component.</para>
    /// </summary>
    public sealed partial class Viewer
    {
        private IJSObjectReference bundleModule = null!;

        /// <summary>
        /// <para><see cref="Settings.ViewerSettings"/> parameter of the component.</para>
        /// </summary>
        [Parameter]
        public ViewerSettings ViewerSettings { get; set; } = new ViewerSettings();

        /// <summary>
        /// <para><see cref="Scenes.Scene"/> parameter of the component. Default is empty scene.</para>
        /// </summary>
        [Parameter]
        public Scene Scene { get; set; } = new Scene();

        /// <summary>
        /// <para>If true and there is no children objects in the scene, then adds the default lights and box mesh. Default value is false.</para>
        /// </summary>
        [Parameter]
        public bool UseDefaultScene { get; set; } = false;

        /// <summary>
        /// <para><see cref="PerspectiveCamera"/> used to display the scene.</para>
        /// </summary>
        [Parameter]
        public Camera Camera { get; set; } = new PerspectiveCamera() { Position = new Vector3(3, 3, 3) };

        /// <summary>
        /// <para><see cref="Controls.OrbitControls"/> used to rotate, pan and scale the view.</para>
        /// </summary>
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

                if (UseDefaultScene && !Scene.Children.Any())
                {
                    AddDefaultScene();
                }

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

        /// <summary>
        /// <para>Sets the camera position to specified <see cref="Vector3"/> value.</para>
        /// </summary>
        /// <param name="position">New <see cref="Vector3"/> position.</param>
        /// <param name="lookAt">New <see cref="Vector3"/> camera target point coordinates.</param>
        /// <returns>Task</returns>
        public async Task SetCameraPositionAsync(Vector3 position, Vector3 lookAt = null!)
        {
            await bundleModule.InvokeVoidAsync("setCameraPosition", position, lookAt);
        }

        /// <summary>
        /// <para>Imports 3D model to scene.</para>
        /// </summary>
        /// <param name="format"><see cref="Import3DFormats"/> format of 3D model.</param>
        /// <param name="objUrl">URL of the 3D model file</param>
        /// <param name="textureUrl">URL of the texture file</param>
        /// <param name="delay">Delay im miliseconds to get things loaded before displaying. Default is 200 ms</param>
        /// <returns>Guid of the loaded item</returns>
        public async Task<Guid> Import3DModelAsync(Import3DFormats format, string objUrl, string textureUrl, int delay = 200)
        {
            var guid = Guid.NewGuid();
            await bundleModule.InvokeVoidAsync("import3DModel", format.ToString(), objUrl, textureUrl, guid);
            await Task.Delay(delay);
            var json = await bundleModule.InvokeAsync<string>("getSceneItemByGuid", guid);
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

        private void AddDefaultScene()
        {
            Scene.Add(new AmbientLight());
            Scene.Add(new PointLight()
            {
                Position = new Vector3
                {
                    X = 1,
                    Y = 3,
                    Z = 0
                }
            });
            Scene.Add(new Mesh());
        }
    }
}
