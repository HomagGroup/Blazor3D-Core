import * as THREE from "three";

class TextureBuilder {
  static buildTexture(options) {
    if (options.type == "Texture") {
      let texture = new THREE.Texture();
      if(options.textureUrl){
        texture = new THREE.TextureLoader().load( options.textureUrl );
        texture.uuid = options.uuid;
        texture.wrapS = options.wrapS;
        texture.wrapT = options.wrapT;
        texture.repeat = options.repeat;
        texture.offset = options.offset;
        texture.center = options.center;
        texture.rotation = options.rotation;
        return texture;
      }
      return null; // if no texture needs to be loaded, return null
    }
  }
}

export default TextureBuilder;
