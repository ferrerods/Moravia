using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ChessProject.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) {

        }

        public DbSet<Piece> Piece { get; set; }
        public DbSet<Square> Square { get; set; }
        public DbSet<Board> Board { get; set; }
        public DbSet<Game> Game { get; set; }
    }


}
