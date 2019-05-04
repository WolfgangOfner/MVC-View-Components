using FakeItEasy;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using ViewComponentsDemo.Data;
using ViewComponentsDemo.ViewComponents;
using Xunit;

namespace ViewComponentsDemo.Test
{
    public class DerivedViewComponentTests
    {
        public DerivedViewComponentTests()
        {
            _testee = new DerivedViewComponent(A.Fake<ICountryRepository>());
        }

        private readonly DerivedViewComponent _testee;

        [Fact]
        public void Invoke_WhenParameterIsProvided_ShouldReturnContentString()
        {
            var result = _testee.Invoke(true);

            ((ContentViewComponentResult)result).Content.Should().Be
                ("Doing something with the value provided from the parent view");
        }
    }
}