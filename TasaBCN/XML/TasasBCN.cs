﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TasaBCN.Model;

namespace TasaBCN.XMLModel
{
    [XmlRoot(ElementName = "Detalle_TC")]
    public class TasasBCN
    {
        [XmlElement(ElementName = "Tc")]
        public List<Tasa> TasasCambio { get; set; }
    }
   
}
