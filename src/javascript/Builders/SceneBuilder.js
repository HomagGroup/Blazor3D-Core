import HelperBuilder from "./HelperBuilder";
import LightBuilder from "./LightBuilder";
import MeshBuilder from "./MeshBuilder";
import GroupBuilder from "./GroupBuilder";

class SceneBuilder {

  static async BuildChild(options, scene) {
    if (options.type == "Mesh") {
      return await MeshBuilder.BuildMesh(options);
    }

    if (options.type == "Group") {
      return GroupBuilder.BuildGroup(options);
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
