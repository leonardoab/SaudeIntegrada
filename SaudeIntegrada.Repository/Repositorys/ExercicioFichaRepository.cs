﻿using SaudeIntegrada.Domain.Domains;
using SaudeIntegrada.Domain.IRepository;
using SaudeIntegrada.Repository.Context;
using SaudeIntegrada.Repository.Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaudeIntegrada.Repository.Repository
{
    public class ExercicioFichaRepository : Repository<ExercicioFicha>, IExercicioFichaRepository
    {
        public ExercicioFichaRepository(SaudeIntegradaContext context) : base(context)
        {
        }
    }
}