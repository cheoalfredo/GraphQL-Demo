using System;
using System.Collections.Generic;
using System.Linq;
using ApiQL.Models;

namespace ApiQL.Services
{

    public class ArtistaRepository
    {

        private readonly List<Artista> _artistas;
        private readonly List<Album> _albums;
        public ArtistaRepository()
        {
            _artistas = new List<Artista>();
            _albums = new List<Album>();
            _artistas.Add(new Artista
            {
                Nombre = "Diomedes Diaz",
                Genero = "Vallenato",
                Id = Guid.NewGuid()
            });

            _artistas.Add(new Artista
            {
                Nombre = "Freddie Mercury",
                Genero = "Rock",
                Id = Guid.NewGuid()
            });

            _albums.Add(new Album{
                Nombre = "Mi vida musical",
                Id = Guid.NewGuid(),
                Artista = _artistas.Where(a => a.Nombre.Equals("Diomedes Diaz")).FirstOrDefault()
            });
          
            _albums.Add(new Album{
                Nombre = "Tres Canciones",
                Id = Guid.NewGuid(),
                Artista = _artistas.Where(a => a.Nombre.Equals("Diomedes Diaz")).FirstOrDefault()
            });

            _albums.Add(new Album{
                Nombre = "Mr bad guy",
                Id = Guid.NewGuid(),
                Artista = _artistas.Where(a => a.Nombre.Equals("Freddie Mercury")).FirstOrDefault()
            });

            _albums.Add(new Album{
                Nombre = "Barcelona",
                Id = Guid.NewGuid(),
                Artista = _artistas.Where(a => a.Nombre.Equals("Freddie Mercury")).FirstOrDefault()
            });
        }

        public List<Artista> TodosLosArtistas() => this._artistas;

        public List<Album> TodosLosAlbums() => this._albums;

        public Artista ArtistaPorId(Guid id) => this._artistas.Where(a => a.Id.Equals(id)).FirstOrDefault();

        public List<Album> AlbumsPorArtista(Guid id) => this._albums.Where(a => a.Artista.Id.Equals(id)).ToList();

    }
}