using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Blazor3D.Settings;
using Blazor3D.Scenes;
using Blazor3D.Cameras;
using Blazor3D.Controls;

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
                await bundleModule.InvokeVoidAsync("loadScene", new
                {
                    Scene = Scene,
                    ViewerSettings = ViewerSettings,
                    Camera = Camera,
                    OrbitControls = OrbitControls,
                });
                await OnLoad();
            }
        }
    }
}
