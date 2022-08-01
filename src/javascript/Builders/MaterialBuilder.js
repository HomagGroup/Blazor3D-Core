import * as THREE from "three";

class MaterialBuilder {
  static buildMaterial(options) {
    if (options.type == "MeshStandardMaterial") {
      const material = new THREE.MeshStandardMaterial({
        color: options.color,
        flatShading : options.flatShading,
        metalness: options.metalness,
        roughness: options.roughness,
        wireframe: options.wireframe,
        wireframeLinewidth: options.wireframeLinewidth
      });
      material.uuid = options.uuid;
      return material;
    }
  }
}

export default MaterialBuilder;
