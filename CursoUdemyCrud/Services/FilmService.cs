using CursoUdemyCrud.Data;
using CursoUdemyCrud.Interfaces;
using Films.Data.Dapper.Repositories;
using Films.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CursoUdemyCrud.Services
{
    public class FilmService : IFilmService
    {
        private IFilmRepository _filmRepository;
        private readonly SqlConfiguration _configuration;

        public FilmService(SqlConfiguration sqlConfiguration)
        {
            _configuration = sqlConfiguration;
            _filmRepository = new FilmRepository(sqlConfiguration._cnnString);
            
        }

        public Task<bool> delete(int id)
        {
            return _filmRepository.delete(id);
        }

        public Task<IEnumerable<Film>> getAllFilms()
        {
            return _filmRepository.getAllFilms();
        }

        public Task<Film> getDetails(int id)
        {
            return _filmRepository.getFilm(id);
        }

        public Task<bool> save(Film film)
        {
            if(film.id == 0)
            {
                return _filmRepository.insert(film);
            }
            else
            {
                return _filmRepository.update(film);
            }
        }
    }
}
