using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.Listxml
{
    [XmlRoot("extension")]
    public class Extension
    {
        [Required]
        [XmlAttribute("name")]
        public string? Name { get; set; }
    }
}