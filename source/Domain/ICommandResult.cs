namespace Domain
{
    public interface ICommandResult
    {
        CommandStatus Status { get; set; }
        string Info { get; set; }
    }
}