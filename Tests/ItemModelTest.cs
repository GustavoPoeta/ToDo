using API.Models;

namespace apiTests
{
    public class ItemModelTest
    {
        [Fact]
        public void Invalid_name_param_throw_error()
        {
            // name is invalid, error should be ArgumentException: "name is not valid"
            const string invalidName = "";
            const string validDescription = "Hello world";
            
            var johnDoe = ItemFactory.Create(invalidName, validDescription);
        }
    }
}