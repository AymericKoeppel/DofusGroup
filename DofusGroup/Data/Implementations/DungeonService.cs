using DofusGroup.Data.DB;
using DofusGroup.Shared.FKModels;
using DofusGroup.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DofusGroup.Data.Implementations
{
    public class DungeonService
    {
        private DofusContext _context;

        public DungeonService(DofusContext context)
        {
            _context = context;
        }

        public async Task<List<Dungeon>> GetAllDungeons()
        {
            return Dungeons().ToList();
        }

        public async Task<Dungeon> GetDungeonById(int id)
        {
            return Dungeons().Single(x => x.Id == id);

        }

        private IQueryable<Dungeon> Dungeons()
        {
            return _context.Dungeons
                .Include(d => d.DungeonUsers)
                .ThenInclude(du => du.User)
                .ThenInclude(u => u.Class);
        }
    }


    /*
     *             using (var reader = new StreamReader(@"D:\Sources\DofusGroup\data\donjons2.csv"))
            {
                List<string> listA = new List<string>();
                List<string> listB = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    var dungeon = new Dungeon
                    {
                        Id = int.Parse(values[0])+1,
                        ImgSource = values[1],
                        Name = values[2],
                        Boss = values[3],
                        Position = values[4],
                        Niveau = values[5]
                    };
                    _context.Add(dungeon);
                }
            }
            _context.SaveChanges();
     */
}
