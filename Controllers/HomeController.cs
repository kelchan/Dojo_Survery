using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    [ HttpGet("") ]
    public ViewResult Index()
    {
        return View( "Index" );
    }


    // remember to use [HttpPost] attributes!
    [HttpPost("/process/survey")]
    public IActionResult ProcessSurvey( MySurvey newSurvey )
    {
        return View( "Result", newSurvey );
    }
}
