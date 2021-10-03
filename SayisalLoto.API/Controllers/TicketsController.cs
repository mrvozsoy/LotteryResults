using Microsoft.AspNetCore.Mvc;
using SayisalLoto.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SayisalLoto.API.DataLayer;
using SayisalLoto.API.BusinessLayer;

namespace SayisalLoto.API.Controllers
{
    [Route("api/controller")]
    public class TicketsController:ControllerBase
    {
      
        
        [HttpGet()]
        public List<ReturnModel> Get(InputModel inputModel)
        {
            var businessService = new Business();
            return businessService.GetData(inputModel);
        }


    }
}
