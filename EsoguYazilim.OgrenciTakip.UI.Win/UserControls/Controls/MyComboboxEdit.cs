using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using EsoguYazilim.OgrenciTakip.UI.Win.Interfaces;
using System.ComponentModel;
using System.Drawing;

namespace EsoguYazilim.OgrenciTakip.UI.Win.UserControls.Controls
{
    public class MyComboboxEdit : ComboBoxEdit, IStatusBarKisaYol
    {
        [ToolboxItem(true)]

        public MyComboboxEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.TextEditStyle = TextEditStyles.DisableTextEditor;

        }

        public override bool EnterMoveNextControl { get; set; } = true;

        public string StatusBarKisaYol { get; set; } = "F4 :";

        public string StatusBarKisaYolAciklama { get; set; }

        public string StatusBarAciklama { get; set; }
    }
}