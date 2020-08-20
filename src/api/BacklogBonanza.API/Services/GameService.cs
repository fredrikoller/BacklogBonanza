using System;
using System.Collections.Generic;
using BacklogBonanza.API.Models;
using BacklogBonanza.API.Repositories;

namespace BacklogBonanza.API.Services
{
    class GameService : IGameService
    {
        private readonly IGameRepository _repository;

        public GameService(IGameRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public Game Create(Game obj)
        {
            try
            {
                _repository.Create(obj);
                return obj;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Game> Get()
        {
            return _repository.Get();
        }

        public Game Get(string id)
        {
            throw new NotImplementedException();
        }

        public Game Update(string id, Game obj)
        {
            throw new NotImplementedException();
        }
    }

}