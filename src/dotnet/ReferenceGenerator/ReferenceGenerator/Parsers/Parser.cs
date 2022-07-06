using ReferenceGenerator.Models;
using System.Xml;

namespace ReferenceGenerator.Parsers
{
    public class Parser
    {
        public ReferenceModel Reference { get; set; }= new ReferenceModel { Name = "Blazor3D Reference Guide" };

        public void ReadAndParse(string fileName = "Blazor3D.xml")
        {

            var currentDir = Directory.GetCurrentDirectory();

            var path = Path.Combine(currentDir, @"..\..\..\..\doc\");
            var dirInfo = new DirectoryInfo(path);
            var pathName = Path.Combine(dirInfo.FullName, fileName);
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;

            XmlDocument document = new XmlDocument();
            document.Load(pathName);

            // first child is "xml", second "doc"
            XmlNode? docNode = document.LastChild;


            
            if (docNode == null) throw new KeyNotFoundException(nameof(docNode));
            XmlNode? assemblyNode = docNode?.FirstChild;
            if (assemblyNode == null) throw new KeyNotFoundException(nameof(assemblyNode));

            Reference.Assembly = new AssemblyModel
            {
                Name = assemblyNode?.Attributes?.GetNamedItem("name")?.Value ?? "Blazor3D"
            };


            XmlNode? membersNode = docNode?.LastChild;
            if (membersNode == null) throw new KeyNotFoundException(nameof(membersNode));

            if (membersNode.HasChildNodes == false)
                return;

            foreach (XmlNode memberNode in membersNode.ChildNodes)
            {
                var mName = memberNode?.Attributes?.GetNamedItem("name")?.Value ?? string.Empty ;
                Console.WriteLine($"{memberNode?.Attributes?.GetNamedItem("name")?.Value}");
                if (mName.StartsWith("T:"))
                {
                    Reference.Types.Add(new TypeModel
                    {
                        Name = mName.Replace("T:", null),
                        XmlNode = memberNode
                    });
                }
                if (mName.StartsWith("M:"))
                {
                    if (mName.Contains(".#ctor("))
                    {
                        Reference.Types.Last().Constructors.Add(new MethodModel
                        {
                            Name = mName.Replace("M:", null),
                            XmlNode = memberNode
                        });
                    }
                    else
                    {
                        Reference.Types.Last().Methods.Add(new MethodModel
                        {
                            Name = mName.Replace("M:", null),
                            XmlNode = memberNode
                        });
                    }
                }

                if (mName.StartsWith("P:"))
                {
                    Reference.Types.Last().Properties.Add(new PropertyModel
                    {
                        Name = mName.Replace("P:", null),
                        XmlNode = memberNode
                    });
                }

                if (mName.StartsWith("F:"))
                {
                    Reference.Types.Last().Fields.Add(new FieldModel
                    {
                        Name = mName.Replace("F:", null),
                        XmlNode = memberNode
                    });
                }
            }

            Reference.Parse();

        }
    }
}
