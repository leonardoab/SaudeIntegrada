﻿using SaudeIntegrada.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaudeIntegrada.Domain.Domains
{
    public class Conta : Entity<Guid>
    {
        public Pessoa Pessoa { get; set; }

        public string Apelido { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool Ativo {  get; set; }
        public string Telefone { get; set; }

        public Guid PessoaId { get; set; } // Chave estrangeira


    }
}
