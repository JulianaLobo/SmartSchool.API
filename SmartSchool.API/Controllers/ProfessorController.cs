﻿using Microsoft.AspNetCore.Http;
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

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var professor = Professores.FirstOrDefault(p => p.Id == id);
            if (professor == null) return BadRequest("O professor não foi encontrado");
            return Ok(professor);
        }

        [HttpGet("{nome}")]
        public IActionResult GetByName (string nome)
        {
            var professor = Professores.FirstOrDefault(p => p.Nome.Contains(nome));
            if (professor == null) return BadRequest("O professor não foi encontrado");
            return Ok(professor);
        }

        [HttpPost]
        public IActionResult Post(Professor professor)
        {
            return Ok(professor);
        }

        [HttpPut("{id:int}")]
        public IActionResult Put(int id, Professor professor)
        {
            return Ok(professor);
        }

        [HttpPatch("{id:int}")]
        public IActionResult Patch(int id, Professor professor)
        {
            return Ok(professor);
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
    }
}
