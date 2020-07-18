using System.IO;
using System;
using System.Collections.Generic;
using Infraestructure.Interface;
using System.Threading.Tasks;
using Infraestructure.Entity;
using System.Data;
using System.Data.Common;
using Azure.Storage.Blobs;

namespace Infraestructure.Querybuilder
{
    public class Query
    {
        public string identifier { get; set; }
        public string query { get; set; }
    }
}
