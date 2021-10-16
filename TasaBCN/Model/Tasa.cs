using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TasaBCN.Model
{
    [XmlRoot(ElementName = "Tc")]
    public class Tasa
    {
        [XmlElement(ElementName = "Fecha")]
        public string Date { get; set; }
        [XmlElement(ElementName = "Valor")]
        public decimal Value { get; set; }
        [XmlElement(ElementName = "Ano")]
        public int Year { get; set; }
        [XmlElement(ElementName = "Mes")]
        public int Month { get; set; }
        [XmlElement(ElementName = "Dia")]
        public int Day { get; set; }
    }
}
