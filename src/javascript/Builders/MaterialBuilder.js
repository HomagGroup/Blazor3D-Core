import * as THREE from "three";

class MaterialBuilder {
  static buildMaterial(options) {
    if (options.type == "MeshStandardMaterial") {
      const material = new THREE.MeshStandardMaterial({
        color: options.color,
      });
      material.uuid = options.uuid;
      return material;
    }
  }
}

export default MaterialBuilder;
