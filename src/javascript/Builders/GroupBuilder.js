import * as THREE from "three";
import Transforms from "../Utils/Transforms";
import SceneBuilder from "./SceneBuilder";

class GroupBuilder {

    static BuildGroup(options, scene) {
        const group = new THREE.Group();
        options.children.forEach((childOptions) => {
            var child = SceneBuilder.BuildChild(childOptions, scene);
            if (child) {
                group.add(child);
            }
        });
        Transforms.setPosition(group, options.position);
        Transforms.setRotation(group, options.rotation);
        Transforms.setScale(group, options.scale);
        return group;
    }
}

export default GroupBuilder;