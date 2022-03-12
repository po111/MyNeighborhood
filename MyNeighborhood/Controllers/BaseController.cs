using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MyNeighborhood.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
        
    }
}
