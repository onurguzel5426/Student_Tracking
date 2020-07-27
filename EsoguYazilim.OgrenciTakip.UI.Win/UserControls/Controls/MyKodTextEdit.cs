using System.ComponentModel;
using System.Drawing;
using DevExpress.Utils;
using EsoguYazilim.OgrenciTakip.UI.Win.Interfaces;

namespace EsoguYazilim.OgrenciTakip.UI.Win.UserControls.Controls
{
    public class MyKodTextEdit : MyTextEdit
    {
        [ToolboxItem(true)]

        public MyKodTextEdit()
        {
            Properties.Appearance.BackColor = Color.PaleGoldenrod;
            Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            Properties.MaxLength = 20;
            StatusBarAciklama = "Kod Giriniz.";
        }
    }
}