import * as THREE from "three";

class HelperBuilder{

    static BuildHelper(options, scene){
        if (options.type == "ArrowHelper"){
            const dir = new THREE.Vector3(options.dir.x, options.dir.y, options.dir.z);
            dir.normalize();
            const origin = new THREE.Vector3(options.origin.x, options.origin.y, options.origin.z);
            const arrow = new THREE.ArrowHelper(dir, origin, options.length, options.color, options.headLength, options.headWidth);
            arrow.uuid = options.uuid;
            return arrow;
        }

        if (options.type == "AxesHelper"){
            console.log(options);
            const axes = new THREE.AxesHelper(options.size);
            axes.uuid = options.uuid;
            console.log(axes);
            return axes;
        }

        if (options.type == "BoxHelper"){
            console.log(options);
            const obj = scene.getObjectByProperty("uuid", options.object3D.uuid);
            if(!obj){
                throw `BoxHelper's object with uuid ${options.object3D.uuid} not found`;
            }
            const box = new THREE.BoxHelper(obj, options.color);
            box.uuid = options.uuid;

            return box;
        }
    }
}

export default HelperBuilder;