using ApiQL.Models;
using GraphQL.Types;

namespace ApiQL.Schema.Types {

     public class AlbumType : ObjectGraphType<Album> {
         
         public AlbumType()
         {
             this.Name = "album";
             Field(_ => _.Id).Description("Album id");
             Field(_ => _.Nombre).Description("Titulo del album");  
             Field(_ => _.Artista, type: typeof(ArtistaType)).Description("Artista del album");         
         }

     }

}