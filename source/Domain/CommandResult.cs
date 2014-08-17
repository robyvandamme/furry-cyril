namespace Domain
{
    class CommandResult : ICommandResult
    { 
        public CommandStatus Status { get; set; }
        public string Info { get; set; }
    }
}