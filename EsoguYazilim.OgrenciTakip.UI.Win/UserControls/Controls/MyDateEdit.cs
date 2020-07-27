using DevExpress.XtraEditors;
using EsoguYazilim.OgrenciTakip.UI.Win.Interfaces;
using System.ComponentModel;
using DevExpress.Utils;
using DevExpress.XtraEditors.Mask;
using System.Drawing;

namespace EsoguYazilim.OgrenciTakip.UI.Win.UserControls.Controls
{
    public class MyDateEdit : DateEdit, IStatusBarKisaYol
    {
        [ToolboxItem(true)]

        public MyDateEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;          
            Properties.AllowNullInput = DefaultBoolean.False;
            Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            Properties.Mask.MaskType = MaskType.DateTimeAdvancingCaret;
        }

        public override bool EnterMoveNextControl { get; set; } = true;

        public string StatusBarKisaYol { get; set; } = "F4 :";

        public string StatusBarKisaYolAciklama { get; set; } = "Tarih Seç";

        public string StatusBarAciklama { get; set; }
    }
}