using ReferenceGenerator.Extensions;
using System.Xml;

namespace ReferenceGenerator.Models
{
    public abstract class BaseModel
    {
        protected BaseModel(string type = "Base")
        {
            Type = type;
        }
        public string Name { get; set; } = string.Empty;
        public string ShortName { get; set; } = string.Empty;
        public string NameSpace { get; set; } = string.Empty;
        public string Summary { get; set; } = string.Empty;
        public string Type { get; } = "Base";
        public string Inherit { get; set; }

        public List<BaseModel> Params { get; } = new List<BaseModel>();

        public XmlNode XmlNode { get; set; } = null!;

        public virtual void Parse()
        {
            int idx = Name.LastIndexOf('.');

            if (idx == -1)
            {
                return;
            }

            NameSpace = Name[..idx];
            ShortName = Name[(idx + 1)..];

            if (XmlNode.HasChildNodes)
            {
                foreach (XmlNode node in XmlNode.ChildNodes)
                {
                    if (node.Name == "summary")
                    {
                        Summary = node.InnerXml.Trim().ParseSummary();
                    };

                    if (node.Name == "inheritdoc")
                    {
                        Inherit = node.InnerXml.Trim().ParseSummary();
                    };

                    if (node.Name == "param")
                    {
                        var pname = node.Attributes?.GetNamedItem("name")?.Value ?? string.Empty;
                        Params.Add(new Param
                        {
                            ShortName = pname,
                            Name = pname,
                            Summary = node.InnerXml.Trim().ParseSummary()
                        });
                    }

                }
            }
        }
    }
}
