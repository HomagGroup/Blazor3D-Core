class Transforms {
  static setPosition(object3d, position) {
    let { x, y, z } = position;
    object3d.position.set(x, y, z);
  }
}

export default Transforms;
