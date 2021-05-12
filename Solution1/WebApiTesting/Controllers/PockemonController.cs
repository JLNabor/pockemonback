using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiTesting.Interface;
using WebApiTesting.Model;

namespace WebApiTesting.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PockemonController : ControllerBase
    {
        private readonly IPockemonService _pockemonService;
        public PockemonController(IPockemonService pockemonService) {
            this._pockemonService = pockemonService;
        }

        [HttpGet]
        public IEnumerable<Pockemo> GetAll() {
            return this._pockemonService.GetAll();
        }

        [HttpGet("{id}")]
        public Pockemo GetById(int id)
        {
            return this._pockemonService.GetById(id);
        }
    }
}
