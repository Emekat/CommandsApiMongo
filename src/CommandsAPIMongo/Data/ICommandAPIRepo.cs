using System.Collections.Generic;
using CommandsAPIMongo.Models;
using MongoDB.Bson;

namespace CommandsAPIMongo.Data
{
    public interface ICommandAPIRepo
    {
        bool SaveChanges();
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(string id);
        void CreateCommand(Command cmd);
        void UpdateCommand(ObjectId objectId, Command cmd);
        void DeleteCommand(Command cmd);
    }
}
