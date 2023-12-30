import * as THREE from "three";
import Transforms from "../Utils/Transforms";
import MaterialBuilder from "./MaterialBuilder";

class SpriteBuilder {

    static BuildSprite(options) {
        const material = MaterialBuilder.buildMaterial(options.material);
        const sprite = new THREE.Sprite(material);
        sprite.center = options.center;
        Transforms.setPosition(sprite, options.position);
        Transforms.setRotation(sprite, options.rotation);
        Transforms.setScale(sprite, options.scale);
        sprite.uuid = options.uuid;
        sprite.name = options.name;
        return sprite;
    }
}

export default SpriteBuilder;
