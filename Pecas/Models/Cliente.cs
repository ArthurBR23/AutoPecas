﻿using Microsoft.AspNetCore.Mvc;

namespace Pecas.Models
{
    public class Cliente
    {
        public long ClienteId { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
    }

}