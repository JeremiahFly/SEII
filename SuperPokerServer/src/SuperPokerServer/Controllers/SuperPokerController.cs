using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Ringmaster.Models;
using Ringmaster.Service;
using System;

namespace Ringmaster.Controllers
{
    [Route("api/[controller]")]
    public class SuperPokerController : Controller
    {
        private SuperPokerService SuperPokerService { get; set; }

        public SuperPokerController(SuperPokerService superPokerService)
        {
            this.SuperPokerService = superPokerService;
        }

        [HttpGet]
        public SuperPokerDeck Get()
        {
            try
            {
                //this.SuperPokerService.AddPlayer(this.Request.Host.Value);

                return this.SuperPokerService.GameStart();
            }catch(Exception e)
            {
                errorController.e = e;
                return null;
            }
        }

        [HttpPost]
        public void Post([FromBody] SuperPokerDeck newDeck)
        {
            try
            {
                this.SuperPokerService.SetCurrentDeck(newDeck);
            }catch (Exception e)
            {
                errorController.e = new Exception(e.Message + " !!!!!in post!!!!!!");
            }
        }
    }
}
