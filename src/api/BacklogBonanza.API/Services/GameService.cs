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
            try
            {
                _repository.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        public IEnumerable<Game> Get()
        {
            return _repository.Get();
        }

        public Game Get(string id)
        {
            try
            {
                return _repository.Get(id);
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
                return _repository.Update(id, obj);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
    }

}