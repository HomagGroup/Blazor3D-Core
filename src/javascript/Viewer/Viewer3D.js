import * as THREE from "three";
import { OrbitControls } from "three/examples/jsm/controls/OrbitControls";
import Loaders from "./Loaders";
import Exporters from "./Exporters";

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
    this.options.scene.children.forEach(child => {
      this.addChild(child);
    });
    console.log(this.scene);

  }

  addChild(child) {
    if ((child.type = "Mesh")) {
      this.addMesh(child);
    }
  }

  addMesh(mesh) {
    //todo: parse type to add corresponding geometry and materials
    const geometry = new THREE.BoxGeometry(
      mesh.geometry.width,
      mesh.geometry.height,
      mesh.geometry.depth
    );
    geometry.uuid = mesh.geometry.uuid;
    const material = new THREE.MeshStandardMaterial({color: mesh.material.color});
    material.uuid = mesh.material.uuid;
    const cube = new THREE.Mesh(geometry, material);
    cube.uuid = mesh.uuid;
    this.scene.add(cube);
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

  loadOBJ(objUrl, textureUrl, guid) {
    return Loaders.loadOBJ(this.scene, objUrl, textureUrl, guid);
  }

  getSceneItemByGuid(guid){
    var item = this.scene.getObjectByProperty("uuid", guid);
    return {
      uuid : item.uuid,
      type : item.type,
      name : item.name,
    };
  }
}
export default Viewer3D;
