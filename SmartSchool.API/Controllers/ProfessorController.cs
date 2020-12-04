using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartSchool.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessorController : ControllerBase
    {
        public List<Professor> Professores = new List<Professor>()
        {
            new Professor()
            {
                Id = 1,
                Nome = "Matheus",
                               
            },

            new Professor()
            {
                Id = 2,
                Nome = "Julia",

            },

            new Professor()
            {
                Id = 3,
                Nome = "Roberto",

            },

            new Professor()
            {
                Id = 4,
                Nome = "Carla",

            },
        };
        public ProfessorController() { }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Professores);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            //var professor = Professor.FirstOrDefault(p == p.Id == id)
            return Ok(Professores);
        }
    }
}
