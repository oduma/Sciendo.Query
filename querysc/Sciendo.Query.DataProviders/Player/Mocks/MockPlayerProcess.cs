using Sciendo.Query.Contracts;

namespace Sciendo.Query.DataProviders.Player.Mocks
{
    public class MockPlayerProcess:IPlayerProcess
    {
        public bool AddSongToQueue(string filePath, string withProcess)
        {

            return true;
        }
    }
}
