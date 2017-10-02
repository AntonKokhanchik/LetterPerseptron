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
        Dictionary<char, string> dictionary;
        public Form1()
        {
            InitializeComponent();
            FillDictionary();
        }

        private void FillDictionary()
        {
            dictionary.Add('а', "010010111101");
            dictionary.Add('б', "111100111111");
            dictionary.Add('в', "111111101111");
            dictionary.Add('г', "111100100100");
            dictionary.Add('д', "000010111101");
            dictionary.Add('е', "000111110111");
            dictionary.Add('ё', "101111110111");
            dictionary.Add('ж', "111111111101");
            dictionary.Add('з', "111011001111");
            dictionary.Add('и', "101101111101");
            dictionary.Add('й', "111101111101");
            dictionary.Add('к', "101110110101");
            dictionary.Add('л', "010010101101");
            dictionary.Add('м', "101111111101");
            dictionary.Add('н', "101111101101");
            dictionary.Add('о', "111101101111");
            dictionary.Add('п', "111101101101");
            dictionary.Add('р', "111101111100");
            dictionary.Add('с', "111100100111");
            dictionary.Add('т', "111010010010");
            dictionary.Add('у', "101111001111");
            dictionary.Add('ф', "111111010010");
            dictionary.Add('х', "000101010101");
            dictionary.Add('ц', "101101111001");
            dictionary.Add('ч', "101111001001");
            dictionary.Add('ш', "101111111000");
            dictionary.Add('щ', "101111111001");
            dictionary.Add('ъ', "110010011011");
            dictionary.Add('ы', "101101111111");
            dictionary.Add('ь', "100100110110");
            dictionary.Add('э', "111001111111");
            dictionary.Add('ю', "000111111111");
            dictionary.Add('я', "111111011011");
        }
    }
}
