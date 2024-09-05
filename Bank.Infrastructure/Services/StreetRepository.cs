﻿using Bank.Domain.Entities;
using Bank.Infrastructure.Interfaces;
using Bank.Infrastructure.RepositeryShared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Infrastructure.Services
{
    public class StreetRepository : GenericRepository<Street>, IStreetRepository
    {
        public StreetRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
