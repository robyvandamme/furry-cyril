using System.Runtime;
using Domain.Model;

namespace Domain.Interfaces.Commands
{
    public interface ICyrilCommands
    {
        ICommandResult ActivateOption(CyrilOption cyrilOption);
    }
}