using System;
using Core.Interface;
using System.Threading.Tasks;
using Core.Model;
using Infraestructure.Interface;
using System.Linq;
using Core.Mapper;
using System.Collections.Generic;
using Microsoft.Extensions.Options;
using Infraestructure.Repository;

namespace Core.Business
{
    public class DiscoBI : IDiscoBI
    {
        private readonly IDiscoRespository repository;
        private readonly IOptions<StorageAccount> context;

        public DiscoBI(IDiscoRespository repository, IOptions<StorageAccount> context)
        {
            this.repository = repository;
            this.context =  context;
        }
        public async Task<List<DiscoDto>> GetListDisco(int maxresults, int offset){
            var disco = await repository.GetDisco(maxresults, offset);
            //BlobStorageRepository blobs = new BlobStorageRepository(context.Value.ConnectionString, );
            //TODO get logo 
            return disco.ToList().EntityDto();
        }
    }
}
