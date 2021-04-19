using System;
using System.Collections;
using System.Collections.Generic;
using WebApplication.Models.WebApplication.Evento;
namespace WebApplication.Models.WebApplication.Cliente
{
    public class ClienteEntity
    {
        public Guid Id { get; set; }
            public string Nome { get; set; }
            public string Email { get; set; }
            public ICollection<EventoEntity> Eventos { get; set; }

            public ClienteEntity()
            {
                Id = new Guid();
                Eventos = new List<EventoEntity>();
            }
        }
    }