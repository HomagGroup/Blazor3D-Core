import Viewer3D from "./Viewer/Viewer3D";

let viewer3d;

const resizeObserver = new ResizeObserver((entries) => {
  viewer3d.onResize();
});

export function loadViewer(json) {
  const options = JSON.parse(json);
  let container = document.getElementById(options.viewerSettings.containerId);
  if (!container) {
    console.warn("Container not found!");
    return;
  }
  resizeObserver.observe(container);
  viewer3d = new Viewer3D(options, container);
}

export function updateScene(json) {
  const sceneOptions = JSON.parse(json);
  viewer3d.updateScene(sceneOptions);
}

export function removeByUuid(guid) {
  return viewer3d.removeByUuid(guid);
}

export function selectByUuid(guid) {
  return viewer3d.selectByUuid(guid);
}

export function clearScene() {
  viewer3d.clearScene();
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

export function showCurrentCameraInfo() {
  viewer3d.showCurrentCameraInfo();
}

export function getSceneItemByGuid(guid) {
  const item = viewer3d.getSceneItemByGuid(guid);
  return JSON.stringify(item);
}
