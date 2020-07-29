using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChessProject.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PlayerWhite { get; set; }
        public string PlayerBlack { get; set; }
        public DateTime BeginPlay { get; set; }

        public int BoardId { get; set; }
        public Board Board { get; set; }
    }
}
