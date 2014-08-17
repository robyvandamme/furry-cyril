using Domain.Interfaces.Commands;
using Domain.Model;

namespace Domain.Commands
{
    class CyrilCommands : ICyrilCommands
    {
        public ICommandResult ActivateOption(CyrilOption cyrilOption)
        {
            return new CommandResult();
        }
    }
}