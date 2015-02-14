using Sciendo.Query.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sciendo.Query.DataProviders
{
    public class MockPlayerProcess:IPlayerProcess
    {
        public bool AddSongToQueue(string filePath, string withProcess)
        {

            return true;
        }
    }
}
