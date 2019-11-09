using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace RegexValidacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void ValidacionVocalNumero()
        {
            Regex regexVocalNumero = new Regex(@"[aeiou]\d" /*decimal*/);
            
            //match
            Match resultMatch = regexVocalNumero.Match(textBox1.Text);
            checkBox1.Checked = resultMatch.Success;
            
            //matches
            listBox1.Items.Clear();
            MatchCollection resultadosMatches = regexVocalNumero.Matches(textBox1.Text);
            foreach (Match match in resultadosMatches)
            {
                listBox1.Items.Add(match.ToString());
            }
            
            //textboxs de props
            valueTxt.Text = "valor match: " + resultMatch.Value;
            LenghtTxt.Text = "largo match: " + resultMatch.Length.ToString();
            textBox3.Text = "match en letra numero: " + resultMatch.Index.ToString();
            //count Matches
            countTxt.Text = "cantidad de matches: " + resultadosMatches.Count.ToString();
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ValidacionVocalNumero();
            ValidacionNoVocal();
            validacionCantidadNumeros();
            ValidacionVocales();
            ValidacionNumero();
            // [asd] ? 0-1 solo 1 de a-s-d
            // [asd] + 1 o mas \d+ 
            // [asd] * 0 o mas

        }

        private void ValidacionNumero()
        {
            Regex ceroUno = new Regex(@"\d?");
            Regex unoMuchos = new Regex(@"\d+");
            Regex ceroMuchos = new Regex(@"\d*");

            checkBox5.Checked = ceroUno.Match(textBox1.Text).Success;
            checkBox6.Checked = unoMuchos.Match(textBox1.Text).Success;
            checkBox7.Checked = ceroMuchos.Match(textBox1.Text).Success;
        }

        private void ValidacionVocales()
        {
            Regex ceroUno = new Regex("[aeiou]?");
            Regex unoMuchos = new Regex("[aeiou]+");
            Regex ceroMuchos = new Regex("[aeiou]*");

            checkBox2.Checked = ceroUno.Match(textBox1.Text).Success;
            checkBox3.Checked = unoMuchos.Match(textBox1.Text).Success;
            checkBox4.Checked = ceroMuchos.Match(textBox1.Text).Success;
        }

        private void validacionCantidadNumeros()
        {
            Regex regexNoVocal = new Regex(@"\d{3}");
            listBox3.Items.Clear();
            MatchCollection resultadosMatches = regexNoVocal.Matches(textBox1.Text);
            foreach (Match match in resultadosMatches)
            {
                listBox3.Items.Add(match.ToString());
            }
            txtCountVeces.Text = "cantidad de matches: " + resultadosMatches.Count.ToString();
        }

        private void ValidacionNoVocal()
        {
            Regex regexNoVocal = new Regex("[^aeiou]");
            listBox2.Items.Clear();
            MatchCollection resultadosMatches = regexNoVocal.Matches(textBox1.Text);
            foreach (Match match in resultadosMatches)
            {
                listBox2.Items.Add(match.ToString());
            }
            countTxtNoVocal.Text = "cantidad de matches: " + resultadosMatches.Count.ToString();
        }
    }
}
