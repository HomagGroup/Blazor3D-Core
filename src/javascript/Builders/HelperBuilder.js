import * as THREE from "three";
import Transforms from "../Utils/Transforms";

class HelperBuilder {
  static BuildHelper(options, scene) {
    if (options.type == "ArrowHelper") {
      const dir = new THREE.Vector3(
        options.dir.x,
        options.dir.y,
        options.dir.z
      );
      dir.normalize();
      const origin = new THREE.Vector3(
        options.origin.x,
        options.origin.y,
        options.origin.z
      );
      const arrow = new THREE.ArrowHelper(
        dir,
        origin,
        options.length,
        options.color,
        options.headLength,
        options.headWidth
      );
      arrow.uuid = options.uuid;

      // transitions are not aplicable here??? todo: investigate this 
      return arrow;
    }

    if (options.type == "AxesHelper") {
      console.log(options);
      const axes = new THREE.AxesHelper(options.size);
      axes.uuid = options.uuid;
      Transforms.setPosition(axes, options.position);
      Transforms.setRotation(axes, options.rotation);
      Transforms.setScale(axes, options.scale);
      return axes;
    }

    if (options.type == "BoxHelper") {
      const obj = scene.getObjectByProperty("uuid", options.object3D.uuid);
      if (!obj) {
        throw `BoxHelper's object with uuid ${options.object3D.uuid} not found`;
      }
      const box = new THREE.BoxHelper(obj, options.color);
      box.uuid = options.uuid;
      // transitions do not work here
      return box;
    }

    if (options.type == "GridHelper") {
      const grid = new THREE.GridHelper(
        options.size,
        options.divisions,
        options.colorCenterLine,
        options.colorGrid
      );
      grid.uuid = options.uuid;
      Transforms.setPosition(grid, options.position);
      Transforms.setRotation(grid, options.rotation);
      Transforms.setScale(grid, options.scale);
      return grid;
    }

    if (options.type == "PolarGridHelper") {
      console.log(options);
      const grid = new THREE.PolarGridHelper(
        options.radius,
        options.radials,
        options.circles,
        options.divisions,
        options.color1,
        options.color2
      );
      grid.uuid = options.uuid;
      Transforms.setPosition(grid, options.position);
      Transforms.setRotation(grid, options.rotation);
      Transforms.setScale(grid, options.scale);
      return grid;
    }
  }
}

export default HelperBuilder;
