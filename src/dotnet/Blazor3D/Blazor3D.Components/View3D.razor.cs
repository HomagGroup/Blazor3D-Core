using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Blazor3D.Components.Options;
using Blazor3D.Components.Common;

namespace Blazor3D.Components
{
    public partial class View3D
    {
        private IJSObjectReference bundleModule = null!;

        [Parameter]
        public ComponentOptions ComponentOptions { get; set; } = new ComponentOptions();

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
                    "./_content/Blazor3D.Components/js/bundle.js")
                .AsTask();
                await bundleModule.InvokeVoidAsync("loadScene", ComponentOptions);
                await OnLoad();
            }
        }

        public async Task<Guid> LoadOBJ(string objUrl, string textureUrl)
        {
            var guid = Guid.NewGuid();
            await bundleModule.InvokeVoidAsync("loadOBJ", objUrl, textureUrl, guid);
            return guid;
        }

        public async Task<Guid> LoadCollada(string objUrl)
        {
            var guid = Guid.NewGuid();
            await bundleModule.InvokeVoidAsync("loadCollada", objUrl, guid);
            return guid;
        }

        public async Task<Guid> LoadFbx(string objUrl)
        {
            var guid = Guid.NewGuid();
            await bundleModule.InvokeVoidAsync("loadFbx", objUrl, guid);
            return guid;
        }

        public async Task<Guid> LoadGltf(string objUrl)
        {
            var guid = Guid.NewGuid();
            await bundleModule.InvokeVoidAsync("loadGltf", objUrl, guid);
            return guid;
        }

        public async Task RemoveByGuid(Guid guid)
        {
            await bundleModule.InvokeVoidAsync("removeByGuid", guid);
        }

        public async Task RemoveAllMeshesAndGroups()
        {
            await bundleModule.InvokeVoidAsync("removeAllMeshesAndGroups");
        }

        public async Task SetCameraPosition(Position position)
        {
            await bundleModule.InvokeVoidAsync("setCameraPosition", position);
        }
    }
}
