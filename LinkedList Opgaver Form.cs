using System.Windows.Forms;
using UserControls;

namespace Peer_Review_LinkedLists
{
    public partial class LinkedList_Opgaver_Form : Form
    {
        UCOpgave1 ucO1 = new UCOpgave1();
        UCOpgave2 ucO2 = new UCOpgave2();
        UCOpgave3 ucO3 = new UCOpgave3();
        UCOpgave4 ucO4 = new UCOpgave4();
        UCOpgave5 ucO5 = new UCOpgave5();
        UCOpgave6 ucO6 = new UCOpgave6();
        UCOpgave7 ucO7 = new UCOpgave7();
        public LinkedList_Opgaver_Form()
        {
            InitializeComponent();
            tabPage1.Controls.Add(ucO1);
            tabPage2.Controls.Add(ucO2);
            tabPage3.Controls.Add(ucO3);
            tabPage4.Controls.Add(ucO4);
            tabPage5.Controls.Add(ucO5);
            tabPage6.Controls.Add(ucO6);
            tabPage7.Controls.Add(ucO7);
        }
    }
}
