using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using com.inosat.redisparser;

namespace TestRedisParser
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string filename = "../../resources/out.txt";
            using (StreamReader reader = File.OpenText(filename))
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    RedisMonitorLine rl = RedisParser.Parse(line);
                    line = reader.ReadLine();
                }
            }
        }
    }
}
