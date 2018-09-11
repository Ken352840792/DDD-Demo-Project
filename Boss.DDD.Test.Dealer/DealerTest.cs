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
    public class DealerTest
    {
        private HttpClient http;
        [TestMethod]
        public void AddDealerTest()
        {
            http = new HttpClient();
            var addDealerDto = new AddDealerDto()
            {
                Name = "沈柱",
                Tel = "123456789",
                ContactName = new List<string>() { "张三", "李四" },
                ContactTel = new List<string> { "1234567", "7654321" },
                ContactIsDefault = new List<int> { 1, 0 },
                ContactSheng = new List<string> { "湖北省", "上海省" },
                ContactShi = new List<string> { "武汉", "上海市" },
                ContactQu = new List<string> { "黄陂区", "闵行区" },
                ContactJiedao = new List<string> { "李家集", "联航路" },
                EleMoney = 2000
            };
            var json = JsonConvert.SerializeObject(addDealerDto);
            HttpContent httpContent = new StringContent(json);
            httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            var result = http.PostAsync("http://localhost:57817/api/Dealer/AddDealer", httpContent).Result;
            var val = result.Content.ReadAsStringAsync().Result;
        }
    }
}