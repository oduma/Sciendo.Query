namespace Sciendo.Query.Contracts
{
    public interface IPlayerProcess
    {
        bool AddSongToQueue(string filePath, string withProcess);
    }
}
