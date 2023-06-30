import * as THREE from "three";
import { TextGeometry } from 'three/examples/jsm/geometries/TextGeometry';
import { SVGLoader } from "three/examples/jsm/loaders/SVGLoader"

class TextGeometryBuilder {
  static buildGeometry(options, font) {
    if (options.type == "TextExtrudeGeometry") {
      const geometry = new TextGeometry(options.text,
        {
          font: font,
          size: options.size,
          height: options.height,
          curveSegments: options.curveSegments,
          bevelEnabled: options.bevelEnabled,
          bevelThickness: options.bevelThickness,
          bevelSize: options.bevelSize,
          bevelOffset: options.bevelOffset,
          bevelSegments: options.bevelSegments,
        });
      geometry.uuid = options.uuid;
      return geometry;
    }

    if (options.type == "TextShapeGeometry") {
      const shapes = font.generateShapes(options.text, options.size);
      const geometry = new THREE.ShapeGeometry(shapes);
      geometry.uuid = options.uuid;
      return geometry;
    }

    if (options.type == "TextStrokeGeometry") {
      const shapes = font.generateShapes(options.text, options.size);
      const holeShapes = [];

      for (let i = 0; i < shapes.length; i++) {
        if (shapes[i].holes && shapes[i].holes.length > 0) {
          for (let j = 0; j < shapes[i].holes.length; j++) {
            holeShapes.push(shapes[i].holes[j]);
          }
        }
      }

      shapes.push.apply(shapes, holeShapes);

      const style = SVGLoader.getStrokeStyle(options.strokeWidth);
      const geometries = [];
      for (let i = 0; i < shapes.length; i++) {
        const points = shapes[i].getPoints();
        const geometry = SVGLoader.pointsToStroke(points, style);
        geometries.push(geometry);
      }
      return geometries;
    }

    console.log("not found geometry type", options);
  }
}

export default TextGeometryBuilder;
