const path = require('path');
const webpack = require('webpack');

const bundleFileName = 'bundle';
const dirName = '../dotnet/Blazor3D/Blazor3D/wwwroot/js';

module.exports = (env, argv) => {
  //todo: bundle.min.js for production mode
    return {
        mode: argv.mode === "production" ? "production" : "development",
        entry: ['./index.js'],
        output: {
            library:{
              type: 'module'
            },
            umdNamedDefine: true,
            filename: bundleFileName + ".js",
            path: path.resolve(__dirname, dirName),
        },
        plugins: [
            new webpack.BannerPlugin({
              banner: `Copyright © 2022 Roman Simuta aka siroman \nCopyright © 2010-2021 three.js authors https://threejs.org/`
            })
          ],
          experiments: {
            outputModule: true,
          },
        
    };
};