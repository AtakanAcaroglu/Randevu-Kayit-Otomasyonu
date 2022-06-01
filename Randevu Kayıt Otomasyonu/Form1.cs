using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Proje_şeysi
{
    public partial class Form1 : Form
    {
        List<randevu> randevular = new List<randevu>();

        private string defaultNameHolder = "İsim soyisim giriniz";
        private const int DEFAULT_PHONE_LENGTH = 11;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaydiTamamla_Click(object sender, EventArgs e)
        {
            bool kontrol = addAppointment();

            if (!kontrol) MessageBox.Show("selamunalyekum");

            resetForm();

            try {

                removeDataGridRows();
                addDataToDataGridRows();

            } catch (Exception ex) {

                MessageBox.Show(ex.Message);

            }

        }

        private bool addAppointment()
        {
            string cinsiyet = getGender();

            hideFormErrors();

            if (txtIsimSoyisim.Text != null && txtIsimSoyisim.Text != "" &&
                txtTelefonNo.Text != null && txtTelefonNo.Text != "" && txtTelefonNo.Text.Length != DEFAULT_PHONE_LENGTH &&
                cbxDoktor.SelectedItem != null )
            {
                randevu rn = new randevu(txtIsimSoyisim.Text, txtMeslek.Text, cinsiyet, txtTelefonNo.Text, txtSikayet.Text, dtpRandevuTarihi.Text, txtAlınanNotlar.Text, txtKullandigiIlaclar.Text, cbxDoktor.SelectedItem);
                randevular.Add(rn);
                return true;
            }

            showFormErrors();

            return false;
        }

        private string getGender()
        {
            if (rbtErkek.Checked) return "Erkek";
            if (rbtKadın.Checked) return "Kadın";
            return null;
        }

        private void hideFormErrors()
        {
            txtNameError.Visible = false;
            txtTelError.Visible = false;
            txtDocError.Visible = false;
        }

        private void showFormErrors()
        {
            if (txtIsimSoyisim.Text == null || txtIsimSoyisim.Text == "") txtNameError.Visible = true;
            if (txtTelefonNo.Text.Length == DEFAULT_PHONE_LENGTH) txtTelError.Visible = true;
            if (cbxDoktor.SelectedItem == null) txtDocError.Visible = true;
        }

        private void resetForm()
        {
            txtIsimSoyisim.Text = "";
            txtMeslek.Text = "";
            txtTelefonNo.Text = "";
            txtSikayet.Text = "";
            dtpRandevuTarihi.Text = "";
            txtAlınanNotlar.Text = "";
            txtKullandigiIlaclar.Text = "";
        }

        private void removeDataGridRows()
        {
            dataGridView1.Rows.Clear();
        }

        private void addDataToDataGridRows()
        {
            for (int i = 0; i < randevular.Count(); i++)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = randevular[i].nameSurname;
                row.Cells[1].Value = randevular[i].job;
                row.Cells[2].Value = randevular[i].gender;
                row.Cells[3].Value = randevular[i].phone;
                row.Cells[4].Value = randevular[i].complaint;
                row.Cells[5].Value = randevular[i].date;
                row.Cells[6].Value = randevular[i].notes;
                row.Cells[7].Value = randevular[i].medicines;
                row.Cells[8].Value = randevular[i].prefferedDoctor;
                dataGridView1.Rows.Add(row);
            }
        }
        
        private void chxDetayliArama_Click(object sender, EventArgs e)
        {
            dtpArama.Enabled = chxDetayliArama.Checked;
            txtTelArama.Enabled = chxDetayliArama.Checked;
            dtpArama.Visible = chxDetayliArama.Checked;
            txtTelArama.Visible = chxDetayliArama.Checked;
            lblTelefonNmr.Visible = chxDetayliArama.Checked;
            lblRandevuTrh.Visible = chxDetayliArama.Checked;
        }

        private void txtAra_Enter(object sender, EventArgs e)
        {
            if(txtAra.Text != null) txtAra.Text = "";
            txtAra.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
        }

        private void txtAra_Leave(object sender, EventArgs e)
        {
            if (txtAra.Text == null || txtAra.Text == "" || txtAra.Text == " ") txtAra.Text = defaultNameHolder;
            txtAra.ForeColor = System.Drawing.SystemColors.InactiveCaption;
        }

        private void lsbIslemBilgileri_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] listBoxSelected = lsbIslemBilgileri.GetItemText(lsbIslemBilgileri.SelectedItem).Replace(" ", "").ToString().Split('\t');
            txtIslemID.Text = listBoxSelected[0];
        }

        private void chxOnay_CheckedChanged(object sender, EventArgs e)
        {
            btnKaydiTamamla.Enabled = chxOnay.Checked;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            randevuArama ra = new randevuArama(txtAra.Text, chxDetayliArama.Checked, dtpArama.Text, txtTelArama.Text);
            if(ra.nameSurname != defaultNameHolder)
            {
                txtSearchError.Visible = false;
                if (ra.detailedSearch)
                    MessageBox.Show("Randevu arama sistemi geçici bir süreliğine çalışmamaktadır.\n\nGirdiğiniz bilgiler :\n\nisim soyisim = " + ra.getName() + "\ntelefon numarası = " + ra.getPhone() + "\ntarih = " + ra.getDate());
                else
                    MessageBox.Show("Randevu arama sistemi geçici bir süreliğine çalışmamaktadır.\n\nGirdiğiniz bilgiler :\n\nisim soyisim = " + ra.getName());
            }
            else
            {
                txtSearchError.Visible = true;
            }
        }
    }
}