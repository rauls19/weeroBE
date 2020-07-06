using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Model
{
    public class StorageAccount
    {
        public string AccountName { get; set; }
        public string AccountKey{ get; set; }
        public string BlobEndpoint {get; set; }
        public string QueueEndpoint {get; set; }
        public string TableEndpoint {get; set; }
        public string DefaultEndpointsProtocol { get; set; }
        public string ConnectionString { get; set; }
    }
}