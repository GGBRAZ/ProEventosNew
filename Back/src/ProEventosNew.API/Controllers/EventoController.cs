using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventosNew.API.Models;

namespace ProEventosNew.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _eventos = new Evento[]{
            new Evento(){
                EventoId = 1,
                Tema = "Angular 11 e .Net 5",
                Local = "Belo Horizonte",
                Lote = "1º Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString(),
                ImagemURL = "foto.png"
            },
            new Evento(){
                EventoId = 2,
                Tema = "Angular e Suas Novidades",
                Local = "São Paulo",
                Lote = "2º Lote",
                QtdPessoas = 350,
                DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                ImagemURL = "foto1.png"
            }
        };

        public EventoController()
        {
        }

        [HttpGet]
        public IEnumerable<Evento> Get() => _eventos;

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
            => _eventos.Where(ev => ev.EventoId == id);

        [HttpPost]
        public string Post()
        {
            return "Exemplo de post";
        }

        [HttpPut("{id}")]
        public string Post(int id)
        {
            return $"Exemplo de put com id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de delete com id = {id}";
        }
    }
}
