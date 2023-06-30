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

        if (options.geometry.type != "TextStrokeGeometry") {
          const material = MaterialBuilder.buildMaterial(options.material);
          const mesh = new THREE.Mesh(geometry, material);
          mesh.uuid = options.uuid;
          Transforms.setPosition(mesh, options.position);
          Transforms.setRotation(mesh, options.rotation);
          Transforms.setScale(mesh, options.scale);
          parent.add(mesh);
        }
        else { // build stroke text here
          const strokeText = new THREE.Group();
          Transforms.setPosition(strokeText, options.position);
          Transforms.setRotation(strokeText, options.rotation);
          Transforms.setScale(strokeText, options.scale);
          strokeText.uuid = options.uuid;

          const matDark = new THREE.MeshBasicMaterial({
            color: options.material.color,
            side: THREE.DoubleSide
          });

          geometry.forEach(element => {
            const strokeMesh = new THREE.Mesh(element, matDark);
            strokeText.add(strokeMesh);
          });

          parent.add(strokeText);
        }
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