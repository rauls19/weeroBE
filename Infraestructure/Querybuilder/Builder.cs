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
    public class Builder
    {
        private IDictionary<string, string> queries;

        public Builder(){}

        public Builder(List<Query> listedqueries)
        {
            queries = new Dictionary<string, string>();
            foreach(var query in listedqueries){
                queries.Add(query.identifier, query.query);
            }
        }
        public string GetQuery(string identifier)
        {
            string value;
            if(!queries.TryGetValue(identifier, out value)){
                return String.Empty; //Error
            }
            return value;
        }
    }
}
