using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>{
                new Command{Id=0,HowTo="Boil an Egg",Line="Boil Water",Platform="Kettle & Pan"},
                new Command{Id=1,HowTo="cut Bread",Line="Get a Knife",Platform="Knife and chopping board"},
                new Command{Id=2,HowTo="make a cup of tea",Line="Place teabag in cup",Platform="Kettle & cup"},
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Boil an Egg", Line = "Boil Water", Platform = "Kettle & Pan" };
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}