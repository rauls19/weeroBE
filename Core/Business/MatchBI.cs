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
    public class MatchBI : IMatchBI
    {
        private readonly IMatchRepository repository;

        public MatchBI(IMatchRepository repository)
        {
            this.repository = repository;
        }
        public async Task<List<DiscoDto>> GetListSwap(int userid, int interested, char genre, int discoid, int offset){
            //If I only have the identifier, I should get the info from UserRepository
            var match = await repository.GetSwap(userid, interested, genre, discoid, offset);
            return match.ToList().EntityDto();
        }
    }
}
