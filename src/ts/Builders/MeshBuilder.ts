import * as THREE from "three";
import Transforms from "../Utils/Transforms";
import GeometryBuilder from "./GeometryBuilder";
import MaterialBuilder from "./MaterialBuilder";

class MeshBuilder {
  static BuildMesh(options:any):THREE.Mesh {
    const geometry = GeometryBuilder.buildGeometry(options.geometry);
    const material = MaterialBuilder.buildMaterial(options.material);
    const mesh = new THREE.Mesh(geometry, material);
    mesh.uuid = options.uuid;
    Transforms.setPosition(mesh, options.position);
    Transforms.setRotation(mesh,options.rotation);
    Transforms.setScale(mesh,options.scale);
    return mesh;
  }
}

export default MeshBuilder;
