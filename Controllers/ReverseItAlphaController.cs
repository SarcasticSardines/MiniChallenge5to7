using MC5to7.Services.ReverseItAlpha;
using Microsoft.AspNetCore.Mvc;

namespace MC5to7.Controllers;

    [ApiController]
    [Route("api/[controller]")]
    public class ReverseItAlphaController : ControllerBase
    {
    private readonly IReverseItAlpha _reverseItAlpha;

    public ReverseItAlphaController(IReverseItAlpha reverseItAlpha)
    {
        _reverseItAlpha = reverseItAlpha;
    }

    [HttpGet]
    [Route("GetRAlpha/{reverseAlpha}")]

    public string GetRAlpha(string reverseAlpha)
    {
        return _reverseItAlpha.GetRAlpha(reverseAlpha);
    }
}
