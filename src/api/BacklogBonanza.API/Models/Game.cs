using System;

namespace BacklogBonanza.API.Models
{
    public class Game
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public bool IsFinished { get; set; }

        public string Platform { get; set; }
    }
}
