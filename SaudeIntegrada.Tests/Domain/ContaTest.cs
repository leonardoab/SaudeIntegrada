﻿using Azure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using SaudeIntegrada.Api.Controllers;
using SaudeIntegrada.Application.Dto;
using SaudeIntegrada.Application.IService;
using SaudeIntegrada.Application.Service;

namespace SaudeIntegrada.Tests.Domain
{
    [Collection("Conta collection")]
    public class ContaTest : IClassFixture<DependencyInjection>
    {
        private readonly IContaService _ContaService;

        public ContaTest(DependencyInjection dependencyInjection)
        {
            _ContaService = dependencyInjection.ServiceProvider.GetRequiredService<IContaService>();
        }

        [Fact]
        public async Task DeveCriarContaComSucesso()
        {
            var conta = new ContaCriarDto()
            {
                Email = "teste_conta@teste.com",
                Password = "123456",
                Apelido = "teste_conta",
                Telefone = "21958922465"
            };

            var result = _ContaService.Criar(conta);
            Assert.True(result is not null);
        }

        [Fact]
        public async Task DeveEditar()
        {
            var conta = new ContaCriarDto()
            {
                Email = "teste2@teste.com",
                Password = "123456",
                Apelido = "teste2",
                Telefone = "21958926654"
            };

            var resultCriar = _ContaService.Criar(conta);

            resultCriar.Apelido = "teste112";

            var result = _ContaService.Editar(resultCriar);
            Assert.True(result is not null);
        }


        [Fact]
        public async Task DeveApagar()
        {
            var conta = new ContaCriarDto()
            {
                Email = "teste3@teste.com",
                Password = "123456",
                Apelido = "teste5",
                Telefone = "21958566654",
            };

            var contaCriada = _ContaService.Criar(conta);
            var result = _ContaService.Apagar(contaCriada.Id);
            Assert.True(result is not null);
        }

        [Fact]
        public async Task DeveListaTodos()
        {
            var result = _ContaService.ObterTodos();
            Assert.True(result is not null);
        }


        [Fact]
        public async Task DeveObterPessoaPorId()
        {
            var resultList = _ContaService.ObterTodos();
            var objPessoa = resultList.FirstOrDefault();
            var result = _ContaService.Obter(objPessoa.Id);
            Assert.True(result is not null);
        }


    }
}
