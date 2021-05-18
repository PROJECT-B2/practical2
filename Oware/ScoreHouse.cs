/* This is an almost-complete translation of https://github.com/haarismemon/oware/ from Java to C#
*/
using System.Collections.Generic;

namespace Oware {
   /* public interface IScoreHouse
    {
         public ScoreHouse() ;
        
        public int GetCount();

        public void AddSeed(Seed seed);

        public void Reset();
    }*/
    public class ScoreHouse{
        private List<Seed> seedsInHouse;
        public ScoreHouse() {
            seedsInHouse = new List<Seed>();
        }
        
        public int GetCount() {
            return seedsInHouse.Count;
        }

        public void AddSeed(Seed seed) {
            seedsInHouse.Add(seed);
        }

        public void Reset() {
            seedsInHouse.Clear();
        }
    }
}