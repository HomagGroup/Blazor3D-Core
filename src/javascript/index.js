import Viewer3D from "./Viewer/Viewer3D";

let viewer3d;

window.onresize = function(){
  viewer3d.onResize();
};

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

export function import3DModel(format, objUrl, textureUrl, guid) {
  return JSON.stringify(viewer3d.import3DModel(format, objUrl, textureUrl, guid));
}

export function setCameraPosition(position){
  viewer3d.setCameraPosition(position);
}

export function getSceneItemByGuid(guid){
  var item = viewer3d.getSceneItemByGuid(guid);
  return JSON.stringify(item);
}
