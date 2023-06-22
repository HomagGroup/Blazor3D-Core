import * as THREE from "three";
import Transforms from "../Utils/Transforms";
import SceneBuilder from "./SceneBuilder";

class GroupBuilder {

    static BuildGroup(options, scene) {
        const group = new THREE.Group();
        options.children.forEach((childOptions) => {
            SceneBuilder.BuildChild(childOptions, scene)
            .then(child =>{
                if (child) {
                    group.add(child);
                }
            }).catch(error =>{
                console.error(error);
            });
        });
        Transforms.setPosition(group, options.position);
        Transforms.setRotation(group, options.rotation);
        Transforms.setScale(group, options.scale);
        return group;
    }
}

export default GroupBuilder;