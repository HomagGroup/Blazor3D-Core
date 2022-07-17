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

    if (options.type == "DodecahedronGeometry") {
      const geometry = new THREE.DodecahedronGeometry(
        options.radius,
        options.detail
      );
      geometry.uuid = options.uuid;
      return geometry;
    }

    if (options.type == "IcosahedronGeometry") {
      const geometry = new THREE.IcosahedronGeometry(
        options.radius,
        options.detail
      );
      geometry.uuid = options.uuid;
      return geometry;
    }

    if (options.type == "OctahedronGeometry") {
      const geometry = new THREE.OctahedronGeometry(
        options.radius,
        options.detail
      );
      geometry.uuid = options.uuid;
      return geometry;
    }

    if (options.type == "PlaneGeometry") {
      const geometry = new THREE.PlaneGeometry(
        options.width,
        options.height,
        options.widthSegments,
        options.heightSegments
      );
      geometry.uuid = options.uuid;
      return geometry;
    }

    if (options.type == "RingGeometry") {
      const geometry = new THREE.RingGeometry(
        options.innerRadius,
        options.outerRadius,
        options.thetaSegments,
        options.phiSegments,
        options.thetaStart,
        options.thetaLength
      );
      geometry.uuid = options.uuid;
      return geometry;
    }

    if (options.type == "SphereGeometry") {
      const geometry = new THREE.SphereGeometry(
        options.radius,
        options.widthSegments,
        options.heightSegments,
        options.phiStart,
        options.phiLength,
        options.thetaStart,
        options.thetaLength
      );
      geometry.uuid = options.uuid;
      return geometry;
    }

    if (options.type == "TetrahedronGeometry") {
      const geometry = new THREE.TetrahedronGeometry(
        options.radius,
        options.detail
      );
      geometry.uuid = options.uuid;
      return geometry;
    }
  }
}

export default GeometryBuilder;
