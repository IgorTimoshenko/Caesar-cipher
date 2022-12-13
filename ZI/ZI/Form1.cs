using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void decrypt_Click(object sender, EventArgs e)
        {
            string[] bCrypt = Crypt.Text.Split(' ');
            int step = 1;
            StringBuilder code = new StringBuilder();
            foreach (string s in bCrypt)
            {
                
                string aAlph = Alph.Text;
                string aCrypt = s;
                for (int i = 0; i < aCrypt.Length; i++)
                    for (int j = 0; j < aAlph.Length; j++)
                        if (aCrypt[i] == aAlph[j])
                        {
                            code.Append(aAlph[(j - step + aAlph.Length) % aAlph.Length]);
                            
                        }
                code.Append(" ");
            }
            textBox1.Text = code.ToString();
        }
    }
}