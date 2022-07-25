import HelperBuilder from "./HelperBuilder";
import LightBuilder from "./LightBuilder";
import MeshBuilder from "./MeshBuilder";

class SceneBuilder {

  static BuildChild(options, scene) {
    if (options.type == "Mesh") {
      return MeshBuilder.BuildMesh(options);
    }

    if (options.type == "AmbientLight") {
      return LightBuilder.BuildAmbientLight(options);
    }

    if (options.type == "PointLight") {
      return LightBuilder.BuildPointLight(options);
    }

    if (options.type.includes("Helper")) {
      return HelperBuilder.BuildHelper(options, scene);
    }
  }
}

export default SceneBuilder;
