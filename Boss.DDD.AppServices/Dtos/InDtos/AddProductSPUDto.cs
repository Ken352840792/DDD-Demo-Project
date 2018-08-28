using System;
using System.Collections.Generic;
using System.Text;

namespace Boss.DDD.Dtos
{
    public class AddProductSPUDto
    {
        public string SPUName { get; set; }
        public string SPUDes { get; set; }
        public List<string> SKUSpecs { get; set; }
        public List<string> SKUUnits { get; set; }
        public List<decimal> SKUDealerPrices { get; set; }
        public List<byte[]> SKUImages { get; set; }
        public List<decimal> SKUPV { get; set; }
    }
}