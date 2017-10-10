using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterPerseptron
{
    class Neuron
    {
        private int n = 12;
        private int speed = 2; // 2, чувствительность меняется со скоростью, синапсы без скорости - лучший результат (385)

        public int Theta { get; private set; }
        private int[] w;

        public Neuron()
        {
            w = new int[n];
            Random r = new Random();

			for (int i = 0; i < n; i++)
				w[i] = r.Next(30);
				//w[i] = 10;
			Theta = r.Next(30);
			//Theta = -1;
        }

        public bool React(string picture)
        {
            int s = 0;

            for (int i = 0; i < n; i++)
                s += int.Parse(picture[i].ToString()) * w[i];

            if (s >= Theta)
                return true;
            else
                return false;
        }

        public void Learn(string picture, int mistake)
        {
            for (int i = 0; i < n; i++)
				w[i] += mistake * int.Parse(picture[i].ToString()) * speed;
				//w[i] += mistake * int.Parse(picture[i].ToString());
			Theta -= mistake * speed;
			//Theta -= mistake;
		}
    }
}
