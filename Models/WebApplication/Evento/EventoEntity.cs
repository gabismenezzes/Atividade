using System;
using WebApplication.Models.WebApplication.Cliente;
namespace WebApplication.Models.WebApplication.Evento
{
    public class EventoEntity
        {
            public Guid Id { get; set; }
            public string Nome { get; set; }
            public ClienteEntity Cliente { get; set; }

            public EventoEntity()
            {
                Id = new Guid();
            }
        }
    }
