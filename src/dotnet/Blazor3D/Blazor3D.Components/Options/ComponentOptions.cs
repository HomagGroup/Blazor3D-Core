namespace Blazor3D.Components.Options
{
    public class ComponentOptions
    {
        public string ContainerId { get; set; } = "blazorview3d";
        public string Width { get; set; } = "450px";
        public string Height { get; set; } = "450px";
        public bool UseOrbitControls { get; set; } = true;
        public SceneOptions SceneOptions { get; set; } = new SceneOptions();
        public CameraOptions CameraOptions { get; set; } = new CameraOptions();
        public OrbitControlsOptions OrbitControlsOptions { get; set; } = new OrbitControlsOptions();
    }
}
