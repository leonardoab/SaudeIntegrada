﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SaudeIntegrada.Api.Controllers;
using SaudeIntegrada.Application.Dto;
using SaudeIntegrada.Application.IService;
using SaudeIntegrada.Repository.Context;

namespace SaudeIntegrada.Tests.Domain
{
    [Collection("Pessoa collection")]
    public class PessoaTest : IClassFixture<DependencyInjection>
    {
        private readonly IPessoaService _PessoaService;

        public PessoaTest(DependencyInjection dependencyInjection)
        {
            _PessoaService = dependencyInjection.ServiceProvider.GetRequiredService<IPessoaService>();
        }

        private DbContextOptions<SaudeIntegradaContext> options;


        [Fact]
        public async Task DeveCriarPessoaComSucesso()
        {
            PessoaDto pessoa = new PessoaDto()
            {
                Nome = "Joao da Silva",
                DataNascimento = DateTime.Now,
                Sexo = "M",
                Telefone = "21988665544"
            };

            var controller = new PessoaController(_PessoaService);
            var result = controller.Criar(pessoa);

            Assert.True(result is CreatedResult);

        }

        [Fact]
        public void NaoDeveCriarSemRequest()
        {
            PessoaDto pessoa = new PessoaDto();

            var controller = new PessoaController(_PessoaService);
            var result = controller.Criar(pessoa);

            Assert.True(result is BadRequestResult);
        }


        [Fact]
        public void ListaTodos()
        {
            var controller = new PessoaController(_PessoaService);
            var result = controller.ListaTodos();
            var statusCode = (result as OkObjectResult).StatusCode;
            //var res = (result as OkObjectResult).Value as IEnumerable<PessoaDto>;
            
            Assert.True(statusCode.Equals(200));
        }


        [Fact]
        public void DeveObterPessoaPorId()
        {
            var id = new Guid("96dde085-f7d2-4997-24cc-08dc58fbaf86");

            var controller = new PessoaController(_PessoaService);
            var result = controller.GetPessoasPorId(id);
            var res = (result as OkObjectResult).Value as PessoaDto;
            Assert.True(res is not null);

        }
    }
}
