import * as THREE from "three";
import { OrbitControls } from "three/examples/jsm/controls/OrbitControls";
import Loaders from "./Loaders";
import Exporters from "./Exporters";//todo
import SceneBuilder from "../Builders/SceneBuilder";

class Viewer3D {
  constructor(options, container) {
    this.options = options;
    this.container = container;

    this.scene = new THREE.Scene();
    this.setScene();
    this.setCamera(this.options.camera);

    this.renderer = new THREE.WebGLRenderer();
    this.renderer.domElement.style.width = "100%";
    this.container.appendChild(this.renderer.domElement);

    this.setOrbitControls(options.orbitControls);
    const animate = () => {
      requestAnimationFrame(animate);

      // todo: do it on windows resize
      this.renderer.setSize(
        this.container.clientWidth,
        this.container.clientHeight
      );
      // this.camera.aspect = this.container.clientWidth / this.container.clientHeight;
      // this.camera.updateProjectionMatrix();
      this.renderer.render(this.scene, this.camera);
    };

    animate();
  }

  setScene() {
    this.scene.background = new THREE.Color(this.options.scene.backGroundColor);
    this.scene.uuid = this.options.scene.uuid;
    
    this.options.scene.children.forEach((childOptions) => {
      var child = SceneBuilder.BuildChild(childOptions);
      this.scene.add(child);
    });
    console.log(this.scene);
  }

  

  setCamera(camera) {
    this.camera = new THREE.PerspectiveCamera(
      camera.fov,

      this.container.clientWidth / this.container.clientHeight,
      // camera.aspect,
      camera.near,
      camera.far
    );

    this.setCameraPosition({ x: 3, y: 3, z: 3 });
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

  setCameraPosition(position) {
    let { x, y, z } = position;
    this.camera.position.set(x, y, z);
    this.camera.lookAt(0, y / 2, 0);
    if (this.controls && this.controls.target) {
      this.controls.target.set(0, y / 2, 0);
    }
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
