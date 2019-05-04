using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace ViewComponentsDemo.ViewComponents
{
    public class ReturningHtml : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return new HtmlContentViewComponentResult(
                new HtmlString("This code was created in the ReturningHtml view component"));
        }
    }
}