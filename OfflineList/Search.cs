using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.OfflineList
{
    [XmlRoot("search")]
    public class Search
    {
        [XmlElement("to")]
#if NET48
        public To[] To { get; set; }
#else
        public To[]? To { get; set; }
#endif

        #region DO NOT USE IN PRODUCTION

        /// <remarks>Should be empty</remarks>
        [XmlAnyAttribute]
#if NET48
        public XmlAttribute[] ADDITIONAL_ATTRIBUTES { get; set; }
#else
        public XmlAttribute[]? ADDITIONAL_ATTRIBUTES { get; set; }
#endif

        /// <remarks>Should be empty</remarks>
        [XmlAnyElement]
#if NET48
        public object[] ADDITIONAL_ELEMENTS { get; set; }
#else
        public object[]? ADDITIONAL_ELEMENTS { get; set; }
#endif

        #endregion
    }
}