using DevExpress.XtraEditors;
using EsoguYazilim.OgrenciTakip.UI.Win.Interfaces;
using System.ComponentModel;
using System.Drawing;

namespace EsoguYazilim.OgrenciTakip.UI.Win.UserControls.Controls
{
    public class MyTextEdit : TextEdit, IStatusBarAciklama
    {
        [ToolboxItem(true)]

        public MyTextEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.MaxLength = 50;
        }

        public override bool EnterMoveNextControl { get; set; } = true;

        public string StatusBarAciklama { get ; set; }
    }
}