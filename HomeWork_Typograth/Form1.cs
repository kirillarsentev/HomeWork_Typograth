using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Typograth_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void buttonToDo_Click(object sender, EventArgs e)
        {
            TextBox.ReadOnly = false;
            TextBox.Text = space(TextBox.Text);
            TextBox.Text = maternoye_slovo(TextBox.Text);
            TextBox.Text = dots(TextBox.Text);
            TextBox.Text = plus_minus(TextBox.Text);
            TextBox.Text = defis(TextBox.Text);
            TextBox.Text = best_teachers(TextBox.Text);
            
        }
        public string space(string str)
        {
            str.Trim();
            string[] words = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            str = string.Join(" ", words);
            return str;
        }
        
        public string dots(string str)
        {
            str = str.Replace("...", "\u2026");
            return str;
        }
        public string best_teachers(string str)
        {
                    while(str.Contains("Дина Сергеевна"))
                    {
                        str = str.Replace("Дина Сергеевна", "Лучший препод");
                    }
        
            return str;

        }

        public string plus_minus(string str)
        {
            str = str.Replace("+-", "±");
            str = str.Replace("-+", "±");
            return str;
        }

        public string defis(string str)
        {
            str = str.Replace(" — ", "—");
            return str;
        }

        public string maternoye_slovo(string str)
        {
            string [] words = str.Split(' ');
            string[] word = new string[5] {"мат","сквернословие","брань","ругательство","ругань"};
            for(int i = 0; i < words.Length; i++)
            {
                for(int j = 0; j < word.Length; j++)
                {
                    if(words[i] == word[j])
                    {
                        str = str.Replace(word[j], "***");
                    }
                }
            }
            return str;
           
        }
    }
}