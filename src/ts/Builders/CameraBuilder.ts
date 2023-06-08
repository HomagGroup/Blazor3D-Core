import * as THREE from "three";
import Transforms from "../Utils/Transforms";

class CameraBuilder {

  private static SetTransforms(camera: THREE.PerspectiveCamera | THREE.OrthographicCamera, options: any) {
    camera.uuid = options.uuid;
    Transforms.setPosition(camera, options.position);
    Transforms.setRotation(camera, options.rotation);
    Transforms.setScale(camera, options.scale);
    let { x, y, z } = options.lookAt;
    camera.lookAt(x, y, z);
  }

  static BuildCamera(options: any, aspect: number): THREE.PerspectiveCamera | THREE.OrthographicCamera {
    let camera: THREE.PerspectiveCamera | THREE.OrthographicCamera;
    if ((options.type == "PerspectiveCamera")) {
      camera = new THREE.PerspectiveCamera(
        options.fov,
        aspect,
        options.near,
        options.far
      );
      this.SetTransforms(camera, options);
      return camera;
    }

    if ((options.type == "OrthographicCamera")) {
      camera = new THREE.OrthographicCamera(
        options.left * aspect,
        options.right * aspect,
        options.top,
        options.bottom,
        options.near,
        options.far
      );
      camera.zoom = options.zoom;
      this.SetTransforms(camera, options);
      return camera;
    }
    throw `Cannot create camera of type:${options.type}`;
  }
}

export default CameraBuilder;
