import * as THREE from "three";
import { OrbitControls } from "three/examples/jsm/controls/OrbitControls";
import Loaders from "./Loaders";
import Exporters from "./Exporters";

class Viewer3D {
  constructor(options, container) {
    console.log(options);
    this.container = container;

    this.scene = new THREE.Scene();
    this.setScene(options.scene);
    this.setCamera(options.camera);

    // this.addCube();

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

  setScene(scene) {
    this.scene.background = new THREE.Color(scene.backGroundColor);
    scene.children.forEach(child => {
      this.addChild(child);
    });
    console.log(scene.children);
  }

  addChild(child) {
    if ((child.type = "Mesh")) {
      this.addMesh(child);
    }
  }

  addMesh(mesh) {
    const geometry = new THREE.BoxGeometry(
      mesh.geometry.width,
      mesh.geometry.height,
      mesh.geometry.depth
    );
    const material = new THREE.MeshStandardMaterial({color: mesh.material.color});
    // const material = new THREE.MeshBasicMaterial({color: mesh.material.color});
    const cube = new THREE.Mesh(geometry, material);
    this.scene.add(cube);
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
}
export default Viewer3D;
