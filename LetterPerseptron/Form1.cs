using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetterPerseptron
{
    public partial class Form1 : Form
    {
        Dictionary<char, string> pictureDictionary;
		Dictionary<int, char> numberDictionary;
		Perseptron perseptron;

		public Form1()
        {
            InitializeComponent();
            FillDictionaries();
			perseptron = new Perseptron();
			AutoLearn();
			labelGenerations.Text = perseptron.Generation.ToString();
        }

        private void FillDictionaries()
        {
			pictureDictionary = new Dictionary<char, string>();
            pictureDictionary.Add('а', "010010111101");
            pictureDictionary.Add('б', "111100111111");
            pictureDictionary.Add('в', "111111101111");
            pictureDictionary.Add('г', "111100100100");
            pictureDictionary.Add('д', "000010111101");
            pictureDictionary.Add('е', "000111110111");
            pictureDictionary.Add('ё', "101111110111");
            pictureDictionary.Add('ж', "111111111101");
            pictureDictionary.Add('з', "111011001111");
            pictureDictionary.Add('и', "101101111101");
            pictureDictionary.Add('й', "111101111101");
            pictureDictionary.Add('к', "101110110101");
            pictureDictionary.Add('л', "010010101101");
            pictureDictionary.Add('м', "101111111101");
            pictureDictionary.Add('н', "101111101101");
            pictureDictionary.Add('о', "111101101111");
            pictureDictionary.Add('п', "111101101101");
            pictureDictionary.Add('р', "111101111100");
            pictureDictionary.Add('с', "111100100111");
            pictureDictionary.Add('т', "111010010010");
            pictureDictionary.Add('у', "101111001111");
            pictureDictionary.Add('ф', "111111010010");
            pictureDictionary.Add('х', "000101010101");
            pictureDictionary.Add('ц', "101101111001");
            pictureDictionary.Add('ч', "101111001001");
            pictureDictionary.Add('ш', "101111111000");
            pictureDictionary.Add('щ', "101111111001");
            pictureDictionary.Add('ъ', "110010011011");
            pictureDictionary.Add('ы', "101101111111");
            pictureDictionary.Add('ь', "100100110110");
            pictureDictionary.Add('э', "111001111111");
            pictureDictionary.Add('ю', "000111111111");
            pictureDictionary.Add('я', "111111011011");

			numberDictionary = new Dictionary<int, char>();
			numberDictionary.Add(0, 'а');
			numberDictionary.Add(1, 'б');
			numberDictionary.Add(2, 'в');
			numberDictionary.Add(3, 'г');
			numberDictionary.Add(4, 'д');
			numberDictionary.Add(5, 'е');
			numberDictionary.Add(6, 'ё');
			numberDictionary.Add(7, 'ж');
			numberDictionary.Add(8, 'з');
			numberDictionary.Add(9, 'и');
			numberDictionary.Add(10, 'й');
			numberDictionary.Add(11, 'к');
			numberDictionary.Add(12, 'л');
			numberDictionary.Add(13, 'м');
			numberDictionary.Add(14, 'н');
			numberDictionary.Add(15, 'о');
			numberDictionary.Add(16, 'п');
			numberDictionary.Add(17, 'р');
			numberDictionary.Add(18, 'с');
			numberDictionary.Add(19, 'т');
			numberDictionary.Add(20, 'у');
			numberDictionary.Add(21, 'ф');
			numberDictionary.Add(22, 'х');
			numberDictionary.Add(23, 'ц');
			numberDictionary.Add(24, 'ч');
			numberDictionary.Add(25, 'ш');
			numberDictionary.Add(26, 'щ');
			numberDictionary.Add(27, 'ъ');
			numberDictionary.Add(28, 'ы');
			numberDictionary.Add(29, 'ь');
			numberDictionary.Add(30, 'э');
			numberDictionary.Add(31, 'ю');
			numberDictionary.Add(32, 'я');
		}

		private void buttonTransform_Click(object sender, EventArgs e)
		{

			textBoxPicture.Text = pictureDictionary[Char.Parse(textBoxLetter.Text)];
		}

		private void buttonAnswer_Click(object sender, EventArgs e)
		{
			string s = textBoxPicture.Text;
			string picture = "";

			for (int i = 0; i < s.Length; i++)
			{
				if (s[i] == '0')
					picture += '0';
				else if (Char.IsDigit(s[i]))
					picture += '1';
			}

			int[] perseptrpnAnswer = perseptron.React(picture);
			string answer = "";

			for (int i = 0; i < perseptrpnAnswer.Length; i++)
				if (perseptrpnAnswer[i] == 1)
					answer += numberDictionary[i];
			if (answer == "")
				answer = "Нет совпадений";

			labelAnswer.Text = answer;
		}

		private void AutoLearn()
		{
			bool flag = false;
			while(!flag)
			{
				flag = true;
				for (int i = 0; i < numberDictionary.Count; i++)
				{
					int[] answer = perseptron.React(pictureDictionary[numberDictionary[i]]);
					int[] mistakes = new int[numberDictionary.Count];
					for (int j = 0; j < numberDictionary.Count; j++)
						if (i == j)
							mistakes[j] = 1 - answer[j];
						else
							mistakes[j] = 0 - answer[j];

					if (mistakes.Contains(1) || mistakes.Contains(-1))
					{
						perseptron.Learn(pictureDictionary[numberDictionary[i]], mistakes);
						flag = false;
					}			
				}
			}
		}


	}
}
