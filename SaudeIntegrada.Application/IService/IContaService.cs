﻿using SaudeIntegrada.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaudeIntegrada.Application.IService
{
    public interface IContaService
    {
        ContaDto Criar(ContaCriarDto dto);

        ContaDto Editar(ContaDto dto);

        ContaDto Apagar(Guid id);

        ContaDto Obter(Guid id);

        IEnumerable<ContaDto> ObterTodos();

        List<ContaDto> BuscarPorEmail(string email);

        List<ContaDto> BuscarPorTelefone(string telefone);
    }
}
