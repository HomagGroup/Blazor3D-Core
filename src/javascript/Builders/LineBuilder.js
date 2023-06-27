import * as THREE from "three";
import Transforms from "../Utils/Transforms";
import GeometryBuilder from "./GeometryBuilder";
import MaterialBuilder from "./MaterialBuilder";

class LineBuilder {
  static BuildMesh(options) {
    const geometry = GeometryBuilder.buildGeometry(options.geometry);
    const material = MaterialBuilder.buildMaterial(options.material);
    const line = new THREE.Line(geometry, material);

    //todo: linecaps ...

    
    line.uuid = options.uuid;
    Transforms.setPosition(line, options.position);
    Transforms.setRotation(line,options.rotation);
    Transforms.setScale(line,options.scale);
    return line;
  }
}

export default LineBuilder;
