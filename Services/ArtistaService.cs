using System;
using System.Collections.Generic;
using ApiQL.Models;

namespace ApiQL.Services {
    public class ArtistaService {

        private readonly ArtistaRepository _artistaRepository;
        public ArtistaService(ArtistaRepository repository)
        {
            _artistaRepository = repository;
        }

        public List<Artista> ListarArtistas() => _artistaRepository.TodosLosArtistas();    
        public List<Album> ListartAlbums() => _artistaRepository.TodosLosAlbums();
        public List<Album> AlbumPorArtista(Guid artistaId) => _artistaRepository.AlbumsPorArtista(artistaId);
        public Artista ArtistaPorId(Guid artistaId) => _artistaRepository.ArtistaPorId(artistaId);
    }
}