using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExpressoApi.Data;
using ExpressoApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExpressoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationsController : ControllerBase
    {
        private ExpressDBcontext _expressoDbcontext;
        public ReservationsController(ExpressDBcontext expressDBcontext)
        {
            _expressoDbcontext = expressDBcontext;
        }

        [HttpPost]
        public IActionResult Post(Reservation reservation, int id)
        {
            _expressoDbcontext.Reservations.Add(reservation);
            _expressoDbcontext.SaveChanges();

            return StatusCode(StatusCodes.Status201Created);
        }
    }
}