import { GLTFExporter } from "three/examples/jsm/exporters/GLTFExporter";
import { ColladaExporter } from "three/examples/jsm/exporters/ColladaExporter";
import { OBJExporter } from "three/examples/jsm/exporters/OBJExporter";

function save(blob:any, filename:any) {
  const link = document.createElement("a");
  link.style.display = "none";
  // document.body.appendChild( link ); // Firefox workaround, see #6594
  link.href = URL.createObjectURL(blob);
  link.download = filename;
  link.click();
}

function saveString(text:any, filename:any) {
  save(new Blob([text], { type: "text/plain" }), filename);
}

function saveArrayBuffer(buffer:any, filename:any) {
  save(new Blob([buffer], { type: "application/octet-stream" }), filename);
}

class Exporters {
  static exportOBJ(input:any) {
    const objExporter = new OBJExporter();
    const result = objExporter.parse(input);
    saveString(result, "scene.obj");
  }

  static exportGLTF(input:any) {
    const gltfExporter:any = new GLTFExporter();
    gltfExporter.parse(input, function (result:any) {
      if (result instanceof ArrayBuffer) {
        saveArrayBuffer(result, "scene.glb");
      } else {
        const output = JSON.stringify(result, null, 2);
        saveString(output, "scene.gltf");
      }
    });
  }

  static exportCollada(input:any) {
    const exporter:any = new ColladaExporter();
    const result:any = exporter.parse(input, undefined, {
      upAxis: "Y_UP",
      unitName: "millimeter",
      unitMeter: 0.001,
    });
    saveString(result.data, "scene.dae");
  }
}

export default Exporters;
