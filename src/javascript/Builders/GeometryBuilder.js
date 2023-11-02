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

    if (options.type == "TorusGeometry") {
      const geometry = new THREE.TorusGeometry(
        options.radius,
        options.tube,
        options.radialSegments,
        options.tubularSegments,
        options.arc
      );
      geometry.uuid = options.uuid;
      return geometry;
    }

    if (options.type == "TorusKnotGeometry") {
      const geometry = new THREE.TorusKnotGeometry(
        options.radius,
        options.tube,
        options.tubularSegments,
        options.radialSegments,
        options.p,
        options.pq,
      );
      geometry.uuid = options.uuid;
      return geometry;
    }

    if (options.type == "ShapeGeometry") {
      const shape = new THREE.Shape(options.shape.points);
      shape.uuid = options.shape.uuid;
      const geometry = new THREE.ShapeGeometry(shape);
      geometry.uuid = options.uuid;
      return geometry;
    }

    if (options.type == "ExtrudeGeometry") {
      const shape = new THREE.Shape(options.shape.points);
      shape.uuid = options.shape.uuid;

      const geometry = new THREE.ExtrudeGeometry(shape, options.extrudeOptions);
      geometry.uuid = options.uuid;
      return geometry;
    }

    if (options.type == "SplineCurveGeometry") {
      const curve = new THREE.SplineCurve(options.points);
      const curvePoints = curve.getPoints(options.divisions)
      const geometry = new THREE.BufferGeometry().setFromPoints( curvePoints )
      geometry.uuid = options.uuid;
      return geometry;
    }

    if (options.type == "LineGeometry") {
      const geometry = new THREE.BufferGeometry().setFromPoints( options.points )
      geometry.uuid = options.uuid;
      return geometry;
    }

    console.log("geometry type not found", options);
  }
}

export default GeometryBuilder;
