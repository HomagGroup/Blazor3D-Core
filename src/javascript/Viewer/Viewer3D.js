import * as THREE from "three";
import { OrbitControls } from "three/examples/jsm/controls/OrbitControls";
import Loaders from "./Loaders";
import Exporters from "./Exporters"; //todo
import TextBuilder from "../Builders/TextBuilder";
import SceneBuilder from "../Builders/SceneBuilder";
import CameraBuilder from "../Builders/CameraBuilder";
import Transforms from "../Utils/Transforms";
import { ViewHelper } from "three/examples/jsm/helpers/ViewHelper";

class Viewer3D {
  thetaX = 0;
  thetaY = 0;
  thetaZ = 0;
  mouse = new THREE.Vector2();
  raycaster = new THREE.Raycaster();

  INTERSECTED = null;

  constructor(options, container) {
    this.options = options;
    this.container = container;

    this.scene = new THREE.Scene();
    this.setScene();

    this.renderer = new THREE.WebGLRenderer(
      {
        antialias: this.options.viewerSettings.webGLRendererSettings.antialias,
        premultipliedAlpha: this.options.viewerSettings.webGLRendererSettings.premultipliedAlpha,
        alpha: this.options.viewerSettings.webGLRendererSettings.alpha,
      }
    );

    if (this.options.viewerSettings.showViewHelper) {
      this.renderer.autoClear = false;
    };

    this.renderer.domElement.style.width = "100%";
    this.renderer.domElement.style.height = "100%";

    this.renderer.domElement.onclick = (event) => {
      if (this.options.viewerSettings.canSelect == true) {
        this.selectObject(event);
      }
      if (
        this.options.camera.animateRotationSettings
          .stopAnimationOnOrbitControlMove == true
      ) {
        this.options.camera.animateRotationSettings.animateRotation = false;
      }
    };

    this.container.appendChild(this.renderer.domElement);

    this.setCamera();
    this.setOrbitControls();
    this.onResize();

    const animate = () => {
      this.controls.update();
      requestAnimationFrame(animate);
      this.render();
    };
    animate();
  }

  render() {
    let cameraAnimationSettigns = this.options.camera.animateRotationSettings;
    if (
      cameraAnimationSettigns &&
      cameraAnimationSettigns.animateRotation == true
    ) {
      let radius = cameraAnimationSettigns.radius;

      this.thetaX = this.thetaX + cameraAnimationSettigns.thetaX;
      this.thetaY = this.thetaY + cameraAnimationSettigns.thetaY;
      this.thetaZ = this.thetaZ + cameraAnimationSettigns.thetaZ;

      this.camera.position.x =
        cameraAnimationSettigns.thetaX == 0
          ? this.camera.position.x
          : radius * Math.sin(THREE.MathUtils.degToRad(this.thetaX));
      this.camera.position.y =
        cameraAnimationSettigns.thetaY == 0
          ? this.camera.position.y
          : radius * Math.sin(THREE.MathUtils.degToRad(this.thetaY));
      this.camera.position.z =
        cameraAnimationSettigns.thetaZ == 0
          ? this.camera.position.z
          : radius * Math.cos(THREE.MathUtils.degToRad(this.thetaZ));
      let { x, y, z } = this.options.camera.lookAt;
      this.camera.lookAt(x, y, z);
      this.camera.updateMatrixWorld();
    }

    if (this.options.viewerSettings.showViewHelper && this.viewHelper) {
      this.renderer.clear();
    }

    this.renderer.render(this.scene, this.camera);

    if (this.options.viewerSettings.showViewHelper && this.viewHelper) {
      this.viewHelper.render(this.renderer);
    }
  }

  onResize() {
    this.camera.aspect =
      this.container.offsetWidth / this.container.offsetHeight;

    if (
      this.camera.isOrthographicCamera &&
      this.options &&
      this.options.camera
    ) {
      this.camera.left = this.options.camera.left * this.camera.aspect;
      this.camera.right = this.options.camera.right * this.camera.aspect;
    }

    this.camera.updateProjectionMatrix();

    this.renderer.setSize(
      this.container.offsetWidth,
      this.container.offsetHeight,
      false // required
    );
  }

  setScene() {
    if (this.options.scene.backGroundColor){
      this.scene.background = new THREE.Color(this.options.scene.backGroundColor);
    }
    
    this.scene.uuid = this.options.scene.uuid;

    this.options.scene.children.forEach((childOptions) => {
      if (childOptions.type == "Text") {
        
        TextBuilder.BuildText(childOptions, this.scene);
      }
      else {
        var child = SceneBuilder.BuildChild(childOptions, this.scene);
        if (child) {
          this.scene.add(child);
        }
      }
    });
  }

  updateScene(sceneOptions) {
    this.clearScene();
    this.options.scene = sceneOptions;
    this.setScene();
  }

  setCamera() {
    this.camera = CameraBuilder.BuildCamera(
      this.options.camera,
      this.container.offsetWidth / this.container.offsetHeight
    );

    if (this.options.viewerSettings.showViewHelper && this.camera && this.renderer && this.renderer.domElement) {
      this.viewHelper = new ViewHelper(this.camera, this.renderer.domElement);
    }

    // todo: add camera children (i.e. lights)
  }

  updateCamera(newCamera) {
    this.options.camera = newCamera;
    this.setCamera();
    this.setOrbitControls();
  }

  showCurrentCameraInfo() {
    console.log('Current camera info:', this.camera);
    console.log('Orbit controls info:', this.controls);
  }

  setOrbitControls() {
    this.controls = new OrbitControls(this.camera, this.renderer.domElement);
    this.controls.screenSpacePanning = true;
    this.controls.minDistance = this.options.orbitControls.minDistance;
    this.controls.maxDistance = this.options.orbitControls.maxDistance;
    this.controls.enablePan = this.options.orbitControls.enablePan;
    this.controls.enableDamping = this.options.orbitControls.enableDamping;
    this.controls.dampingFactor = this.options.orbitControls.dampingFactor;
    let { x, y, z } = this.options.camera.lookAt;
    this.controls.target.set(x, y, z);
    this.controls.update();
  }

  updateOrbitControls(newOrbitControls) {
    this.options.orbitControls = newOrbitControls;
    this.setOrbitControls();
  }

  import3DModel(settings) {
    return Loaders.import3DModel(
      this.scene,
      settings,
      this.options.viewerSettings.containerId
    );
  }

  getSceneItemByGuid(guid) {
    let item = this.scene.getObjectByProperty("uuid", guid);

    return {
      uuid: item.uuid,
      type: item.type,
      name: item.name,
      children: item.type == "Group" ? this.iterateGroup(item.children) : [],
    };
  }

  iterateGroup(children) {
    let result = [];
    for (let i = 0; i < children.length; i++) {
      result.push({
        uuid: children[i].uuid,
        type: children[i].type,
        name: children[i].name,
        children:
          children[i].type == "Group"
            ? this.iterateGroup(children[i].children)
            : [],
      });
    }
    return result;
  }

  selectObject(event) {
    let canvas = this.renderer.domElement;

    this.mouse.x = (event.offsetX / canvas.clientWidth) * 2 - 1;
    this.mouse.y = -(event.offsetY / canvas.clientHeight) * 2 + 1;

    this.raycaster.setFromCamera(this.mouse, this.camera);
    const intersects = this.raycaster.intersectObjects(
      this.scene.children,
      true
    );

    if (intersects.length == 0) {
      if (this.INTERSECTED) {
        this.INTERSECTED.material.color.setHex(this.INTERSECTED.currentHex);
      }

      this.INTERSECTED = null;
      DotNet.invokeMethodAsync(
        "Blazor3D",
        "ReceiveSelectedObjectUUID",
        this.options.viewerSettings.containerId,
        null
      );
      return;
    }

    if (this.options.viewerSettings.canSelectHelpers) {
      this.processSelection(intersects[0].object);
    } else {
      let nonHelper = this.getFirstNonHelper(intersects);
      if (nonHelper) {
        this.processSelection(nonHelper);
      }
    }

    if (this.INTERSECTED) {

      DotNet.invokeMethodAsync(
        "Blazor3D",
        "ReceiveSelectedObjectUUID",
        this.options.viewerSettings.containerId,
        this.INTERSECTED.uuid
      );
    }
  }

  setCameraPosition(position, lookAt) {
    Transforms.setPosition(this.camera, position);
    if (lookAt != null && this.controls && this.controls.target) {
      let { x, y, z } = lookAt;
      this.camera.lookAt(x, y, z);
      this.controls.target.set(x, y, z);
    }
  }

  getFirstNonHelper(intersects) {
    for (let i = 0; i < intersects.length; i++) {
      if (!intersects[i].object.type.includes("Helper")) {
        return intersects[i].object;
      }
    }
    return null;
  }

  removeByUuid(uuid) {
    let obj = this.scene.getObjectByProperty("uuid", uuid);
    if (obj) {
      this.scene.remove(obj);
      return true;
    }
    return false;
  }

  selectByUuid(uuid) {
    let obj = this.scene.getObjectByProperty("uuid", uuid);
    if (obj) {
      this.processSelection(obj)
      return true;
    }
    return false;
  }

  clearScene() {
    this.scene.clear();
  }

  processSelection(objToSelect) {
    if (this.INTERSECTED != objToSelect) {
      if (this.INTERSECTED)
        this.INTERSECTED.material.color.setHex(this.INTERSECTED.currentHex);

      this.INTERSECTED = objToSelect;
      this.INTERSECTED.currentHex = this.INTERSECTED.material.color.getHex();
      this.INTERSECTED.material.color.setHex(
        new THREE.Color(this.options.viewerSettings.selectedColor).getHex()
      );
    }
  }
}

export default Viewer3D;
