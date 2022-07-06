namespace ReferenceGenerator.Models
{
    public class TypeModel : BaseModel
    {
        public List<MethodModel> Methods { get; set; } = new List<MethodModel>();
        public List<PropertyModel> Properties { get; set; } = new List<PropertyModel>();
        public List<FieldModel> Fields { get; set; } = new List<FieldModel>();
    }
}
