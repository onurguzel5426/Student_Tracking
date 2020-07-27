using DevExpress.Utils;
using DevExpress.XtraEditors;
using EsoguYazilim.OgrenciTakip.UI.Win.Interfaces;
using System.ComponentModel;
using System.Drawing;

namespace EsoguYazilim.OgrenciTakip.UI.Win.UserControls.Controls
{
    public class MyCalcEdit : CalcEdit, IStatusBarKisaYol
    {
        [ToolboxItem(true)]

        public MyCalcEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;

            Properties.AllowNullInput = DefaultBoolean.False;

            Properties.EditMask = "n2";
        }

        public override bool EnterMoveNextControl { get; set; } = true;

        public string StatusBarKisaYol { get; set; } = "F4 :";

        public string StatusBarKisaYolAciklama { get; set; } = "Hesap Makinesi";

        public string StatusBarAciklama { get; set; }

    }
}