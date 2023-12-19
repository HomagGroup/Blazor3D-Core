import Viewer3D from "./Viewer/Viewer3D";


let viewers = new Map();

const resizeObserver = new ResizeObserver((entries) => {
  viewers.forEach(function(v, k) {
    v.onResize();
    })
  }
);

export function loadViewer(json) {
  const options = JSON.parse(json);
  let container = document.getElementById(options.viewerSettings.containerId);
  if (!container) {
    console.warn("Container not found!");
    return;
  }
  resizeObserver.observe(container);
  if (viewers.has(options.viewerSettings.containerId)) {
    console.error(`Duplicate Viewer constructor call! Container ${options.viewerSettings.containerId} already exists with a viewer`);
    return;
  }
  if (!options.viewerSettings.containerId) {
    console.error('No ContainerId supplied! Cannot create Viewer3D');
    return;
  }
  viewers.set(options.viewerSettings.containerId, new Viewer3D(options, container));
}

export function updateScene(json, containerId) {
  const options = JSON.parse(json);
  let viewer = viewers.get(containerId);
  if (!viewer) {
    console.warn("Viewer not found! Searching for a viewer attached to ContainerId " + containerId);
    return;
    }
  viewer.updateScene(options);
}

export function removeByUuid(guid, containerId) {
  let viewer = viewers.get(containerId);
  if (!viewer) {
    console.warn("Viewer not found! Searching for a viewer attached to ContainerId " + containerId);
    return;
    }
  return viewer.removeByUuid(guid);
}

export function selectByUuid(guid, containerId) {
  let viewer = viewers.get(containerId);
  if (!viewer) {
    console.warn("Viewer not found! Searching for a viewer attached to ContainerId " + containerId);
    return;
    }
  return viewer.selectByUuid(guid);
}

export function clearScene(containerId) {
  let viewer = viewers.get(containerId);
  if (!viewer) {
    console.warn("Viewer not found! Searching for a viewer attached to ContainerId " + containerId);
    return;
    }
    viewer.clearScene();
}

export function import3DModel(json, containerId) {
  const settings = JSON.parse(json);
  let viewer = viewers.get(containerId);
  if (!viewer) {
    console.warn("Viewer not found! Searching for a viewer attached to ContainerId " + containerId);
    return;
    }
  return JSON.stringify(viewer.import3DModel(settings));
}

export function importSprite(json, containerId) {
  const settings = JSON.parse(json);
  let viewer = viewers.get(containerId);
  if (!viewer) {
    console.warn("Viewer not found! Searching for a viewer attached to ContainerId " + containerId);
    return;
    }
  return JSON.stringify(viewer.importSprite(settings));
}

export function setCameraPosition(position, lookAt, containerId) {
  let viewer = viewers.get(containerId);
  if (!viewer) {
    console.warn("Viewer not found! Searching for a viewer attached to ContainerId " + containerId);
    return;
    }
    viewer.setCameraPosition(position, lookAt);
}

export function updateCamera(json, containerId) {
  const options = JSON.parse(json);
  let viewer = viewers.get(containerId);
  if (!viewer) {
    console.warn("Viewer not found! Searching for a viewer attached to ContainerId " + containerId);
    return;
    }
    viewer.updateCamera(options);
}

export function showCurrentCameraInfo(containerId) {
  let viewer = viewers.get(containerId);
  if (!viewer) {
    console.warn("Viewer not found! Searching for a viewer attached to ContainerId " + containerId);
    return;
    }
    viewer.showCurrentCameraInfo();
}

export function updateOrbitControls(json, containerId){
  const options = JSON.parse(json);
  let viewer = viewers.get(containerId);
  if (!viewer) {
    console.warn("Viewer not found! Searching for a viewer attached to ContainerId " + containerId);
    return;
    }
    viewer.updateOrbitControls(options);
}

export function getSceneItemByGuid(guid, containerId) {
  let viewer = viewers.get(containerId);
  if (!viewer) {
    console.warn("Viewer not found! Searching for a viewer attached to ContainerId " + containerId);
    return;
    }
  const item = viewer.getSceneItemByGuid(guid);
  return JSON.stringify(item);
}
