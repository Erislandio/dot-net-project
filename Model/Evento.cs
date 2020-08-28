using Microsoft.EntityFrameworkCore;

namespace ProAgil.Api.Model
{
    public class Evento
    {

        public int EventId { get; set; }

        public string Local { get; set; }

        public string DataEvento { get; set; }

        public string Tema { get; set; }

        public int Quantidade { get; set; }

        public string Lote { get; set; }
    }
}