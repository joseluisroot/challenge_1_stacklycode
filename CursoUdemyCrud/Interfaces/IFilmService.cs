using Films.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CursoUdemyCrud.Interfaces
{
    public interface IFilmService
    {

        Task<IEnumerable<Film>> getAllFilms();
        Task<Film> getDetails(int id);
        Task<bool> delete(int id);
        Task<bool> save(Film film);

    }
}
