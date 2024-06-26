﻿using AutoMapper;
using SaudeIntegrada.Application.Dto;
using SaudeIntegrada.Application.IService;
using SaudeIntegrada.Domain.IRepository;
using SaudeIntegrada.Domain.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaudeIntegrada.Application.Service
{
    public class AvaliacaoFichaService : IAvaliacaoFichaService
    {
        private readonly IAvaliacaoFichaRepository AvaliacaoFichaRepository;
        private readonly IMapper mapper;
        private readonly IPessoaRepository PessoaRepository;

        public AvaliacaoFichaService(IAvaliacaoFichaRepository AvaliacaoFichaRepository, IMapper mapper, IPessoaRepository PessoaRepository)
        {
            this.AvaliacaoFichaRepository = AvaliacaoFichaRepository;
            this.mapper = mapper;
            this.PessoaRepository = PessoaRepository;
        }

        public AvaliacaoFichaDto Criar(AvaliacaoFichaCriarDto dto)
        {
            AvaliacaoFicha avaliacaoFicha = this.mapper.Map<AvaliacaoFicha>(dto);

            Pessoa pessoa = PessoaRepository.GetById(dto.IdPessoa);

            avaliacaoFicha.Pessoa = pessoa;

            this.AvaliacaoFichaRepository.Save(avaliacaoFicha);

            AvaliacaoFichaDto avaliacaoFichaDto = this.mapper.Map<AvaliacaoFichaDto>(avaliacaoFicha);

            avaliacaoFichaDto.IdPessoa = dto.IdPessoa;

            return avaliacaoFichaDto;
        }

        public AvaliacaoFichaDto Editar(AvaliacaoFichaDto dto)
        {
            AvaliacaoFicha avaliacaoFicha = this.mapper.Map<AvaliacaoFicha>(dto);
            Pessoa pessoa = PessoaRepository.GetById(dto.IdPessoa);
            avaliacaoFicha.Pessoa = pessoa;
            this.AvaliacaoFichaRepository.Update(avaliacaoFicha);

            return this.mapper.Map<AvaliacaoFichaDto>(avaliacaoFicha);
        }

        public AvaliacaoFichaDto Apagar(Guid id)
        {
            AvaliacaoFicha avaliacaoFicha = this.AvaliacaoFichaRepository.GetById(id);

            if (!this.AvaliacaoFichaRepository.Exists(x => x.Id == id)) { throw new Exception("AvaliacaoFicha nao existe"); }
                        
            this.AvaliacaoFichaRepository.Delete(avaliacaoFicha);

            return this.mapper.Map<AvaliacaoFichaDto>(avaliacaoFicha);
        }

        public AvaliacaoFichaDto Obter(Guid id)
        {
            var avaliacaoFicha = this.AvaliacaoFichaRepository.GetById(id);
            return this.mapper.Map<AvaliacaoFichaDto>(avaliacaoFicha);
        }

        public IEnumerable<AvaliacaoFichaDto> ObterTodos()
        {
            var avaliacaoFicha = this.AvaliacaoFichaRepository.GetAll();
            return this.mapper.Map<IEnumerable<AvaliacaoFichaDto>>(avaliacaoFicha);
        }




    }
}
