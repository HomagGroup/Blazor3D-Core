import * as THREE from "three";
import { OBJLoader } from "three/examples/jsm/loaders/OBJLoader";
import { ColladaLoader } from "three/examples/jsm/loaders/ColladaLoader";
import { FBXLoader } from "three/examples/jsm/loaders/FBXLoader";
import { GLTFLoader } from "three/examples/jsm/loaders/GLTFLoader";

class Loaders {
  static loadGltf(scene, url, guid) {
    const loader = new GLTFLoader();
    loader.load(url, (object) => {
      console.log("gltf added...", object);
      object.scene.guid = guid;
      scene.add(object.scene);
    });
  }
  static loadFbx(scene, url, guid) {
    const loader = new FBXLoader();
    loader.load(url, (object) => {
      object.guid = guid;
      scene.add(object);
    });
  }

  static loadCollada(scene, url, guid) {
    let object;
    const manager = new THREE.LoadingManager(() => {
      object.guid = guid;
      scene.add(object);
      console.log("collada added....", object);
    });
    const loader = new ColladaLoader(manager);
    loader.load(url, (obj) => {
      object = obj.scene;
    });
  }

  static loadOBJ(scene, objUrl, textureUrl, guid) {
    let object;
    const manager = new THREE.LoadingManager(() => {
      if (textureUrl){
        object.traverse(function (child) {
          if (child.isMesh) child.material.map = texture;
        });
      }
      object.guid = guid;
      scene.add(object);
      console.log("obj added....", object);
    });

    const textureLoader = new THREE.TextureLoader(manager);
    const texture = textureLoader.load(textureUrl);

    const loader = new OBJLoader(manager);
    loader.load(objUrl, (obj) => {
      object = obj;
    });
  }
}

export default Loaders;
