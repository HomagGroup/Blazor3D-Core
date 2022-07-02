import * as THREE from "three";
import { OrbitControls } from "three/examples/jsm/controls/OrbitControls";
import Loaders from "./Loaders";
import Exporters from "./Exporters";

class Viewer3D {
  constructor(options, container) {
    this.scene = new THREE.Scene();
    this.setOptions(options, container);
    this.container.appendChild(this.renderer.domElement);

    const animate = () => {
      requestAnimationFrame(animate);
      this.renderer.render(this.scene, this.camera);
    };

    animate();
  }

  setOptions(options, container) {
    this.options = options;
    if (container) {
      this.container = container;
    }

    this.scene.background = new THREE.Color(
      this.options.sceneOptions.backGroundColor
    );
    let cameraOptions = this.options.cameraOptions;
    console.log(cameraOptions);
    this.camera = new THREE.PerspectiveCamera(
      cameraOptions.fov,
      this.container.clientWidth / this.container.clientHeight,
      cameraOptions.near,
      cameraOptions.far
    );

    this.setCameraPosition(cameraOptions.position);

    const ambientLight = new THREE.AmbientLight(0xcccccc, 0.4);
    this.scene.add(ambientLight);

    const pointLight = new THREE.PointLight(0xffffff, 0.9);
    this.camera.add(pointLight);
    this.scene.add(this.camera);

    this.renderer = new THREE.WebGLRenderer();
    this.renderer.setSize(
      this.container.clientWidth,
      this.container.clientHeight
    );

    if (this.options.useOrbitControls) {
      let controlsOptions = this.options.orbitControlsOptions;
      this.controls = new OrbitControls(this.camera, this.renderer.domElement);
      this.controls.screenSpacePanning = true;
      this.controls.minDistance = controlsOptions.minDistance;
      this.controls.maxDistance = controlsOptions.maxDistance;
      let { x, y, z } = controlsOptions.targetPosition;
      this.controls.target.set(x, y, z);
      this.controls.update();
    }
  }

  setCameraPosition(position) {
    let { x, y, z } = position;
    this.camera.position.set(x, y, z);
    this.camera.lookAt(0, y / 2, 0);
    if (this.controls && this.controls.target) {
      this.controls.target.set(0, y / 2, 0);
    }
  }

  addGeometry(geom){
    if(geom.geometryType == 1){
      const box = new THREE.BoxGeometry( geom.width, geom.height, geom.depth );
      const material = new THREE.MeshBasicMaterial( {color: 0x00ff00} );
      const mesh = new THREE.Mesh( box, material);
      this.scene.add(mesh); 
      console.log(this.scene);
    }
    console.log(geom);
  }

  loadOBJ(objUrl, textureUrl, guid) {
    Loaders.loadOBJ(this.scene, objUrl, textureUrl, guid);
  }

  loadCollada(objUrl, guid) {
    Loaders.loadCollada(this.scene, objUrl, guid);
  }

  loadFbx(objUrl, guid) {
    Loaders.loadFbx(this.scene, objUrl, guid);
  }

  loadGltf(objUrl, guid) {
    Loaders.loadGltf(this.scene, objUrl, guid);
  }

  exportGLTF() {
    Exporters.exportGLTF(this.scene);
  }

  exportCollada() {
    Exporters.exportCollada(this.scene);
  }
  exportOBJ() {
    Exporters.exportOBJ(this.scene);
  }

  removeByGuid(guid) {
    let obj = this.scene.getObjectByProperty("guid", guid);
    if (obj) {
      this.scene.remove(obj);
      console.log(`object with guid = ${guid} removed from scene`);
    } else {
      console.error(`object with guid = ${guid} not found`);
    }
  }

  removeAllMeshesAndGroups() {
    console.log("removing meshes and groups");
    for (var i = 0; i < this.scene.children.length; i++) {
      if (this.scene.children[i].isGroup || this.scene.children[i].isMesh) {
        this.scene.remove(this.scene.children[i]);
        i--;
      }
    }
  }
}
export default Viewer3D;
