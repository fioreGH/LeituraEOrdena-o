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
using OfficeOpenXml;

namespace WindowsFormsAppLeitorXLXs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OpenFileDialog ofd = new OpenFileDialog();

        private void btnAbrir_Click(object sender, EventArgs e)
        {

            ofd.Filter = "Planilhas | *.xlsx; *.xls";

            if (ofd.ShowDialog() == DialogResult.OK)
            {

                txtCaminho.Text = ofd.FileName;
                rBBubble.Checked = true;

            }

            gBox.Enabled = true;

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            var package = new ExcelPackage(new FileInfo(ofd.FileName));

            ExcelWorksheet workSheet = package.Workbook.Worksheets.First();

            int ultimaLinha = workSheet.Dimension.End.Row + 1;

            int[] vetor = new int[ultimaLinha];

            for (int i = 1; i < ultimaLinha; i++)
            {
                vetor[i] = Convert.ToInt32(workSheet.Cells["A" + i].Value);
            }

            if (rBBubble.Checked)
            {
                Bubble bublee = new Bubble();
                bublee.bubble(vetor);
                
            }
            if (rBQuick.Checked)
            {
                Quick quick = new Quick();
                quick.quick(vetor, 0, vetor.Length - 1);
                
            }

            for (int i = 1; i < vetor.Length; i++)
            {
                workSheet.Cells["B" + i].Value = vetor[i];
            }
            package.Save();
            package.Dispose();
            MessageBox.Show("Processo concluído");
            
        }
    }
}
