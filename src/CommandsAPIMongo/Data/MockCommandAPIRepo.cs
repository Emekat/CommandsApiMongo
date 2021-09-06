using System.Collections.Generic;
using CommandsAPIMongo.Models;
using MongoDB.Bson;

namespace CommandsAPIMongo.Data
{
    public class MockCommandAPIRepo : ICommandAPIRepo
    {
        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command{
                     HowTo="How to generate a migration",
                    CommandLine="dotnet ef migrations add <Name of Migration>",
                    Platform=".Net Core EF"},
                new Command{
                     HowTo="Run Migrations",
                    CommandLine="dotnet ef database update",
                    Platform=".Net Core EF"},
                new Command{
                    HowTo="List active migrations",
                    CommandLine="dotnet ef migrations list",
                    Platform=".Net Core EF"}
            };
            return commands;
        }

        public Command GetCommandById(string id)
        {
            return new Command
            {
              
                HowTo = "How to generate a migration",
                CommandLine = "dotnet ef migrations add <Name of Migration>",
                Platform = ".Net Core EF"
            };
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