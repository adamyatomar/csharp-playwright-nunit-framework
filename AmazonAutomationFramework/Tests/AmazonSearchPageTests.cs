using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;
using Framework.Pages;
using Framework.Data;
using Framework.Tests;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using Framework.Utils;



namespace Framework.Tests
{
    [TestFixture]
    public class AmazonSearchTest : PageTest
    {
        
           public static IEnumerable<TestCaseData> AmazonSearchProd()
        {    
           List<AmazonDataModel> dataList = AmazonJsonReader.GetItemsData();

          foreach(var items in dataList)
          {

           yield return new TestCaseData(items.amazonSearchKey, items.productCategory, items.testTimeout);
           
          }
            
        
        }



         [Test]
         [TestCaseSource(nameof(AmazonSearchProd))]
         [Description("Searching the products using Amazon SerachBox")]

         public async Task searchProds(string search, string category, int timeout)
        {
            await Page.GotoAsync("https://www.amazon.in");

            var SearchPage = new AmazonSearchPage(Page);

            await SearchPage.searchProduct(search, category);

        }
    }
}