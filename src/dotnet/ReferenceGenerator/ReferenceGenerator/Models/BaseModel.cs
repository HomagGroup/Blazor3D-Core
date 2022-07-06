using System.Xml;

namespace ReferenceGenerator.Models
{
    public abstract class BaseModel
    {
        public string Name { get; set; } = null!;
        public XmlNode XmlNode { get; set; } = null!;
        public virtual void Parse() { }
    }
}
