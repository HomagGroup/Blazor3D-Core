import * as THREE from "three";

class GeometryBuilder{
    static buildGeometry(options){
        if(options.type == "BoxGeometry"){
            const geometry = new THREE.BoxGeometry(
                options.width,
                options.height,
                options.depth,
                options.widthSegments,
                options.heightSegments,
                options.depthSegments
              );
              geometry.uuid = options.uuid;
              return geometry;
        }
    }
}

export default GeometryBuilder;