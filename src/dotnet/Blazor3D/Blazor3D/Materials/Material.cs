using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor3D.Materials
{
    public abstract class Material
    {
        protected Material(string type)
        {
            Type = type;
        }

        public string Type { get; } = "Material";

        public string Name { get; set; } = string.Empty;

        public string UUID => Guid.NewGuid().ToString().ToLower();
    }
}
