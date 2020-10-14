using System;
using ApiQL.Schema.Queries;
using Microsoft.Extensions.DependencyInjection;

namespace ApiQL.Schema {

    public class DemoSchema : GraphQL.Types.Schema, GraphQL.Types.ISchema {
        public DemoSchema(IServiceProvider serviceProvider) : base(serviceProvider) 
        {
            Query = serviceProvider.GetService<ArtistaQuery>();
        }
    }
}