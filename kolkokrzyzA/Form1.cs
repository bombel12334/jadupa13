using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kolkokrzyzA
{
    enum ObecnyGracz
    {
        Kolko,
        Krzyz
    }
    public partial class Form1 : Form
    {
        ObecnyGracz obecnyGracz;
        public Form1()
        {
            InitializeComponent();
            obecnyGracz = ObecnyGracz.Krzyz;
            zmienLabelke();
        }

        private void Mark(object sender, EventArgs e)
        {
            Button senderButton = (Button) sender;
            if (obecnyGracz == ObecnyGracz.Krzyz)
            {
                senderButton.Text = "X";
                obecnyGracz = ObecnyGracz.Kolko;
            }
            else
            {
                senderButton.Text = "0";
                obecnyGracz = ObecnyGracz.Krzyz;
            }

            if (sprawdzZwyciezce())
                PokaZwyciezce();
            zmienLabelke();
        }

        private void zmienLabelke()
        {
            if (obecnyGracz == ObecnyGracz.Krzyz)
            {
                obecnyGraczLabel.Text = "krzyzyk";
            }
            else
            {
                obecnyGraczLabel.Text = "kółeczko";
            }
        }

        public bool sprawdzZwyciezce()
        {
            if(String.Compare(TL.Text, CL.Text) == 0 && String.Compare(CL.Text, BL.Text) == 0 && String.Compare(CL.Text, "") != 0 )
            {
                return true;
            }
            
            if(String.Compare(TC.Text, CC.Text) == 0 && String.Compare(CC.Text, BC.Text) == 0 && String.Compare(CC.Text, "") != 0 )
            {
                return true;
            }
            
            if(String.Compare(TR.Text, CR.Text) == 0 && String.Compare(CR.Text, BR.Text) == 0 && String.Compare(CR.Text, "") != 0 )
            {
                return true;
            }
            
            if(String.Compare(TL.Text, TC.Text) == 0 && String.Compare(TC.Text, TR.Text) == 0 && String.Compare(TC.Text, "") != 0 )
            {
                return true;
            }
            
            if(String.Compare(CL.Text, CC.Text) == 0 && String.Compare(CC.Text, CR.Text) == 0 && String.Compare(CC.Text, "") != 0 )
            {
                return true;
            }
            if(String.Compare(BL.Text, BC.Text) == 0 && String.Compare(BC.Text, BR.Text) == 0 && String.Compare(BC.Text, "") != 0 )
            {
                return true;
            }
            if(String.Compare(TL.Text, CC.Text) == 0 && String.Compare(CC.Text, BR.Text) == 0 && String.Compare(CC.Text, "") != 0 )
            {
                return true;
            }
            if(String.Compare(TR.Text, CC.Text) == 0 && String.Compare(CC.Text, BL.Text) == 0 && String.Compare(CC.Text, "") != 0 )
            {
                return true;
            }
            return false;
        }

        public void PokaZwyciezce()
        {
            Form2 panelZwyciezcy = new Form2(this);
            panelZwyciezcy.Zwyciezca = obecnyGraczLabel.Text;
            panelZwyciezcy.Show();
        }
    }
}