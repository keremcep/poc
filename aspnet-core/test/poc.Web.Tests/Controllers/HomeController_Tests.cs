using System.Threading.Tasks;
using poc.Models.TokenAuth;
using poc.Web.Controllers;
using Shouldly;
using Xunit;

namespace poc.Web.Tests.Controllers
{
    public class HomeController_Tests: pocWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}