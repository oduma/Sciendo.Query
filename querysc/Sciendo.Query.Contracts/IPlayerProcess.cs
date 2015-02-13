using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sciendo.Query.Contracts
{
    public interface IPlayerProcess
    {
        bool AddSongToQueue(string filePath);
    }
}
