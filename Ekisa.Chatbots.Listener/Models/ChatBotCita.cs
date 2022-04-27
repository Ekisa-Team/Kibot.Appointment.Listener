﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekisa.ChatBot.Client.Models
{
    public class ChatBotCita
    {
        public int Id { get; set; }
        public short? IdCliente { get; set; }
        public decimal? NumeroCita { get; set; }
        public DateTime? FechaCita { get; set; }
        public DateTime? HoraCita { get; set; }
        public string IdPaciente { get; set; }
        public string NombresPaciente { get; set; }
        public string Celular { get; set; }
        public bool? Enviado { get; set; }
        public string Profesional { get; set; }
        public string Institucion { get; set; }
        public DateTime? FechaHoraEnvio { get; set; }
        public string Respuesta { get; set; }
        public DateTime? FechaHoraRespuesta { get; set; }
    }
}
