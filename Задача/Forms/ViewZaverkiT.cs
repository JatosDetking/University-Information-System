using System;
using System.Windows.Forms;
using WindowsFormsApp1.Forms;
using WindowsFormsApp1.StudentApp;

namespace WindowsFormsApp1
{
    public partial class ViewZaverkiT : Form
    {
        public ViewZaverkiT()
        {
            InitializeComponent();
            foreach (var i in LinQ.teacherSubjectName())
            {
                Subject.Items.Add(i);
            }
        }
        private void Search_Click(object sender, EventArgs e)
        {
            int p = 0;
            if (int.TryParse(FN.Text, out p))
            {
                MessageBox.Show(((Lector)LinQ.getAccount()).ViewZaverki(LinQ.OutPutSubject(Subject.Text), Convert.ToInt32(FN.Text)));
            }
            else
            {
                FN.Clear();
                MessageBox.Show("Невалиден факултетен номер.");
            }     
        }
        private void Back_Click(object sender, EventArgs e)
        {
            LinQ.getAccount().newForm(this);
        }
    }
}
