﻿using HomagGroup.Blazor3D.Core;

namespace HomagGroup.Blazor3D.Geometires
{
    /// <summary>
    /// <para></para>A class for generating cone geometries.
    /// <para>Wrapper for three.js <a target="_blank" href="https://threejs.org/docs/index.html#api/en/geometries/ConeGeometry">ConeGeometry</a></para>
    /// </summary>
    public sealed class ConeGeometry : BufferGeometry
    {
        public ConeGeometry() : base("ConeGeometry")
        {
        }

        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="radius">Radius of the cone base. Defaults to 1.</param>
        /// <param name="height">Height of the cone. Default is 1.</param>
        /// <param name="radialSegments">Number of segmented faces around the circumference of the cone. Default is 8.</param>
        /// <param name="heightSegments">umber of rows of faces along the height of the cone. Default is 1.</param>
        /// <param name="openEnded">A Boolean indicating whether the base of the cone is open or capped. Default is false, meaning capped.</param>
        /// <param name="thetaStart">Start angle for first segment. Default is 0 (three o'clock position).</param>
        /// <param name="thetaLength">he central angle, often called theta, of the circular sector. The default is 2*Pi, which makes for a complete circle.</param>
        public ConeGeometry(
            double radius = 1,
            double height = 1,
            int radialSegments = 8,
            int heightSegments = 1,
            bool openEnded = false,
            double thetaStart = 0,
            double thetaLength = (double)(2 * System.Math.PI)) : this()
        {
            Radius = radius;
            Height = height;
            RadialSegments = radialSegments;
            HeightSegments = heightSegments;
            OpenEnded = openEnded;
            ThetaStart = thetaStart;
            ThetaLength = thetaLength;
        }

        /// <summary>
        /// Radius of the cone base. Defaults to 1.
        /// </summary>
        public double Radius { get; set; } = 1;

        /// <summary>
        /// Height of the cone. Default is 1.
        /// </summary>
        public double Height { get; set; } = 1;

        /// <summary>
        /// Number of segmented faces around the circumference of the cone. Default is 8.
        /// </summary>
        public int RadialSegments { get; set; } = 8;

        /// <summary>
        /// Number of rows of faces along the height of the cone. Default is 1.
        /// </summary>
        public int HeightSegments { get; set; } = 1;

        /// <summary>
        /// A Boolean indicating whether the base of the cone is open or capped. Default is false, meaning capped.
        /// </summary>
        public bool OpenEnded { get; set; } = false;

        /// <summary>
        /// Start angle for first segment. Default is 0 (three o'clock position).
        /// </summary>
        public double ThetaStart { get; set; } = 0;

        /// <summary>
        /// The central angle, often called theta, of the circular sector. The default is 2*Pi, which makes for a complete circle.
        /// </summary>
        public double ThetaLength { get; set; } = (double)(2 * System.Math.PI);

    }
}
