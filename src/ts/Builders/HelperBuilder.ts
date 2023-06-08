import * as THREE from "three";
import Transforms from "../Utils/Transforms";

class HelperBuilder {
  static BuildHelper(options: any, scene: THREE.Scene) {
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

    if (options.type == "PlaneHelper") {
      let { x, y, z } = options.plane.normal;
      let normal = new THREE.Vector3(x, y, z);
      let plane = new THREE.Plane(normal, options.plane.constant);

      const planeHelper = new THREE.PlaneHelper(plane, options.size, options.color);
      planeHelper.uuid = options.uuid;
      Transforms.setPosition(planeHelper, options.position);
      Transforms.setRotation(planeHelper, options.rotation);
      Transforms.setScale(planeHelper, options.scale);
      return planeHelper;
    }


    if (options.type == "PointLightHelper") {
      const obj: any = scene.getObjectByProperty("uuid", options.light.uuid);
      if (!obj) {
        throw `BoxHelper's object with uuid ${options.light.uuid} not found`;
      }
      var color = options.color;
      if (!color) {
        color = obj.color;
      }
      const plight = new THREE.PointLightHelper(obj, options.sphereSize, color);
      plight.uuid = options.uuid;
      // transitions do not work here
      return plight;
    }
  }
}

export default HelperBuilder;
