import * as THREE from "three";
import { OrbitControls } from "three/examples/jsm/controls/OrbitControls";
import Loaders from "./Loaders";
import Exporters from "./Exporters"; //todo
import SceneBuilder from "../Builders/SceneBuilder";
import CameraBuilder from "../Builders/CameraBuilder";

class Viewer3D {
  constructor(options, container) {
    this.options = options;
    this.container = container;

    this.scene = new THREE.Scene();
    this.setScene();

    this.setCamera();

    this.renderer = new THREE.WebGLRenderer();
    this.renderer.domElement.style.width = "100%";
    this.renderer.domElement.style.height = "100%";
    this.container.appendChild(this.renderer.domElement);

    this.setOrbitControls(options.orbitControls);

    const animate = () => {
      requestAnimationFrame(animate);
      this.renderer.render(this.scene, this.camera);
    };
    this.onResize();
    animate();
  }

  onResize() {
    this.camera.aspect =
      this.container.offsetWidth / this.container.offsetHeight;

    if (this.camera.isOrthographicCamera && this.options && this.options.camera) {
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
    this.scene.background = new THREE.Color(this.options.scene.backGroundColor);
    this.scene.uuid = this.options.scene.uuid;

    this.options.scene.children.forEach((childOptions) => {
      var child = SceneBuilder.BuildChild(childOptions);
      this.scene.add(child);
    });
  }

  setCamera() {
    this.camera = CameraBuilder.BuildCamera(
      this.options.camera,
      this.container.offsetWidth / this.container.offsetHeight
    );

    this.camera.lookAt(0, 0, 0);
    if (this.controls && this.controls.target) {
      this.controls.target.set(0, 0, 0);
    }

    // todo: add camera children (i.e. lights)
  }

  setOrbitControls(orbitControls) {
    this.controls = new OrbitControls(this.camera, this.renderer.domElement);
    this.controls.screenSpacePanning = true;
    this.controls.minDistance = orbitControls.minDistance;
    this.controls.maxDistance = orbitControls.maxDistance;
    let { x, y, z } = orbitControls.targetPosition;
    this.controls.target.set(x, y, z);
    this.controls.update();
  }

  import3DModel(format, objUrl, textureUrl, guid) {
    return Loaders.import3DModel(this.scene, format, objUrl, textureUrl, guid);
  }

  getSceneItemByGuid(guid) {
    var item = this.scene.getObjectByProperty("uuid", guid);
    return {
      uuid: item.uuid,
      type: item.type,
      name: item.name,
    };
  }
}
export default Viewer3D;
