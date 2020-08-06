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
using System.Security.Cryptography;
using System.Text;

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
        public async Task<string> SignUp(UserDto request){
            var data = Encoding.UTF8.GetBytes(request.Name+request.Surname);
            byte[] result;
            SHA512 shaM = new SHA512Managed();
            result = shaM.ComputeHash(data);
            request.Hashid = Guid.NewGuid().ToString().ToLower()+Convert.ToBase64String(result);
            await repository.SignUp(request.DtoEntity());
            return request.Hashid;
        }
        public async Task<string> LoginUser(UserDto request){
            if(request.Phonenumber == 0 || string.IsNullOrEmpty(request.Password))
                throw new Exception("MalFormed input");
            return await repository.Login(request.Phonenumber, request.Password);
        }
        public async Task<UserDto> GetUser(string request){
            var user = await repository.GetUser(request);
            return user.EntityDto();
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
