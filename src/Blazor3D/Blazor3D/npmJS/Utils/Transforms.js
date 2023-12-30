import * as THREE from "three";

class Transforms {
  static setPosition(object3d, position) {
    let { x, y, z } = position;
    object3d.position.set(x, y, z);
  }

  static setRotation(object3d, eulerOptions) {
    let { x, y, z, order } = eulerOptions;
    object3d.setRotationFromEuler(new THREE.Euler( x, y, z, order ));
  }

  static setScale(object3d, scale) {
    let { x, y, z } = scale;
    object3d.scale.set(x, y, z);
  }
}

export default Transforms;
