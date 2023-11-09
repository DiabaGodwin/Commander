using System.Collections.Generic;
namespace Commander.Models

{
    public interface ICommanderRepo
    {
        bool SaveChanges();
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
        void CreateCommnad(Command cmd);
        void UpdateCommand(Command cmd);
        void DeleteCommand(Command cmd);

    }
}