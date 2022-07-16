import * as THREE from "three";

class GeometryBuilder {
  static buildGeometry(options) {
    if (options.type == "BoxGeometry") {
      const geometry = new THREE.BoxGeometry(
        options.width,
        options.height,
        options.depth,
        options.widthSegments,
        options.heightSegments,
        options.depthSegments
      );
      geometry.uuid = options.uuid;
      return geometry;
    }

    if (options.type == "CapsuleGeometry") {
      const geometry = new THREE.CapsuleGeometry(
        options.radius,
        options.length,
        options.capSubdivisions,
        options.radialSegments
      );
      geometry.uuid = options.uuid;
      return geometry;
    }

    if (options.type == "CircleGeometry") {
      const geometry = new THREE.CircleGeometry(
        options.radius,
        options.segments,
        options.thetaStart,
        options.thetaLength
      );
      geometry.uuid = options.uuid;
      return geometry;
    }

    if (options.type == "ConeGeometry") {
      const geometry = new THREE.ConeGeometry(
        options.radius,
        options.height,
        options.radialSegments,
        options.heigthSegments,
        options.openEnded,
        options.thetaStart,
        options.thetaLength
      );
      geometry.uuid = options.uuid;
      return geometry;
    }

    if (options.type == "CylinderGeometry") {
      const geometry = new THREE.CylinderGeometry(
        options.radiusTop,
        options.radiusBottom,
        options.height,
        options.radialSegments,
        options.heigthSegments,
        options.openEnded,
        options.thetaStart,
        options.thetaLength
      );
      geometry.uuid = options.uuid;
      return geometry;
    }
  }
}

export default GeometryBuilder;
