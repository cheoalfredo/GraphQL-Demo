using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiQL.Models;
using GraphQL;
using GraphQL.Types;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ApiQL.Controllers
{
    [ApiController, Route("api/gql")]    
    public class QLController : ControllerBase
    {
        private readonly ISchema _schema;
        private readonly IDocumentExecuter _executer;
        public QLController(ISchema schema, IDocumentExecuter executer)
        {
            _schema = schema;
            _executer = executer;
        }

        [HttpPost]
        public async Task<ExecutionResult> Post([FromBody] GqlQuery query){
            var result = await _executer.ExecuteAsync(_ => {
                _.Schema = _schema;
                _.Query = query.Query;
                _.Inputs = query.Vars?.ToInputs();
            });
            return result;
        }
    }
}