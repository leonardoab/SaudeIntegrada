﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaudeIntegrada.Application.Dto
{
    public class ContaDto
    {
        public Guid Id { get; set; }
        public string Apelido { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        public string Telefone { get; set; }
    }

    public class ContaLoginDto
    {
        public string Password { get; set; }
        public string Email { get; set; }

    }



    }
