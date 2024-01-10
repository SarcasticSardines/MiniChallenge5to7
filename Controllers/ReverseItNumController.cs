using MC5to7.Services.ReverseItNum;
using Microsoft.AspNetCore.Mvc;

namespace MC5to7.Controllers;

    [ApiController]
    [Route("api/[controller]")]
    public class ReverseItNumController : ControllerBase
    {
    private readonly IReverseItNum _reverseItNum;

    public ReverseItNumController(IReverseItNum reverseItNum)
    {
        _reverseItNum = reverseItNum;
    }

    [HttpGet]
    [Route("GetRNum/{reverseNum}")]

    public string GetRNum(string reverseNum)
    {
        return _reverseItNum.GetRNum(reverseNum);
    }

    }
