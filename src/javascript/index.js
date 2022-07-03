import Viewer3D from "./Viewer/Viewer3D";

let viewer3d;

export function loadScene(options) {
  console.log("scene loading ...");
  let container = document.getElementById(options.viewerSettings.containerId);
  if (!container) {
    console.warn("container not found");
    return;
  }

  viewer3d = new Viewer3D(options, container);
}