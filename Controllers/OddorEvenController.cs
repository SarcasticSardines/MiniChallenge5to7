using MC5to7.Services.OddorEven;
using Microsoft.AspNetCore.Mvc;

namespace MC5to7.Controllers;

    [ApiController]
    [Route("api/[controller]")]
    public class OddorEvenController : ControllerBase
    {
    private readonly IOddorEvenService _oddorEvenService;

    public OddorEvenController(IOddorEvenService oddorEvenService)
    {
        _oddorEvenService = oddorEvenService;
    }
    [HttpGet]
    [Route("GetEorO/{myNum}")]

    public string GetEorO(string myNum)
    {
        return _oddorEvenService.GetEorO(myNum);
    }
}
