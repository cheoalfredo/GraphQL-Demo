using ApiQL.Schema.Types;
using ApiQL.Services;
using GraphQL;
using GraphQL.Types;

namespace ApiQL.Schema.Queries
{
    public class ArtistaQuery : ObjectGraphType
    {
        public ArtistaQuery(ArtistaService _service)
        {
            Field<ListGraphType<ArtistaType>>(name: "artistas", resolve: context => _service.ListarArtistas());
            Field<ListGraphType<AlbumType>>(name: "albums", resolve: context => _service.ListartAlbums());
            Field<ArtistaType>(name: "artista", arguments: 
             new QueryArguments(new QueryArgument<GuidGraphType> { Name = "id" }),
             resolve: context => _service.ArtistaPorId(context.GetArgument<System.Guid>("id")));
            Field<ListGraphType<AlbumType>>(name: "por_artista", arguments: 
             new QueryArguments(new QueryArgument<GuidGraphType> { Name = "id" }),
             resolve: context => _service.AlbumPorArtista(context.GetArgument<System.Guid>("id")));            
        }
    }
}