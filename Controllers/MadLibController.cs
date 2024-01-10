using MC5to7.Services.MadLib;
using Microsoft.AspNetCore.Mvc;

namespace MC5to7.Controllers;

    [ApiController]
    [Route("api/[controller]")]
    public class MadLibController : ControllerBase
    {
    private readonly IMadLibService _madLibService;

    public MadLibController(IMadLibService madLibService)
    {
        _madLibService = madLibService;
    }

    [HttpGet]
    [Route("Madness/{adject1}/{charaName}/{adject2}/{noun1}/{noun2}/{noun3}/{color1}/{noun4}/{adject3}/{noun5}/{adject4}/{onomat1}/{adject5}/{color2}/{noun6}/{noun7})")]

    public string Madness(string adject1, string charaName, string adject2, string noun1, string noun2, string noun3, string color1, string noun4, string adject3, string noun5, string adject4, string onomat1, string adject5, string color2, string noun6, string noun7)
    {
        return _madLibService.Madness(adject1, charaName, adject2, noun1, noun2, noun3, color1, noun4, adject3, noun5, adject4, onomat1, adject5, color2, noun6, noun7);
    }
}
