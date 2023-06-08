import Viewer3D from "./Viewer/Viewer3D";

let viewer3d:Viewer3D;

window.onresize = function () {
  viewer3d.onResize();
};

export function loadViewer(json:string) {
  const options = JSON.parse(json);
  let container = document.getElementById(options.viewerSettings.containerId);
  if (!container) {
    console.warn("Container not found");
    return;
  }

  viewer3d = new Viewer3D(options, container);
}

export function updateScene(json:string) {
  const sceneOptions = JSON.parse(json);
  viewer3d.updateScene(sceneOptions);
}

export function removeByUuid(guid:any) {
  return viewer3d.removeByUuid(guid);
}

export function clearScene() {
  viewer3d.clearScene();
}

export function import3DModel(json:string) {
  const settings = JSON.parse(json);
  return JSON.stringify(viewer3d.import3DModel(settings));
}

export function setCameraPosition(position:any, lookAt:any) {
  viewer3d.setCameraPosition(position, lookAt);
}

export function updateCamera(json:string) {
  const options = JSON.parse(json);
  viewer3d.updateCamera(options);
}

export function showCurrentCameraInfo() {
  viewer3d.showCurrentCameraInfo();
}

export function getSceneItemByGuid(guid:any) {
  const item = viewer3d.getSceneItemByGuid(guid);
  return JSON.stringify(item);
}
