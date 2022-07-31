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
using Blazor3D.Events;
using Newtonsoft.Json.Linq;
using Blazor3D.Core;

namespace Blazor3D.Viewers
{
    /// <summary>
    /// <para>Blazor3D viewer component.</para>
    /// </summary>
    public sealed partial class Viewer
    {
        private IJSObjectReference bundleModule = null!;

        //static events
        private delegate void SelectedObjectStaticEventHandler(Object3DStaticArgs e);
        private static event SelectedObjectStaticEventHandler ObjectSelectedStatic = null!;

        private delegate void LoadedObjectStaticEventHandler(Object3DStaticArgs e);
        private static event LoadedObjectStaticEventHandler ObjectLoadedStatic = null!;

        private event LoadedObjectEventHandler ObjectLoadedPrivate = null!;
        //private event Func<object, EventArgs, Task> Load = null!;

        /// <summary>
        /// Handler for ObjectSelected event.
        /// </summary>
        /// <param name="e"><see cref="Object3DArgs"/>ObjectSelected event handler arguments</param>
        public delegate void SelectedObjectEventHandler(Object3DArgs e);

        /// <summary>
        /// ObjectSelected event. Raises when user selects object by mouse clicking inside viewer.
        /// </summary>
        public event SelectedObjectEventHandler ObjectSelected = null!;

        /// <summary>
        /// Handler for ObjectLoaded event.
        /// </summary>
        /// <param name="e"><see cref="Object3DArgs"/>ObjectLoaded event handler arguments</param>
        public delegate Task LoadedObjectEventHandler(Object3DArgs e);

        /// <summary>
        /// ObjectLoaded event. Raises after complete loading imported file content.
        /// </summary>
        public event LoadedObjectEventHandler ObjectLoaded = null!;

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

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                ObjectSelectedStatic += OnObjectSelectedStatic;
                ObjectLoadedStatic += OnObjectLoadedStatic;
                ObjectLoadedPrivate += OnObjectLoadedPrivate;

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
                //await OnLoad();
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

        [JSInvokable]
        public static Task<string> ReceiveSelectedObjectUUID(string containerId, string uuid)
        {
            var result = containerId + uuid;
            ObjectSelectedStatic?.Invoke(new Object3DStaticArgs()
            {
                ContainerId = containerId,
                UUID = new Guid(uuid),
            });
            return Task.FromResult(result);
        }

        [JSInvokable]
        public static Task<string> ReceiveLoadedObjectUUID(string containerId, string uuid)
        {
            var result = containerId + uuid;
            ObjectLoadedStatic?.Invoke(new Object3DStaticArgs()
            {
                ContainerId = containerId,
                UUID = new Guid(uuid),
            });
            return Task.FromResult(result);
        }

        /// <summary>
        /// <para>Imports 3D model to scene.</para>
        /// </summary>
        /// <param name="format"><see cref="Import3DFormats"/> format of 3D model.</param>
        /// <param name="objUrl">URL of the 3D model file</param>
        /// <param name="textureUrl">URL of the texture file</param>
        /// <param name="uuid">UUID of the object to be loaded. Nullable. If not specified, the new Guid is genrated.</param>
        /// <returns>Guid of the loaded item</returns>
        public async Task<Guid> Import3DModelAsync(Import3DFormats format, string objUrl, string textureUrl, Guid? uuid = null)
        {
            Guid guid = uuid ?? Guid.NewGuid();
            await bundleModule.InvokeVoidAsync("import3DModel", format.ToString(), objUrl, textureUrl, guid);
            return guid;
        }

        /// <summary>
        /// <para>Recursively finds object by it's uuid in collection.</para>
        /// </summary>
        /// <param name="uuid">Object's uuid</param>
        /// <param name="children">Children collection. Usually it's Scene.Children</param>
        /// <returns>Found object or null</returns>
        public static Object3D? GetObjectByUuid(Guid uuid, List<Object3D> children)
        {
            Object3D? result = null;
            foreach (var child in children)
            {
                if (child.Uuid == uuid)
                {
                    return child;
                }

                if (child.Children.Count > 0)
                {
                    result = GetObjectByUuid(uuid, child.Children);
                    if (result != null)
                    {
                        return result;
                    }
                };
            }
            return result;
        }

        //private async Task OnLoad()
        //{
        //    Func<object, EventArgs, Task> handler = Load;


        //    if (handler == null)
        //    {
        //        return;
        //    }

        //    Delegate[] invocationList = handler.GetInvocationList();
        //    Task[] handlerTasks = new Task[invocationList.Length];

        //    for (int i = 0; i < invocationList.Length; i++)
        //    {
        //        handlerTasks[i] = ((Func<object, EventArgs, Task>)invocationList[i])(this, EventArgs.Empty);
        //    }

        //    await Task.WhenAll(handlerTasks);
        //}

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

        private void OnObjectSelectedStatic(Object3DStaticArgs e)
        {
            if (ViewerSettings.ContainerId == e.ContainerId)
            {
                ObjectSelected?.Invoke(new Object3DArgs() { UUID = e.UUID });
            }
        }

        private void OnObjectLoadedStatic(Object3DStaticArgs e)
        {
            if (ViewerSettings.ContainerId == e.ContainerId)
            {
                ObjectLoadedPrivate?.Invoke(new Object3DArgs() { UUID = e.UUID });
            }
        }

        private List<Object3D> ParseChildren(JToken? children)
        {
            var result = new List<Object3D>();
            if (children?.Type != JTokenType.Array)
            {
                return result;
            }

            foreach (JToken child in children)
            {
                var c = child as JObject;
                if (c == null)
                {
                    continue;
                }

                var type = c.Property("type")?.Value.ToString();
                var name = c.Property("name")?.Value.ToString() ?? string.Empty;
                var uuid = c.Property("uuid")?.Value.ToString() ?? string.Empty;
                if (type == "Mesh")
                {
                    var mesh = new Mesh()
                    {
                        Name = name,
                        Uuid = Guid.Parse(uuid)
                    };
                    result.Add(mesh);
                }

                if (type == "Group")
                {
                    var ch = c.Property("children")?.Value;
                    var childrenResult = ParseChildren(ch);
                    var group = new Group
                    {
                        Name = name,
                        Uuid = Guid.Parse(uuid),
                    };
                    group.Children.AddRange(childrenResult);
                }
            }
            return result;
        }

        private async Task OnObjectLoadedPrivate(Object3DArgs e)
        {
            var json = await bundleModule.InvokeAsync<string>("getSceneItemByGuid", e.UUID);
            if (json.Contains("\"type\":\"Group\""))
            {
                var jobject = JObject.Parse(json);
                var name = jobject.Property("name")?.Value.ToString() ?? string.Empty;
                var uuidstr = jobject.Property("uuid")?.Value.ToString() ?? string.Empty;
                var children = jobject.Property("children")?.Value;
                var childrenResult = ParseChildren(children);
                var group = new Group
                {
                    Name = name,
                    Uuid = Guid.Parse(uuidstr),
                };
                group.Children.AddRange(childrenResult);

                Scene.Children.Add(group);
                ObjectLoaded?.Invoke(new Object3DArgs() { UUID = e.UUID });
            }

            if (json.Contains("\"type\":\"Mesh\""))
            {
                var mesh = JsonConvert.DeserializeObject<Mesh>(json);
                if (mesh != null)
                {
                    Scene.Children.Add(mesh);
                    ObjectLoaded?.Invoke(new Object3DArgs() { UUID = e.UUID });
                }
            }
        }
    }
}
