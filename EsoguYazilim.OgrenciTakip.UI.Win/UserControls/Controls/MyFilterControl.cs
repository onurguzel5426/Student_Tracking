using DevExpress.XtraEditors;
using EsoguYazilim.OgrenciTakip.UI.Win.Interfaces;
using System.ComponentModel;

namespace EsoguYazilim.OgrenciTakip.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]

    public class MyFilterControl : FilterControl, IStatusBarAciklama
    {
        public MyFilterControl()
        {
            ShowGroupCommandsIcon = true;
        }

        public string StatusBarAciklama { get; set; } = "Filtre Metni Giriniz.";
    }
}