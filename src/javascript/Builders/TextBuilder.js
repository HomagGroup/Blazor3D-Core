import * as THREE from "three";
import Transforms from "../Utils/Transforms";
import MaterialBuilder from "./MaterialBuilder";
import TextGeometryBuilder from "./TextGeometryBuilder"
import { FontLoader } from 'three/examples/jsm/loaders/FontLoader.js';

class TextBuilder {
  static BuildText(options, parent) {

    const loader = new FontLoader();

    loader.load(
      // font URL
      options.geometry.fontURL,
      // callback function called on font loading
      function (font) {
        const geometry = TextGeometryBuilder.buildGeometry(options.geometry, font);
        const material = MaterialBuilder.buildMaterial(options.material);
        const mesh = new THREE.Mesh(geometry, material);
        mesh.uuid = options.uuid;
        Transforms.setPosition(mesh, options.position);
        Transforms.setRotation(mesh, options.rotation);
        Transforms.setScale(mesh, options.scale);
        parent.add(mesh);

      },

      // onProgress callback
      function (xhr) {

      },

      // onError callback
      function (err) {
        console.error('Font loading failed. ', err);
      }
    );
  }
}

export default TextBuilder;