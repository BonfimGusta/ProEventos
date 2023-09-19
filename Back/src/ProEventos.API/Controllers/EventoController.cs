using System.Data.Common;
using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
        [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[] 
            {
                new Evento() {
                    EventoId = 1,
                    Tema = "Angular 11 e .NET 5",
                    Local = "Belo Horizonte",
                    Lote = "1º Lote",
                    QntPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                    ImageURL = "Foto.png",
                },

                new Evento() {
                    EventoId = 2,
                    Tema = "Angular e suas novidades",
                    Local = "São Paulo",
                    Lote = "2º Lote",
                    QntPessoas = 350,
                    DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                    ImageURL = "Foto1.png",
                },

                new Evento() {
                    EventoId = 3,
                    Tema = "Aprenda Angular",
                    Local = "Rio de Janeiro",
                    Lote = "2º Lote",
                    QntPessoas = 378,
                    DataEvento = DateTime.Now.AddDays(120).ToString("dd/MM/yyyy"),
                    ImageURL = "Foto2.png",
                },

                new Evento() {
                    EventoId = 4,
                    Tema = "Projeto Angular ATUALIZADO",
                    Local = "Remoto",
                    Lote = "2º Lote",
                    QntPessoas = 420,
                    DataEvento = DateTime.Now.AddDays(15).ToString("dd/MM/yyyy"),
                    ImageURL = "Foto3.png",
                },

                new Evento() {
                    EventoId = 5,
                    Tema = "APRENDA C#",
                    Local = "Bahia",
                    Lote = "1º Lote",
                    QntPessoas = 1350,
                    DataEvento = DateTime.Now.AddDays(45).ToString("dd/MM/yyyy"),
                    ImageURL = "Foto4.png",
                },
            };

        public EventoController()
        {
        
        }
        
        [HttpGet(Name = "GetEvento")]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
        }

        [HttpPost(Name = "PostEvento")]
        public string Post()
        {
            return "Exemplo de Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de Put com id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de Delete com id = {id}";
        }
    }
}


