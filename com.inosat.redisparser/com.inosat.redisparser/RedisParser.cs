
using System;

namespace com.inosat.redisparser
{
    public class RedisParser
    {
        public static RedisMonitorLine Parse(string line)
        {
            RedisMonitorLine rl = new RedisMonitorLine();
            int seconds = int.Parse(line.Substring(0, 10));
            int ticks = int.Parse(line.Substring(11, 6));
            rl.DateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(seconds);
            rl.DateTimeOffset.AddTicks(ticks);
            string endpoint = line.Substring(line.IndexOf('[') + 1, line.IndexOf(']') - line.IndexOf('[') - 1);
            rl.Db = int.Parse(endpoint.Split(' ')[0]);
            rl.EndPoint = endpoint.Split(' ')[1];
            return rl;
        }
    }
}