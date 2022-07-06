using System.Xml;

namespace ReferenceGenerator.Models
{
    public class MethodModel : BaseModel
    {
        public MethodModel() : base("Method")
        {
        }
        protected MethodModel(string type) : base(type)
        {
        }

        public List<BaseModel> Params { get; } = new List<BaseModel>();

        public override void Parse()
        {
            var name = Name.Replace(".#ctor", null)
                .Replace("System.String", "string")
                .Replace("System.Single", "float");

            Name = new string(name);

            var fullName = name;
            var prms = string.Empty;
            int idx = name.LastIndexOf("(");

            if (idx != -1)
            {
                fullName = name[..idx];
                prms = name[(idx)..];
            }

            idx = fullName.LastIndexOf(".");
            if (idx == -1)
            {
                return;
            }

            //Name = fullName;
            ShortName = fullName[(idx + 1)..] + prms;

            if (XmlNode.HasChildNodes)
            {
                foreach (XmlNode node in XmlNode.ChildNodes)
                {
                    if (node.Name == "summary")
                    {
                        Summary = node.InnerText.Trim();
                    };

                    if (node.Name == "param")
                    {
                        var pname = node.Attributes?.GetNamedItem("name")?.Value ?? string.Empty;
                        Params.Add(new Param
                        {
                            ShortName = pname,
                            Name = pname,
                            Summary = node.InnerText
                        });
                    }
                }
            }
        }
    }
}
