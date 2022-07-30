import * as THREE from "three";
import { OBJLoader } from "three/examples/jsm/loaders/OBJLoader";
import { ColladaLoader } from "three/examples/jsm/loaders/ColladaLoader";
import { FBXLoader } from "three/examples/jsm/loaders/FBXLoader";
import { GLTFLoader } from "three/examples/jsm/loaders/GLTFLoader";
import { STLLoader } from 'three/examples/jsm/loaders/STLLoader.js';

class Loaders {
  static loadGltf(scene, url, guid, containerId) {
    const loader = new GLTFLoader();
    loader.load(url, (object) => {
      object.scene.uuid = guid;
      scene.add(object.scene);
      Loaders.callDotNet(containerId, guid);
    });
  }
  static loadFbx(scene, url, guid, containerId) {
    const loader = new FBXLoader();
    loader.load(url, (object) => {
      scene.add(object);
      object.uuid = guid;
      Loaders.callDotNet(containerId, guid);
    });
  }

  static loadCollada(scene, url, guid, containerId) {
    let object;
    const manager = new THREE.LoadingManager(() => {
      scene.add(object);
      object.uuid = guid;
      Loaders.callDotNet(containerId, guid);
    });
    const loader = new ColladaLoader(manager);
    loader.load(url, (obj) => {
      object = obj.scene;
    });
  }

  static loadOBJ(scene, objUrl, textureUrl, guid, containerId) {
    let object;
    const manager = new THREE.LoadingManager(() => {
      if (textureUrl){
        object.traverse(function (child) {
          if (child.isMesh) child.material.map = texture;
        });
      }
      scene.add(object);
      object.uuid = guid;
      Loaders.callDotNet(containerId, guid);
    });

    const textureLoader = new THREE.TextureLoader(manager);
    const texture = textureLoader.load(textureUrl);

    const loader = new OBJLoader(manager);
    loader.load(objUrl, (obj) => {
      object = obj;
    });
    return object;
  }

  static loadStl(scene, url, guid, containerId) {
    let mesh;
    const loader = new STLLoader();
    loader.load( url, function ( geometry ) {

      // const material = new THREE.MeshPhongMaterial( { color: 0xff5533, specular: 0x111111, shininess: 200 } );
      const material = new THREE.MeshStandardMaterial({
        color: 0xff5533,
      });
      mesh = new THREE.Mesh( geometry, material );
      mesh.uuid = guid;
      
      // mesh.position.set( 0, - 0.25, 0.6 );
      // mesh.rotation.set( 0, - Math.PI / 2, 0 );
      // mesh.scale.set( 0.5, 0.5, 0.5 );

      // mesh.castShadow = true;
      // mesh.receiveShadow = true;

      scene.add( mesh );
      Loaders.callDotNet(containerId, guid);

    } );
  }

  static import3DModel(scene, format, objUrl, textureUrl, guid, containerId) {
    if(format == "Obj"){
      return Loaders.loadOBJ(scene, objUrl, textureUrl, guid, containerId);
    }
    if(format == "Collada"){
      return Loaders.loadCollada(scene, objUrl, guid, containerId);
    }
    if(format == "Fbx"){
      return Loaders.loadFbx(scene, objUrl, guid, containerId);
    }
    if(format == "Gltf"){
      return Loaders.loadGltf(scene, objUrl, guid, containerId);
    }

    if(format == "Stl"){
      return Loaders.loadStl(scene, objUrl, guid, containerId);
    }
    
    return null;
  }

  static callDotNet(containerId, uuid){
    DotNet.invokeMethodAsync(
      "Blazor3D",
      "ReceiveLoadedObjectUUID",
      containerId,
      uuid
    );
  }
}

export default Loaders;
