using API.Models;

namespace apiTests
{
    public class ItemModelTest
    {
        [Fact]
        public void Invalid_id_param_throw_error()
        {
            // id is invalid, error should be ArgumentException: "id is not valid"
            const int id = -1;

            const string validName = "John Doe";
            const string validDescription = "Hello world";
            
            var johnDoe = ItemFactory.Create(id, validName, validDescription);
        }
    }
}