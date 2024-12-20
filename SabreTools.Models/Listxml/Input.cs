using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.Listxml
{
    [XmlRoot("input")]
    public class Input
    {
        /// <remarks>(yes|no) "no"</remarks>
        [XmlAttribute("service")]
        public string? Service { get; set; }

        /// <remarks>(yes|no) "no"</remarks>
        [XmlAttribute("tilt")]
        public string? Tilt { get; set; }

        /// <remarks>Numeric</remarks>
        [Required]
        [XmlAttribute("players")]
        public string? Players { get; set; }

        /// <remarks>Only present in older versions</remarks>
        [XmlAttribute("control")]
        public string? ControlAttr { get; set; }

        /// <remarks>Only present in older versions, Numeric?</remarks>
        [XmlAttribute("buttons")]
        public string? Buttons { get; set; }

        /// <remarks>Numeric?</remarks>
        [XmlAttribute("coins")]
        public string? Coins { get; set; }

        [XmlElement("control")]
        public Control[]? Control { get; set; }
    }
}