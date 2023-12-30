import * as THREE from "three";
import Transforms from "../Utils/Transforms";
import GeometryBuilder from "./GeometryBuilder";
import MaterialBuilder from "./MaterialBuilder";

class MeshBuilder {
  static BuildMesh(options) {
    const geometry = GeometryBuilder.buildGeometry(options.geometry);
    const material = MaterialBuilder.buildMaterial(options.material);
    const mesh = new THREE.Mesh(geometry, material);
    mesh.uuid = options.uuid;

    if (options.edgesMaterial) {
      const edges = this.BuildEdges(geometry, options.edgesMaterial);
      mesh.add(edges);
    }

    Transforms.setPosition(mesh, options.position);
    Transforms.setRotation(mesh, options.rotation);
    Transforms.setScale(mesh, options.scale);
    return mesh;
  }

  static BuildEdges(geometry, options) {
    const edges = new THREE.EdgesGeometry(geometry);
    const material = MaterialBuilder.buildMaterial(options);
    return new THREE.LineSegments(edges, material);
  }
}

export default MeshBuilder;
