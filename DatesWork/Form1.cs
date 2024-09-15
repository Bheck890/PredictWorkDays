using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatesWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> NewDate = new List<string>();
        List<string> CountDates = new List<string>();
        DateTime Begin;
        DateTime PayDay;

        int CurrMonth;
        int CountMonth;

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set the Multiline property to true.
            textBox1.Multiline = true;
            // Add vertical scroll bars to the TextBox control.
            textBox1.ScrollBars = ScrollBars.Vertical;
            // Allow the TAB key to be entered in the TextBox control.
            textBox1.AcceptsReturn = true;
            // Allow the TAB key to be entered in the TextBox control.
            textBox1.AcceptsTab = true;
            // Set WordWrap to true to allow text to wrap to the next line.
            textBox1.WordWrap = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";

            //Calculate the Next Weeks
            DateTime Start = dateTimePickerBegin.Value;

            Begin = Start;

            Console.WriteLine($"Start: {Start.Month}-{Start.Day}-{Start.Year}");

            CurrMonth = Begin.Month;

            while (Begin.Year <= Start.Year)
            {
                if (PayDay.Month == CurrMonth)
                {
                    CountMonth++;
                }
                else
                {
                    if (checkBox1.Checked && CountMonth == 3)
                        CountDates.Add($"3 Paydays for Month: {CurrMonth}");

                    CurrMonth = PayDay.Month;
                    CountMonth = 1;
                }

                NewDate.Add(NextWeek());
            }

            //Extra 3
            //for (int i = 0; i < 3; i++)
            //{
            //    NewDate.Add(NextWeek());

            //}

            foreach (var item in NewDate)
            {
                textBox1.Text += item + "\r\n";
            }
            foreach (var item in CountDates)
            {
                textBox1.Text += item + "\r\n";
            }

            textBox1.Text += $"Work Weeks: {NewDate.Count}" + "\r\n";

            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.ScrollToCaret();

            NewDate.Clear();
            CountDates.Clear();
        }

        string NextWeek()
        {
            DateTime EndDay = Begin.AddDays((int)numericUpDownWorkWeek.Value);//13

            PayDay = EndDay.AddDays((int)numericUpDownPay.Value); //4

            string outDays = $"{Begin.Month}/{Begin.Day}-{EndDay.Month}/{EndDay.Day} R:{PayDay.Month}/{PayDay.Day} ";

            Begin = EndDay.AddDays(1);
            Console.WriteLine(outDays);

            return outDays;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
