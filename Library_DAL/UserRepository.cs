using Library_DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Library_DAL
{
    public class UserRepository
    {
        private readonly LibraryContext _context;

        public UserRepository()
        {
            _context = new LibraryContext();
        }

        public void Add(User user)
        {
            if (_context.Users.FirstOrDefault() == null)
                user.UserId = 1;
            else user.UserId = _context.Users.OrderByDescending(x => x.UserId).First().UserId + 1; 
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void Update(User user)
        {
            _context.Entry(user).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Remove(int UserId)
        {
            var user = _context.Users.Find(UserId);
            if (user != null)
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
            }
        }

        public User GetById(int UserId)
        {
            return _context.Users.Find(UserId);
        }

        public bool CheckExist(User user)
        {
            return _context.Users.Any(u => u.Username == user.Username);
        }

        public int Count()
        {
            return _context.Users.Count();
        }

        public List<User> GetAll()
        {
            return _context.Users.ToList();
        }
    }
}