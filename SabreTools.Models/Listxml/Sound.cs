using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.Listxml
{
    [XmlRoot("sound")]
    public class Sound
    {
        /// <remarks>Numeric</remarks>
        [Required]
        [XmlAttribute("channels")]
        public string? Channels { get; set; }
    }
}