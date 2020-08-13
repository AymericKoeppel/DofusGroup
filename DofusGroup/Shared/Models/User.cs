using DofusGroup.Shared.FKModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DofusGroup.Shared.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        public int ClassId { get; set; }

        [Required]
        public int Level { get; set; }

        public ICollection<DungeonUser> DungeonUsers { get; set; }
        public Class Class { get; set; }
    }
}
