using System.Windows.Input;
using Commander.Models;

namespace Commander.Data
{
    public class SqlCommanderRepo : ICommanderRepo
    {
        private readonly CommanderContext _context;

        public SqlCommanderRepo(CommanderContext context)
        {
            _context = context;
        }

        public void CreateCommnad(Command cmd)
        {
            if(cmd== null){
                throw new ArgumentNullException(nameof(cmd));
            }
            _context.Commands.Add(cmd);

        }

        public void DeleteCommand(Command cmd)
        {
           if(cmd== null){
                throw new ArgumentNullException(nameof(cmd));
            }
            _context.Commands.Remove(cmd);

        }

        public IEnumerable<Command> GetAllCommands()
        {
            return _context.Commands.ToList();
        }

        public Command GetCommandById(int id)
        {
            return _context.Commands.FirstOrDefault(p => p.Id ==id);
        }

        public bool SaveChanges()
        {
           return _context.SaveChanges() >=0; //you should put () around wen you have issues
        }

        public void UpdateCommand(Command cmd)
        {
            
        }
    }
}