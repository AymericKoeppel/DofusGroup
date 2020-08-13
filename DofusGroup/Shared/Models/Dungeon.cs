using DofusGroup.Shared.FKModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DofusGroup.Shared.Models
{
    public class Dungeon
    {
        [Key]
        public int Id { get; set; }
        public string ImgSource { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Boss { get; set; }
        public string Position { get; set; }
        public string Niveau { get; set; }

        public ICollection<DungeonUser> DungeonUsers { get; set; }
    }
}
