using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HamburgerSiparisTakip
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void siparisOlusturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new SiparisEkrani());
        }

        //Tüm küçük formları açma işini bu metoda yazdık.
        public void ChildForm(Form _childForm)
        {
            //bu form açılan formdan 200 br daha büyük olsun
            this.Height = _childForm.Height + 200;
            // bu formun genişliği açılan formun genişliğinden 200 br daha geniş olsun 
            this.Width = _childForm.Width + 200;

            bool durum = false; // child ekranin durumunu kontrol icin 

            //formu kapatabilmek üstüste açılmasını önlemek için yazdık
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Text == _childForm.Text)
                {
                    durum = true;
                    frm.Activate();
                }
                else
                {
                    frm.Close();
                }
            }

            if (durum == false)
            {
                _childForm.MdiParent = this;
                _childForm.Show();
            }
        }

        private void siparisBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new SiparisRaporFrm());

        }

        private void menuEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new MenuTanim());

        }

        private void extraMalzemelerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new ExtraMalzemeFrm());

        }
    }
}
