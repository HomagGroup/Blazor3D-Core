using System.Xml;

namespace ReferenceGenerator.Models
{
    public abstract class BaseModel
    {
        protected BaseModel(string type)
        {
            Type = type;
        }
        public string Name { get; set; } = string.Empty;
        public string ShortName { get; set; } = string.Empty;
        public string NameSpace { get; set; } = string.Empty;
        public string Summary { get; set; } = string.Empty;
        public string Type { get; } = "Base";



        public XmlNode XmlNode { get; set; } = null!;

        public virtual void Parse() {
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
                    if(node.Name == "summary")
                    {
                        Summary = node.InnerText.Trim();
                    };

                   
                }
            }
        }
    }
}
