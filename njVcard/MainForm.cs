using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace njVcard
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] phones = teltextBox.Lines;
            string[] fnames = nametextBox.Lines;
            string[] lnames = lastnametextBox.Lines;
            tovcard(fnames, phones, lnames, consttextBox.Text );

        }
        private void tovcard(string[] firstnames, string[] phones, string[] lastnames, string constvalue )
        {
            StringBuilder str = new StringBuilder();

            string exvcard = @"BEGIN:VCARD
VERSION:2.1
N;CHARSET=UTF-8;ENCODING=QUOTED-PRINTABLE:;NJTITLE;;;
FN;CHARSET=UTF-8;ENCODING=QUOTED-PRINTABLE:NJTITLE
TEL;CELL:NJPHONE
END:VCARD";

            for (int i = 0; i < phones.Length; i++)
            {
                phones[i] = phones[i].Trim();

                string fname = "";
                string lname = "";

                if (i < firstnames.Count())
                    fname = firstnames[i].Replace(" ", "");

                if (i < lastnames.Count())
                    lname = lastnames[i].Replace(" ", "");

                if (string.IsNullOrWhiteSpace(fname) && string.IsNullOrWhiteSpace(lname)
                    && string.IsNullOrWhiteSpace(phones[i]))
                    continue;
                if (string.IsNullOrWhiteSpace(fname) &&
                    string.IsNullOrWhiteSpace(lname))
                    fname = phones[i];

                string xtitle =(string.IsNullOrWhiteSpace(constvalue) ?"": constvalue + " ") + fname + " " + lname;
                //if (!utf8)
                //    xtitle = tofen(xtitle);

                xtitle = Uri.EscapeUriString(xtitle).Replace("%","="); 
                
                string njtitle = exvcard.Replace("NJTITLE", xtitle);
                njtitle = njtitle.Replace("NJPHONE", phones[i]);
                str.Append(njtitle);
                str.AppendLine();
            }
            saveFileDialog1.Filter = "فایل شماره تماسها|*.vcf";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                /*if (utf8)
                    using (StreamWriter sw = new StreamWriter(File.Open(saveFileDialog1.FileName, FileMode.Create),
                        Encoding.UTF8))
                    {
                        sw.WriteLine(str.ToString());
                    }
                else*/
                    using (StreamWriter sw = new StreamWriter(File.Open(saveFileDialog1.FileName, FileMode.Create),
                    Encoding.ASCII))
                    {
                        sw.WriteLine(str.ToString());
                    }
            }
        }
        /*
        private string  tofen(string v)
        {
            Dictionary<char,string> x= new Dictionary<char, string>(  );
            x.Add('ا', "a");
            x.Add('ب', "b");
            x.Add('پ', "p");
            x.Add('ت', "t");
            x.Add('ط', "t");
            x.Add('ث', "s");
            x.Add('س', "s");
            x.Add('ص', "s");
            x.Add('ج', "j");
            x.Add('چ', "ch");
            x.Add('ه', "h");
            x.Add('ح', "h");
            x.Add('خ', "kh");
            x.Add('د', "d");
            x.Add('ظ', "z");
            x.Add('ض', "z");
            x.Add('ز', "z");
            x.Add('ذ', "z");
            x.Add('ر', "r");
            x.Add('ژ', "zh");
            x.Add('ش', "sh");
            x.Add('ع', "ai");
            x.Add('غ', "gh");
            x.Add('ف', "f");
            x.Add('ق', "gh");
            x.Add('ک', "k");
            x.Add('گ', "g");
            x.Add('ل', "l");
            x.Add('م', "m");
            x.Add('ن', "n");
            x.Add('و', "v");
            x.Add('ی', "i");

            string y = "";

            for (int i = 0; i < v.Length; i++)
                if (x.ContainsKey(v[i]))
                    y = y + x[v[i]];
                else
                    y = y + v[i];

            return y;
        }
        */
        private void button2_Click(object sender, EventArgs e)
        {
            nametextBox.Text = "";
            lastnametextBox.Text = "";
            teltextBox.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void consttextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
