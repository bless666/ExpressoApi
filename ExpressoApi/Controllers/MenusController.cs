using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ExpressoApi.Data;
using Microsoft.EntityFrameworkCore;

namespace ExpressoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        ExpressDBcontext _expressDBcontext;
        public MenuController(ExpressDBcontext expressDBcontext)
        {
            _expressDBcontext = expressDBcontext; 
        }
        [HttpGet]
        public IActionResult GetMenus()
        {
            var menus = _expressDBcontext.Menus.Include(m => m.Submenus);
            return Ok(menus);
        }
        [HttpGet("{id}")]
        public IActionResult GetMenu(int id)
        {
            var menu = _expressDBcontext.Menus.Include(m => m.Submenus).FirstOrDefault(m => m.Id == id);
                if (menu==null)
                {
                    return NotFound();
                }
            return Ok(menu);
        }
    }
}