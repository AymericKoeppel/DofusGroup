using DofusGroup.Data.DB;
using DofusGroup.Shared.FKModels;
using DofusGroup.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace DofusGroup.Data.Implementations
{
    public class UserService
    {
        private DofusContext _context;

        public UserService(DofusContext context)
        {
            _context = context;
        }

        public async Task<User> GetUserById(int userId)
        {
            return _context.Users.Include(x => x.Class).Single(x => x.Id == userId);
        }

        public bool AddUserToDungeon(int userId, int dungeonId) 
        {
            var dungeonUser = new DungeonUser { UserId = userId, DungeonId = dungeonId };
            _context.DungeonUsers.Add(dungeonUser);
            _context.SaveChanges();
            return true;
        }

        public bool RemoveUserFromDungeon(int userId, int dungeonId)
        {
            var dungeonUser = _context.DungeonUsers.Single(x => x.UserId == userId && x.DungeonId == dungeonId);
            _context.DungeonUsers.Remove(dungeonUser);
            _context.SaveChanges();
            return true;
        }

        public User CreateUser(User user)
        {
            var usr = _context.Users.Add(user);
            _context.SaveChanges();
            return usr.Entity;
        }

    }
}
