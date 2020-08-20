using BacklogBonanza.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BacklogBonanza.API.Repositories
{
    class GameRepository : IGameRepository
    {
        private readonly BacklogBonanzaDbContext _context;

        public GameRepository(BacklogBonanzaDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public Game Create(Game obj)
        {
            try
            {
                _context.Games.Add(obj);
                _context.SaveChanges();

                return Get(obj.Id.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }

        }

        public void Delete(string id)
        {
            try
            {
                var entity = _context.Games.Find(id);
                _context.Games.Remove(entity);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        public IEnumerable<Game> Get()
        {
            try
            {
                return _context.Games.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        public Game Get(string id)
        {
            try
            {
                return _context.Games.Find(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        public Game Update(string id, Game obj)
        {
            try
            {
                var entity = _context.Games.Find(id);

                entity.IsFinished = obj.IsFinished;
                entity.Platform = obj.Platform;
                entity.Name = obj.Name;

                _context.Games.Update(entity);
                _context.SaveChanges();
                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
    }
}