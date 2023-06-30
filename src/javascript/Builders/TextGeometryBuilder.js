import * as THREE from "three";
import { TextGeometry } from 'three/examples/jsm/geometries/TextGeometry';

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


    console.log("not found geometry type", options);
  }
}

export default TextGeometryBuilder;
