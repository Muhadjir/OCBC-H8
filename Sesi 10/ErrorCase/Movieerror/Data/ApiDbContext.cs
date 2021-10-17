using MySql.Data.MySqlClient;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Movie.Models;

namespace Movie.Data
{
    // public class ApiDbContext : DbContext
    // {
    public class ApiDbContext
    {
        // public virtual DbSet<MovieData> Movies {get;set;}
        // public ApiDbContext(DbContextOptions<ApiDbContext> options) 
        //     : base(options)
        // {

        // }

        public string ConnectionString { get; set; }
        public ApiDbContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public List<MovieData> GetAllMovie())
        {
            List<MovieData> list = new List<MovieData>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from tb_movie", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        list.Add(new MovieData()
                        {
                            Id = reader.GetInt32("Id"),
                            Name = reader.GetString("Name"),
                            Genre = reader.GetString("Genre"),
                            Duration = reader.GetString("Duration")
                            // ReleaseDate = reader.Get("alamat")
                        });
                    }
                }
                
            }
            return list;
        }

        public List<MovieData> GetMovie(string id)
        {
            List<MovieData> list = new List<MovieData>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from tb_movie where Id = @id", conn);
                cmd.Parameters.AddWithValue("@id", Id);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new MovieData()
                        {
                            Id = reader.GetInt32("Id"),
                            Name = reader.GetString("Name"),
                            Genre = reader.GetString("Genre"),
                            Duration = reader.GetString("Duration")
                            // ReleaseDate = reader.Get("alamat")
                        });
                    }
                }

            }
            return list;
        }
        
    }
}