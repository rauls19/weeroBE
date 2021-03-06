using System;
using Core.Interface;
using System.Threading.Tasks;
using Core.Model;
using Infraestructure.Interface;
using System.Linq;
using Core.Mapper;
using System.Collections.Generic;
using Microsoft.Extensions.Options;

namespace Core.Business
{
    public class MatchBI : IMatchBI
    {
        private readonly IMatchRepository repository;
        private readonly IOptions<StorageAccount> context;

        public MatchBI(IMatchRepository repository, IOptions<StorageAccount> context)
        {
            this.repository = repository;
            this.context =  context;
        }
        public async Task<List<MatchDto>> GetListSwap(string userid, int interested, char genre, int discoid, int offset){
            var match = await repository.GetSwap(userid, interested, genre, discoid, offset);
            return match.ToList().EntityDto();
        }
        public async Task<bool> MatchedUser(string userorigin, string userlike){
            return await repository.MatchEvaluation(userorigin, userlike);
        }
        public async Task UnMatchedUser(string userorigin, string userlike){
            await repository.UnMatch(userorigin, userlike);
        }
    }
}
