using DevExpress.XtraEditors;
using DevExpress.Utils;
using System.Drawing;
using EsoguYazilim.OgrenciTakip.UI.Win.Interfaces;
using System.ComponentModel;

namespace EsoguYazilim.OgrenciTakip.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]

    public class MyToggleSwitch : ToggleSwitch,IStatusBarAciklama
    {
        public MyToggleSwitch()
        {
            Name = "tglDurum";
            Properties.OffText = "Pasif";
            Properties.OnText = "Aktif";
            Properties.AutoHeight = false;
            Properties.AutoWidth = true;
            Properties.GlyphAlignment = HorzAlignment.Far;
            Properties.Appearance.ForeColor = Color.Maroon;
        }

        public override bool EnterMoveNextControl { get; set; } = true;

        public string StatusBarAciklama { get; set; } = "Kartın Kullanım Durumunu Seçiniz."; 
    }
}