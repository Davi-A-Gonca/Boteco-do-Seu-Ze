using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class Form1 : Form
    {
        List<NumericUpDown> Cells = new List<NumericUpDown>();

        List<decimal> OrganizedValues = new List<decimal>();
        List<decimal> RandomizedValues = new List<decimal>();

        public Form1()
        {
            InitializeComponent();

            FillCellsList();
            FillPossibleValues();
            AddValues();
        }

        private void FillPossibleValues()
        {
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    OrganizedValues.Add(i);
                }
            }

            RandomizeList(OrganizedValues);

            ApplyRules();
        }

        private void RandomizeList(List<decimal> organizedList)
        {
            RandomizedValues = organizedList;
            Random rng = new Random();

            for (int inc = RandomizedValues.Count-1; inc > 0; inc--)
            {
                int newIndex = rng.Next(81);

                decimal aux = RandomizedValues[inc];
                RandomizedValues[inc] = RandomizedValues[newIndex];
                RandomizedValues[newIndex] = aux;
            }
        }

        private void ApplyRules()
        {
            Random rng = new Random();
            int newIndex = 0;

            for (int i = 0; i < Cells.Count; i++)
            {
                String line = "";
                for (int j = (i - (i % 9)); j < (i - (i % 9)) + 9; j++)
                {
                    decimal aux = RandomizedValues[j];
                    newIndex = rng.Next(80 - j) + j;

                    if (line.Contains($"{aux}"))
                    {
                        aux = RandomizedValues[newIndex];

                    }
                    else
                    {
                        line += aux;
                    }
                }
            }

            for ()
            {

            }
        }

        private void FillCellsList()
        {
            int auxX = 0;
            int auxY = 0;

            for (int i = 0; i < 81; i++)
            {
                if(auxX > 8)
                {
                    auxX = 0;
                    auxY++;
                }

                NumericUpDown nmrcUpDwn = new NumericUpDown();

                nmrcUpDwn.Size = new Size(40, 40);
                nmrcUpDwn.Location = new Point(50 * auxX, 50 * auxY);
                nmrcUpDwn.Value = 0;

                Cells.Add(nmrcUpDwn);

                auxX++;
            }
        }

        private void AddValues()
        {
            int index = 0;
            foreach (NumericUpDown n in Cells)
            {
                n.Value = RandomizedValues[index];                

                index++;

                pnl_Table.Controls.Add(n);
            }
        }

        private void bttn_Refresh_Click(object sender, EventArgs e)
        {
            
        }
    }
}
