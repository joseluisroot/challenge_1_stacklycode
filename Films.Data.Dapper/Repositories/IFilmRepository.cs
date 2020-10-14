using Films.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Films.Data.Dapper.Repositories
{
    public interface IFilmRepository
    {
        Task<IEnumerable<Film>> getAllFilms();
        Task<Film> getFilm(int id);
        Task<bool> insert(Film film);
        Task<bool> update(Film film);
        Task<bool> delete(int id);

    }
}
