using DatabaseBasics.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseBasics.View.Forms;

namespace DatabaseBasics
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void оПрогToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "(C)ТУСУР, каф. КСУП, Деттер Даниил Николаевич, группа 571-2, 2023г.",
                "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show("Вы хотите закрыть программу?", "Внимание",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MedicForm.Instance.ShowForm();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            PatientForm.Instance.ShowForm();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            SickLeaveForm.Instance.ShowForm();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            AttendanceForm.Instance.ShowForm();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            ScheduleForm.Instance.ShowForm();
        }
    }

}
