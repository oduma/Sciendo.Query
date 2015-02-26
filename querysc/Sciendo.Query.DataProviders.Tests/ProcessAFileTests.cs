using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sciendo.Query.DataProviders.Tests
{
    [TestFixture]
    public class ProcessAFileTests
    {
        [Test]
        public void ProcessNoProcessor()
        {
            ClementinePlayerProcess processor = new ClementinePlayerProcess();
            Assert.False(processor.AddSongToQueue("abc.mp3","clement.exe"));
        }
        [Test]
        public void ProcessFileDoesNotExist()
        {
            ClementinePlayerProcess processor = new ClementinePlayerProcess();
            Assert.True(processor.AddSongToQueue("abc.mp3", "clementine"));
        }
        [Test]
        public void ProcessOk()
        {
            ClementinePlayerProcess processor = new ClementinePlayerProcess();
            Assert.True(processor.AddSongToQueue(@"file:///C:\Users\octo\Music\0-9\2K\---K The Millennium\01 -  (radio edit).mp3", "clementine"));
        }
    }
}
