using ApiQL.Models;
using GraphQL.Types;

namespace ApiQL.Schema.Types {
    
    public class ArtistaType : ObjectGraphType<Artista> {
    
        public ArtistaType()
        {
            this.Name = "artista";
            Field(_ => _.Id).Description("Id del autor");
            Field(_ => _.Genero).Description("Genero musical de autor");
            Field(_ => _.Nombre).Description("Nombre del autor");
        }
    
    }
    
}