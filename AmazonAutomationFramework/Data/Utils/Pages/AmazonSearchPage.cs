using System.Threading.Tasks;
using Microsoft.Playwright;

namespace Framework.Pages
{
    public class AmazonSearchPage
    {
        private readonly IPage _page;
        private readonly ILocator _searchbox = null!;
         private readonly ILocator _categoryDropdown = null!; 

        public AmazonSearchPage(IPage Page)
        {
            _page = Page;

            _searchbox = Page.GetByPlaceholder("Search Amazon.in");

            _categoryDropdown = Page.Locator("#searchDropdownBox");
        }

        public async Task searchProduct(string item, string category)
        {
            await _categoryDropdown.SelectOptionAsync(new SelectOptionValue {Label = category});
            await _searchbox.FillAsync(item);
            await _searchbox.PressAsync("Enter");
           
        }
        
    }
}

