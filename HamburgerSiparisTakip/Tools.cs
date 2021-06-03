using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HamburgerSiparisTakip
{
    public static class Tools
    {
        public static void Temizle(Control.ControlCollection collection)
        {
            //tüm form elemanlarının işlemi bitince temizleme işlemlerini bu class a topladık
            foreach (var item in collection)
            {
                if (item is TextBox)
                {

                    TextBox txt = (TextBox)item;
                    txt.Clear();
                }
                if (item is CheckBox)
                {
                    CheckBox chk = (CheckBox)item;
                    chk.Checked = false;
                }
                if (item is RadioButton)
                {
                    RadioButton rb = (RadioButton)item;
                    if (rb.Name == "rbKucuk")
                    { 
                        rb.Checked = true;
                    }
                    else 
                    { 
                        rb.Checked = false;
                    } 
                }
                if (item is NumericUpDown)
                {
                    NumericUpDown numeric = (NumericUpDown)item;
                    numeric.Value = 1;
                }
                if (item is ComboBox)
                {
                    ComboBox cmb = (ComboBox)item;
                    cmb.SelectedIndex = 0;
                }
                if (item is FlowLayoutPanel)
                {
                    FlowLayoutPanel flp = (FlowLayoutPanel)item;
                    Temizle(flp.Controls);

                }
                if (item is GroupBox)
                {
                    GroupBox gb = (GroupBox)item;
                    Temizle(gb.Controls);

                }


            }


        }
    }
}

