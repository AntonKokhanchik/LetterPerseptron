using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterPerseptron
{
    class Perseptron
    {
        private int m = 33;

        private Neuron[] neuron;

        public int Generation { get; private set; }

        public Perseptron()
        {
            neuron = new Neuron[m];
			for (int i = 0; i < m; i++)
				neuron[i] = new Neuron();
            Generation = 0;
        }

        public int[] React(string picture)
        {
            int[] answer = new int[m];

			for (int i = 0; i < m; i++)
				if (neuron[i].React(picture))
					answer[i] = 1;
				else
					answer[i] = 0;
            return answer;
        }

		public void Learn(string picture, int[] mistakes)
		{
			for (int i = 0; i < m; i++)
				neuron[i].Learn(picture, mistakes[i]);
			Generation++;
		}
    }
}
