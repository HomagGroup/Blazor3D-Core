import Viewer3D from "./Viewer/Viewer3D";

let viewer3d;

export function loadScene(json) {
  var options = JSON.parse(json);
  console.log("scene loading ...");
  let container = document.getElementById(options.viewerSettings.containerId);
  if (!container) {
    console.warn("Container not found");
    return;
  }

  viewer3d = new Viewer3D(options, container);
  console.log(viewer3d.options.scene);
}