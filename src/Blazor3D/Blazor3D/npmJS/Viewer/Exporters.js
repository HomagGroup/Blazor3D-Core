import { GLTFExporter } from "three/examples/jsm/exporters/GLTFExporter";
//import { ColladaExporter } from "three/examples/jsm/exporters/ColladaExporter";
import { OBJExporter } from "three/examples/jsm/exporters/OBJExporter";

function save(blob, filename) {
  const link = document.createElement("a");
  link.style.display = "none";
  // document.body.appendChild( link ); // Firefox workaround, see #6594
  link.href = URL.createObjectURL(blob);
  link.download = filename;
  link.click();
}

function saveString(text, filename) {
  save(new Blob([text], { type: "text/plain" }), filename);
}

function saveArrayBuffer(buffer, filename) {
  save(new Blob([buffer], { type: "application/octet-stream" }), filename);
}

class Exporters {
  static exportOBJ(input) {
    const objExporter = new OBJExporter();
    const result = objExporter.parse(input);
    saveString(result, "scene.obj");
  }

  static exportGLTF(input) {
    const gltfExporter = new GLTFExporter();
    gltfExporter.parse(input, function (result) {
      if (result instanceof ArrayBuffer) {
        saveArrayBuffer(result, "scene.glb");
      } else {
        const output = JSON.stringify(result, null, 2);
        saveString(output, "scene.gltf");
      }
    });
  }

  //static exportCollada(input) {
  //  const exporter = new ColladaExporter();
  //  const result = exporter.parse(input, undefined, {
  //    upAxis: "Y_UP",
  //    unitName: "millimeter",
  //    unitMeter: 0.001,
  //  });
  //  saveString(result.data, "scene.dae");
  //}
}

export default Exporters;
