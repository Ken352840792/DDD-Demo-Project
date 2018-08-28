using Boss.DDD.Dtos;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;

namespace Boss.DDD.Test
{
    [TestClass]
    public class ProductTest
    {
        private HttpClient http;

        [TestMethod]
        public void AddProductTest()
        {
            http = new HttpClient();
            var fs = new FileStream(@"C:\Users\Ken\source\repos\Boss.DDD\Boss.DDD.Test\Img\photo.png", FileMode.Open, FileAccess.Read);
            var by = new byte[fs.Length];
            fs.Read(by, 0, Convert.ToInt32(fs.Length));
            fs.Close();
            var addProductSPUDto = new AddProductSPUDto()
            {
                SPUName = "����SPU����",
                SPUDes = "����SPU��ϸ",
                SKUSpecs = new List<string>() {
                    "����500����","����700����"
                },
                SKUUnits = new List<string>() {
                     "ƿ","ƿ"
                },
                SKUDealerPrices = new List<decimal>() {
                     100,120
                },
                SKUImages = new List<byte[]>()
                {
                    by,by
                },
                SKUPV = new List<decimal>() {
                    120,200
                }
            };

            var json = JsonConvert.SerializeObject(addProductSPUDto);
            HttpContent httpContent = new StringContent(json);
            httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            var result = http.PostAsync("http://localhost:54309/api/Product/AddProduct", httpContent).Result;
            var val = result.Content.ReadAsStringAsync();
        }
    }
}