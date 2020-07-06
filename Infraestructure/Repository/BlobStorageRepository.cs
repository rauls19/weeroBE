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
            IDictionary<string, string> metadata = new Dictionary<string, string>();

        // Add some metadata to the container.
            metadata.Add("metadata", "true");
            var blobclient = containerClient.GetBlobClient(order.ToString());
            await blobclient.SetMetadataAsync(metadata);
            await blobclient.UploadAsync(new MemoryStream(image));      
        }
        public async Task RemoveBlobContainer(string connectionString, string containerName, int order)
        {
            await containerClient.DeleteBlobIfExistsAsync(order.ToString());
        }
        public async Task RemoveContainer(string connectionString, string containerName)
        {
            await containerClient.DeleteIfExistsAsync();
        }
    }
}
