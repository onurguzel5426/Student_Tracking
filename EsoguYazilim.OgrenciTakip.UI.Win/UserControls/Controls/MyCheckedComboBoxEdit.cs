using DevExpress.XtraEditors;
using EsoguYazilim.OgrenciTakip.UI.Win.Interfaces;
using System.Drawing;
using System.ComponentModel;

namespace EsoguYazilim.OgrenciTakip.UI.Win.UserControls.Controls
{
    public class MyCheckedComboBoxEdit : CheckedComboBoxEdit,IStatusBarKisaYol
    {
        [ToolboxItem(true)]

        public MyCheckedComboBoxEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
        }

        public override bool EnterMoveNextControl { get; set; } = true;

        string IStatusBarKisaYol.StatusBarKisaYol { get; set; } = "F4 :";

        string IStatusBarKisaYol.StatusBarKisaYolAciklama { get; set; }

        string IStatusBarAciklama.StatusBarAciklama { get; set; }
    }
}