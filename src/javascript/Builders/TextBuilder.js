import * as THREE from "three";
import Transforms from "../Utils/Transforms";
import MaterialBuilder from "./MaterialBuilder";
import { FontLoader } from 'three/examples/jsm/loaders/FontLoader.js';
import { TextGeometry } from 'three/examples/jsm/geometries/TextGeometry';

class TextBuilder {
  static BuildText(options, parent) {

    const loader = new FontLoader();
    
    loader.load(
      // font URL
      options.geometry.fontURL,
      // callback function called on font loading
      function ( font ) {
        const geometry = new TextGeometry(options.geometry.text,
          {
            font: font,
            size: options.geometry.size,
            height: options.geometry.height,
            curveSegments: options.geometry.curveSegments,
            bevelEnabled: options.geometry.bevelEnabled,
            bevelThickness: options.geometry.bevelThickness,
            bevelSize: options.geometry.bevelSize,
            bevelOffset: options.geometry.bevelOffset,
            bevelSegments: options.geometry.bevelSegments,

          });
          const material = MaterialBuilder.buildMaterial(options.material);
          const mesh = new THREE.Mesh(geometry, material);
          mesh.uuid = options.uuid;
          Transforms.setPosition(mesh, options.position);
          Transforms.setRotation(mesh,options.rotation);
          Transforms.setScale(mesh,options.scale);
          parent.add(mesh);

      },
    
      // onProgress callback
      function ( xhr ) {
       
      },
    
      // onError callback
      function ( err ) {
        console.error( 'Font loading failed. ', err);
      }
    );
  }
}

export default TextBuilder;