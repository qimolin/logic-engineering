using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace logic_engineering
{
    public partial class Form1 : Form
    {
        PropTree tree;
        public Form1()
        {
            InitializeComponent();
            panelFormulas.Hide();
            truthTable.Hide();
            truthTableSimplified.Hide();
        }
        private void btMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void linkLbLogoMakr_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo("https://logomakr.com") { UseShellExecute = true });
                //Process.Start("cmd", "/C start" + " " + "https://logomakr.com");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btCredits_Click(object sender, EventArgs e)
        {
            linkLbLogoMakr.Visible = !linkLbLogoMakr.Visible;
        }


        private void btParse_Click(object sender, EventArgs e)
        {
            try
            {
                lbPropError.Text = "";
                tree = new PropTree(tbProposition.Text);
                
                WriteTreeToFile(tree, "abc.dot");

                TruthTable truthTable = new TruthTable(tree);

                SetFormulas(tree, truthTable);
                List<char> uniqueVariables = tree.GetUniqueVariables();
                List<string[]> fullRows = truthTable.GetFullRows();
                SetDataGridView(fullRows, uniqueVariables, this.truthTable);
                List<string[]> simplifiedRows = truthTable.GetSimplifiedRows();
                SetDataGridView(simplifiedRows, uniqueVariables, this.truthTableSimplified);
            }
            catch(Exception ex)
            {
                lbPropError.ForeColor = Color.Red;
                lbPropError.Text = ex.Message;
            }
        }
        private void WriteTreeToFile(PropTree tree, string filename)
        {
            tree.WriteToFile("abc.dot");
            tree.GenerateImage();
            pbTree.ImageLocation = "abc.png";
        }
        private void SetDataGridView(List<string[]> rows, List<char> uniqueVariables, DataGridView dgv)
        {
            dgv.Rows.Clear();
            dgv.Refresh();

            dgv.ColumnCount = uniqueVariables.Count + 1;
            for (int i = 0; i < uniqueVariables.Count; i++)
            {
                dgv.Columns[i].Name = uniqueVariables[i].ToString();
                dgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            dgv.Columns[uniqueVariables.Count].Name = tbInfixProp.Text;
            dgv.Columns[uniqueVariables.Count].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            
            for (int i = 0; i < rows.Count; i++)
            {
                dgv.Rows.Add(rows[i]);
            }
        }
        private void SetFormulas(PropTree tree, TruthTable table)
        {
            List<char> uniqueVariables = tree.GetUniqueVariables();

            StringBuilder sbVariables = new StringBuilder();
            for (int i = 0; i < uniqueVariables.Count; i++)
            {
                sbVariables.Append(uniqueVariables[i]);
            }

            List<char> uniqueOperators = tree.GetUniqueOperators();
            StringBuilder sbOperators = new StringBuilder();
            for (int i = 0; i < uniqueOperators.Count; i++)
            {
                sbOperators.Append(uniqueOperators[i]);
            }

            tbPrefix.Text = tree.Proposition;
            tbInfixProp.Text = tree.ToInfix();
            tbVariables.Text = sbVariables.ToString();
            tbOperators.Text = sbOperators.ToString();

            tbBinary.Text = table.GetBinaryString();
            tbHashValue.Text = table.GetHexaDecimal();
            tbBinarySimplified.Text = table.GetSimplifiedBinaryString();
            tbHashSimplified.Text = table.GetSimplifiedHexaDecimal();

            PropTree dnfTree = table.DNF();
            tbDNF.Text = dnfTree.ToInfix();
            PropTree dnfSimplifiedTree = table.DNFSimplified();
            tbDNFSimplified.Text = dnfSimplifiedTree.ToInfix();
            PropTree nandTree = tree.Nandify();
            tbNand.Text = nandTree.Proposition;
        }

        private void btFormulas_Click(object sender, EventArgs e)
        {
            panelFormulas.Show();
            pbTree.Hide();
            truthTable.Hide();
            truthTableSimplified.Hide();
        }

        private void btTree_Click(object sender, EventArgs e)
        {
            pbTree.Show();
            truthTable.Hide();
            truthTableSimplified.Hide();
            panelFormulas.Hide();
        }

        private void btTruthTable_Click(object sender, EventArgs e)
        {
            truthTable.Show();
            truthTableSimplified.Hide();
            pbTree.Hide();
            panelFormulas.Hide();
        }

        private void btTableSimplified_Click(object sender, EventArgs e)
        {
            truthTableSimplified.Show();
            truthTable.Hide();
            pbTree.Hide();
            panelFormulas.Hide();
        }
    }
}
