using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace fifteensWinForm
{
    [Serializable]
    class GameResult
    {
        public DateTime GameTime {get; set;}
        public DateTime StartTime { get; set; }
        public string Player { get; set; }
        public int Steps { get; set; }
        public GameResult(int steps, DateTime gameTime, DateTime startTime, string name = "Unknown")
        {
            Steps = steps;
            Player = name;
            StartTime = startTime;
            GameTime = gameTime;
        }
        public override string ToString()
        {
            return $"Player: {Player}\nTime: {GameTime}\nStart time: {StartTime}\nSteps: {Steps}";
        }


    }
}
