import * as THREE from "three";
import Transforms from "../Utils/Transforms";

class LightBuilder {
  static BuildAmbientLight(options) {
    const light = new THREE.AmbientLight(options.color, options.intensity);
    Transforms.setPosition(light, options.position);
    return light;
  }

  static BuildPointLight(options) {
    const light = new THREE.PointLight(
      options.color,
      options.intensity,
      options.distance,
      options.decay
    );
    light.uuid = options.uuid;
    Transforms.setPosition(light, options.position);
    return light;
  }
}

export default LightBuilder;
