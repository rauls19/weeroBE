using System.Buffers.Text;
using System;
using Core.Interface;
using System.Threading.Tasks;
using Core.Model;
using Infraestructure.Interface;
using System.Linq;
using Core.Mapper;
using Microsoft.Extensions.Options;
using Infraestructure.Repository;

namespace Core.Business
{
    public class UserBI:IUserBI
    {
        private readonly IUserRepository repository;
        private readonly IOptions<StorageAccount> context;

        public UserBI(IUserRepository repository, IOptions<StorageAccount> context)
        {
            this.repository = repository;
            this.context =  context;
        }
        public async Task<string> Test(){
            return "Hola";
        }
        public async Task<UserDto> LoginUser(int phone, string pass){
            
            var user = await repository.Login(phone, pass);
            
            if(user.Count >1) Console.WriteLine("Inconsistency DB");

            return user.ToList().SingleOrDefault().EntityDto();
        }
        public async Task UpdatePartyToGo(int id, string hashid){
            await repository.UpdatePartyToGo(id, hashid);
        }
        public async Task UploadImage(string containerName, int order, string image){
            //request bytes or base64 or whatever + iduser (hashid) +order
            BlobStorageRepository blobs = new BlobStorageRepository(context.Value.ConnectionString, containerName.ToLower());
            byte [] newimage = Convert.FromBase64String(image);
            await blobs.UploadimageBlob(order, newimage);
            await repository.UpdatePhoto(containerName.ToLower(), order);
        }
    }
}
