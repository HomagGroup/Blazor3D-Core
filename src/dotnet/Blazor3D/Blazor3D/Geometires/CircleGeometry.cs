﻿using Blazor3D.Core;

namespace Blazor3D.Geometires
{
    /// <summary>
    /// <para>Class for a simple shape of Euclidean geometry. 
    /// It is constructed from a number of triangular segments that are oriented around a central point and extend as far out as a given radius. 
    /// It is built counter-clockwise from a start angle and a given central angle. 
    /// It can also be used to create regular polygons, where the number of segments determines the number of sides.</para>
    /// <para>This class inherits from <see cref="BufferGeometry"/></para>
    /// <para>Wrapper for three.js <a target="_blank" href="https://threejs.org/docs/index.html#api/en/geometries/CircleGeometry">CircleGeometry</a></para>
    /// </summary>
    /// <inheritdoc><see cref="BufferGeometry"/></inheritdoc>
    public sealed class CircleGeometry : BufferGeometry
    {
        public CircleGeometry() : base("CircleGeometry")
        {
        }

        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="radius">Radius of the circle. Default is 1.</param>
        /// <param name="segments">Number of segments (triangles). Minimum = 3, default = 8.</param>
        /// <param name="thetaStart">Start angle for first segment. Default is 0 (three o'clock position).</param>
        /// <param name="thetaLength">The central angle, often called theta, of the circular sector. The default is 2*Pi, which makes for a complete circle.</param>
        public CircleGeometry(float radius = 1, int segments = 8, float thetaStart = 0, float thetaLength = (float)(2 * System.Math.PI)) : this()
        {
            Radius = radius;
            Segments = segments;
            ThetaStart = thetaStart;
            ThetaLength = thetaLength;
        }

        /// <summary>
        /// Radius of the circle. Default is 1.
        /// </summary>
        public float Radius { get; set; } = 1;

        /// <summary>
        /// Number of segments (triangles). Minimum = 3, default = 8.
        /// </summary>
        public int Segments { get; set; } = 8;

        /// <summary>
        /// Start angle for first segment. Default is 0 (three o'clock position).
        /// </summary>
        public float ThetaStart { get; set; } = 0;

        /// <summary>
        /// The central angle, often called theta, of the circular sector. The default is 2*Pi, which makes for a complete circle.
        /// </summary>
        public float ThetaLength { get; set; } = (float)(2 * System.Math.PI);

    }
}
