using System;
using Core.Interface;
using System.Threading.Tasks;
using Core.Model;
using Infraestructure.Interface;
using System.Linq;
using Core.Mapper;
using System.Collections.Generic;

namespace Core.Business
{
    public class DiscoBI : IDiscoBI
    {
        private readonly IDiscoRespository repository;

        public DiscoBI(IDiscoRespository repository)
        {
            this.repository = repository;
        }
        public async Task<List<DiscoDto>> GetListDisco(int maxresults, int offset){
            var disco = await repository.GetDisco(maxresults, offset);
            return disco.ToList().EntityDto();
        }
    }
}
