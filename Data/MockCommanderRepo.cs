using Commander.Models;
using System.Collections.Generic;


namespace Commander.Data
{
    public class MockCommderRepo : ICommanderRepo
    {
        public void CreateCommnad(Command cmd)
        {
            throw new NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>{
                new Command{Id=0, HowTo="Boil an fish", Line="Boil Water", Platform="Kattie and Pan"},
                new Command{Id=1, HowTo="Boil an Yam", Line="Set fire", Platform="Steph and Dan"},
                new Command{Id=2, HowTo="Boil coffee", Line="Add coffee", Platform="Kay and Ken"}
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=0, HowTo="Boil an egg", Line="Boil Water", Platform="Kattie and Pan"};
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }
    }
}