// Fernando Aguilar
// 10-25-22
// Adding 2 Number Endpoint
// We are taking our second mini challenge and converting it to API format.
// The program will allow the user to input two different numbers and they output
// on Postman will add the two numbers together.
// Peer Reviewed By: Jacob Dekok - The code looks good spaced out, and organized.
// The program runs great and as intended.


using Microsoft.AspNetCore.Mvc;

namespace AguilarFAdding2NumbersEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class AddingNumbersController : ControllerBase
{
    [HttpGet]
    [Route("Adding/{number1}/{number2}")]

    public int Math(string number1, string number2)
    {
        int convertNum1 = Convert.ToInt32(number1);
        int convertNum2 = Convert.ToInt32(number2);
        return convertNum1 + convertNum2;
    }
}
