using DofusGroup.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DofusGroup.Shared.FKModels
{
    public class DungeonUser
    {
        public int DungeonId { get; set; }
        public Dungeon Dungeon { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

    }
}
