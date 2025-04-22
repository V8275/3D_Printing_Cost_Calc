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

namespace _3DPrintCost
{
    public partial class Form1 : Form
    {
        private double mainLength, plasticCost, printLength, printTime, eEat, eCost, profit;

        public Form1()
        {
            InitializeComponent();
        }


        private void GetCostBtn_Click(object sender, EventArgs e)
        {
            double cost = 0;

            mainLength = SetValues(MainLength);
            plasticCost = SetValues(PlasticCost);
            printLength = SetValues(PrintLength);
            printTime = SetValues(PrintTime);
            eEat = SetValues(E_Eat);
            eCost = SetValues(E_Cost);
            profit = SetValues(Profit);

            cost = ((plasticCost / mainLength) * printLength) + (printTime * eEat * eCost) + profit;

            Result.Text = $"{cost}";
        }

        private double SetValues(TextBox input)
        {
            return double.Parse(input.Text);
        }

        private void TranslateBtn_Click(object sender, EventArgs e)
        {
            double eat = double.Parse(E_Eat.Text);
            eEat = eat / 1000;

            E_Eat.Text = eEat.ToString();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.Title = "Сохранить данные";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        writer.WriteLine($"Main Length: {mainLength}");
                        writer.WriteLine($"Plastic Cost: {plasticCost}");
                        writer.WriteLine($"E Eat: {eEat}");
                        writer.WriteLine($"E Cost: {eCost}");
                        writer.WriteLine($"Profit: {profit}");
                    }
                }
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.Title = "Загрузить данные";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                    {
                        mainLength = double.Parse(reader.ReadLine().Split(':')[1].Trim());
                        plasticCost = double.Parse(reader.ReadLine().Split(':')[1].Trim());
                        eEat = double.Parse(reader.ReadLine().Split(':')[1].Trim());
                        eCost = double.Parse(reader.ReadLine().Split(':')[1].Trim());
                        profit = double.Parse(reader.ReadLine().Split(':')[1].Trim());
                    }

                    MessageBox.Show($"Main Length: {mainLength}\nPlastic Cost: {plasticCost}\nE Eat: {eEat}\nE Cost: {eCost}\nProfit: {profit}");
                }
            }
        }

        private void KeyPressCondition(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            TextBox tb = sender as TextBox;

            if (e.KeyChar == ',' && tb.Text.Contains(","))
            {
                e.Handled = true;
            }
        }
    }

    class SaveData
    {
        public float ecost;
        public float plastCost;
        public float plastLen;
        public float profit;

        public SaveData(float e_cost, float plast_Cost, float plast_Len, float _profit)
        {
            ecost = e_cost;
            plastCost = plast_Cost;
            plastLen = plast_Len;
            profit = _profit;
        }
    }
}
