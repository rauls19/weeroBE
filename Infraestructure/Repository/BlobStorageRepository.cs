using System.IO;
using System;
using System.Collections.Generic;
using Infraestructure.Interface;
using System.Threading.Tasks;
using Infraestructure.Entity;
using System.Data;
using System.Data.Common;
using Azure.Storage.Blobs;

namespace Infraestructure.Repository
{
    public class BlobStorageRepository
    {
        private BlobContainerClient containerClient;
        public BlobStorageRepository(string connectionString, string containerName){
            containerClient = new BlobContainerClient(connectionString, containerName);
        }
        public async Task UploadimageBlob(int order, byte[] image)
        {
            await containerClient.CreateIfNotExistsAsync();
            var blobclient = containerClient.GetBlobClient(order.ToString());
            await RemoveBlobContainer(order);
            await blobclient.UploadAsync(new MemoryStream(image));      
        }
        public async Task<> GetimageBlob(string id){
            if(await containerClient.ExistsAsync()){
                var f = containerClient.GetBlobClient(id);
                Stream im;
                var g = await f.DownloadAsync();
            }
        }
        public async Task RemoveBlobContainer(int order)
        {
            await containerClient.DeleteBlobIfExistsAsync(order.ToString());
        }
        public async Task RemoveContainer()
        {
            await containerClient.DeleteIfExistsAsync();
        }
    }
}
