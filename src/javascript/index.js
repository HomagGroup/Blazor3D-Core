import Viewer3D from "./Viewer/Viewer3D";

let viewer3d;

window.onresize = function () {
  viewer3d.onResize();
};

export function loadScene(json) {
  const options = JSON.parse(json);
  let container = document.getElementById(options.viewerSettings.containerId);
  if (!container) {
    console.warn("Container not found");
    return;
  }

  viewer3d = new Viewer3D(options, container);
}

export function removeByUuid(guid) {
  viewer3d.removeByUuid(guid);
}

export function clearScene(guid) {
  viewer3d.clearScene(guid);
}

export function import3DModel(json) {
  const settings = JSON.parse(json);
  return JSON.stringify(viewer3d.import3DModel(settings));
}

export function setCameraPosition(position, lookAt) {
  viewer3d.setCameraPosition(position, lookAt);
}

export function updateCamera(json) {
  const options = JSON.parse(json);
  viewer3d.updateCamera(options);
}

export function getSceneItemByGuid(guid) {
  const item = viewer3d.getSceneItemByGuid(guid);
  return JSON.stringify(item);
}
