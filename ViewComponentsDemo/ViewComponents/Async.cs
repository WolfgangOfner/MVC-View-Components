using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ViewComponentsDemo.ViewComponents
{
    public class Async : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            const string website = "https://www.google.com";
            var client = new HttpClient();
            var response = await client.GetAsync(website);

            return Content($"The size of {website} is " +
                           $"{response.Content.Headers.ContentLength.ToString()} bytes");
        }
    }
}