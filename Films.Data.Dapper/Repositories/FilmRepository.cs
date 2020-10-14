using Dapper;
using Films.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace Films.Data.Dapper.Repositories
{
    public class FilmRepository : IFilmRepository
    {
        private string _cnnString;

        public FilmRepository(string cnnString)
        {
            _cnnString = cnnString;
        }

        protected SqlConnection dbConnection()
        {
            return new SqlConnection(_cnnString);
        }

        public async Task<bool> delete(int id)
        {
            var db = dbConnection();

            var sql = @"DELETE FROM Films WHERE id = @id ";

            var result = await db.ExecuteAsync(sql.ToString(), new { Id = id });

            return result > 0;
        }

        public async Task<IEnumerable<Film>> getAllFilms()
        {

            var db = dbConnection();

            var sql = @"SELECT id, title, director, releaseDate FROM Films ";

            return await db.QueryAsync<Film>(sql.ToString(), new { });
        }

        public async Task<Film> getFilm(int id)
        {
            var db = dbConnection();

            var sql = @"SELECT id, title, director, releaseDate FROM Films WHERE id = @id";

            return await db.QueryFirstOrDefaultAsync<Film>(sql.ToString(), new { Id = id });
        }

        public async  Task<bool> insert(Film film)
        {
            var db = dbConnection();

            var sql = @"INSERT INTO Films (title, director, releaseDate) 
                                VALUES(@title, @director, @releaseDate)";

            var result = await db.ExecuteAsync(sql.ToString(), new { film.title, film.director, film.releaseDate });

            return result > 0;
        }

        public async Task<bool> update(Film film)
        {
            var db = dbConnection();

            var sql = @"UPDATE Films SET title=@title, director=@director, releaseDate=@releaseDate)                                 
                                WHERE id = @id";

            var result = await db.ExecuteAsync(sql.ToString(), new { film.title, film.director, film.releaseDate, film.id });

            return result > 0;
        }
    }
}
