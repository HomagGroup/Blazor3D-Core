import Viewer3D from "./Viewer/Viewer3D";

let viewer3d;

export function loadScene(options) {
  console.log("scene loading ...");
  let container = document.getElementById(options.viewerSettings.containerId);
  if (!container) {
    console.warn("container not found");
    return null;
  }

  viewer3d = new Viewer3D(options, container);
  console.log(viewer3d.options.scene);
  return viewer3d.options.scene;
}