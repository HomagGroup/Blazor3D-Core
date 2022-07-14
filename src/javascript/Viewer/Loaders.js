import * as THREE from "three";
import { OBJLoader } from "three/examples/jsm/loaders/OBJLoader";
import { ColladaLoader } from "three/examples/jsm/loaders/ColladaLoader";
import { FBXLoader } from "three/examples/jsm/loaders/FBXLoader";
import { GLTFLoader } from "three/examples/jsm/loaders/GLTFLoader";

class Loaders {
  static loadGltf(scene, url, guid) {
    const loader = new GLTFLoader();
    loader.load(url, (object) => {
      object.scene.uuid = guid;
      scene.add(object.scene);
    });
  }
  static loadFbx(scene, url, guid) {
    const loader = new FBXLoader();
    loader.load(url, (object) => {
      scene.add(object);
      object.uuid = guid;
    });
  }

  static loadCollada(scene, url, guid) {
    let object;
    const manager = new THREE.LoadingManager(() => {
      scene.add(object);
      object.uuid = guid;
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
      scene.add(object);
      object.uuid = guid;
    });

    const textureLoader = new THREE.TextureLoader(manager);
    const texture = textureLoader.load(textureUrl);

    const loader = new OBJLoader(manager);
    loader.load(objUrl, (obj) => {
      object = obj;
    });
    return object;
  }

  static import3DModel(scene, format, objUrl, textureUrl, guid) {
    if(format == "Obj"){
      return Loaders.loadOBJ(scene, objUrl, textureUrl, guid);
    }
    if(format == "Collada"){
      return Loaders.loadCollada(scene, objUrl, guid);
    }
    if(format == "Fbx"){
      return Loaders.loadFbx(scene, objUrl, guid);
    }
    if(format == "Gltf"){
      return Loaders.loadGltf(scene, objUrl, guid);
    }
    
    return null;
  }
}

export default Loaders;
