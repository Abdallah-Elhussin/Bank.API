using Bank.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Application.Dto.SexDto
{
    public class SexDto
    {
        public int Id { get; set; }
        public  string SexType { get; set; }
    }

    public class CreateSexDto
    {

        public  string SexType { get; set; }
    }
}
