import Viewer3D from "./Viewer/Viewer3D";

let viewer3d;

export function loadScene(options) {
  console.log("scene loading ...");
  let container = document.getElementById(options.containerId);
  if (!container) {
    console.warn("container not found");
    return;
  }

  viewer3d = new Viewer3D(options, container);
}

export function loadOBJ(objUrl, textureUrl, guid) {
  viewer3d.loadOBJ(objUrl, textureUrl, guid);
}

export function loadCollada(objUrl, guid) {
  viewer3d.loadCollada(objUrl, guid);
}

export function loadFbx(objUrl, guid) {
  viewer3d.loadFbx(objUrl, guid);
}

export function loadGltf(objUrl, guid) {
  viewer3d.loadGltf(objUrl, guid);
}

export function removeByGuid(guid) {
  viewer3d.removeByGuid(guid);
}

export function setCameraPosition(position){
  viewer3d.setCameraPosition(position);
}

export function removeAllMeshesAndGroups() {
  viewer3d.removeAllMeshesAndGroups();
}

// non supported in viewer
export function exportGLTF() {
  viewer3d.exportGLTF();
}

export function exportCollada() {
  viewer3d.exportCollada();
}

export function exportOBJ() {
  viewer3d.exportOBJ();
}
