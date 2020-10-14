using System.Collections.Generic;

namespace ApiQL.Models
{
    public class GqlQuery
    {
        public string Operation { get; set; }
        public string NamedQuery { get; set; }
        public string Query { get; set; }
        public Dictionary<string,object>  Vars { get; set; }
    }

}