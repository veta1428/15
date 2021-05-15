using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace fifteensWinForm
{
    class MemoryManager
    {
        private string filename;
        private List<GameResult> results = new List<GameResult>();

        public MemoryManager(string filename)
        {
            this.filename = filename;
        }

        public void Load()
        {
            results.Clear();
            if (!File.Exists(filename))
            {
                return;
            }
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                results = (List<GameResult>)formatter.Deserialize(fs);                
            }           
        }

        public IEnumerable<GameResult> GetTopTime(int count = 10)
        {
            return results.OrderBy(r => r.GameTime).Take(count);
        }

        public IEnumerable<GameResult> GetTopSteps(int count = 10)
        {
            return results.OrderBy(r => r.Steps).Take(count);
        }

        public IEnumerable<GameResult> GetLast(int count = 10)
        {
            return results.OrderByDescending(r => r.StartTime).Take(count);
        }

        public void Delete(DateTime dateTime)
        {
            for (int i = results.Count; i >= 1; i--)
            {
                if (results[i - 1].StartTime >= dateTime)
                {
                    results.RemoveAt(i - 1);
                }
            }
        }

        public void Add(GameResult gameResult)
        {
            results.Add(gameResult);
        }

        public void Save()
        {
            using (FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, results);
            }
        }
    }
}
