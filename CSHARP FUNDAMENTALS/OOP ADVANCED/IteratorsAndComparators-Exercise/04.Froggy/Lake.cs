using System.Collections;
using System.Collections.Generic;

namespace _04.Froggy
{
    public class Lake : IEnumerable<int>
    {
        private List<int> stones;

        public List<int> Stones
        {
            get => this.stones;
        }

        public Lake(List<int> input)
        {
            this.stones = new List<int>(input);
        }
        
        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < this.stones.Count; i += 2)
            {
                yield return this.stones[i];
            }

            var index = stones.Count - 2;

            if (stones.Count % 2 == 0)
            {
                index = stones.Count - 1;
            }

            for (int i = index; i > 0; i -= 2)
            {
                yield return stones[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
