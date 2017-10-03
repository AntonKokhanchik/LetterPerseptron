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
        private Dictionary<int, char> dictionary;

        private Neuron[] neuron;

        public int Generation { get; private set; }

        Perseptron()
        {
            neuron = new Neuron[m];
            FillDictionary();
            Generation = 0;
        }

        private void FillDictionary()
        {
            dictionary = new Dictionary<int, char>();
            dictionary.Add(0, 'а');
            dictionary.Add(1, 'б');
            dictionary.Add(2, 'в');
            dictionary.Add(3, 'г');
            dictionary.Add(4, 'д');
            dictionary.Add(5, 'у');
            dictionary.Add(6, 'е');
            dictionary.Add(7, 'ё');
            dictionary.Add(8, 'ж');
            dictionary.Add(9, 'з');
            dictionary.Add(10, 'и');
            dictionary.Add(11, 'й');
            dictionary.Add(12, 'к');
            dictionary.Add(13, 'л');
            dictionary.Add(14, 'м');
            dictionary.Add(15, 'н');
            dictionary.Add(16, 'о');
            dictionary.Add(17, 'п');
            dictionary.Add(18, 'р');
            dictionary.Add(19, 'с');
            dictionary.Add(20, 'т');
            dictionary.Add(21, 'у');
            dictionary.Add(22, 'ф');
            dictionary.Add(23, 'х');
            dictionary.Add(24, 'ц');
            dictionary.Add(26, 'ч');
            dictionary.Add(25, 'ш');
            dictionary.Add(26, 'щ');
            dictionary.Add(27, 'ъ');
            dictionary.Add(28, 'ы');
            dictionary.Add(29, 'ь');
            dictionary.Add(30, 'э');
            dictionary.Add(30, 'ю');
            dictionary.Add(31, 'я');
        }

        public string React(string picture)
        {
            string answer = "";

            for (int i = 0; i < m; i++)
                if (neuron[i].React(picture))
                    answer += dictionary[i];
            if (answer == "")
                answer = "0";

            return answer;
        }


    }
}
