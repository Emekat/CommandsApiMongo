using System;
using System.Collections.Generic;
using System.Linq;
using CommandsAPIMongo.Models;
using MongoDB.Bson;
using MongoDB.Driver;

namespace CommandsAPIMongo.Data
{
    public class CommandAPIRepo : ICommandAPIRepo
    {
        private readonly IMongoCollection<Command> _commands;
        public CommandAPIRepo(IMongoClient client)
        {
             var database = client.GetDatabase("CmdAPIMain");
            var collection = database.GetCollection<Command>("Commands");

            _commands = collection;
        }
        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }
        public IEnumerable<Command> GetAllCommands()
        {
             var commands = _commands.Find(_ => true).ToList();
             return commands;
        }

        public Command GetCommandById(string id)
        {
            var commands = _commands.Find(emp => emp.Id == id).FirstOrDefault();
            return commands;
        }

        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(ObjectId objectId, Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}