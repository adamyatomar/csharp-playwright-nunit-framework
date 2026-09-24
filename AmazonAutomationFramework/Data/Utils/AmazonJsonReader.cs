using System;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;
using System.Collections.Generic;
using Framework.Data;

namespace Framework.Utils
{
    public class AmazonJsonReader
    {
        public static List<AmazonDataModel> GetItemsData()
        {
           var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "AmazonData.json");

           string jsonText = File.ReadAllText(filePath);

           var dataList = JsonSerializer.Deserialize<List<AmazonDataModel>>(jsonText)!;

           return dataList;

        }
    }
}