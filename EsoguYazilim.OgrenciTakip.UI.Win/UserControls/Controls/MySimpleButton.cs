using DevExpress.XtraEditors;
using EsoguYazilim.OgrenciTakip.UI.Win.Interfaces;
using System.ComponentModel;
using System.Drawing;

namespace EsoguYazilim.OgrenciTakip.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]

    public class MySimpleButton: SimpleButton,IStatusBarAciklama
    {
        public MySimpleButton()
        {
            Appearance.ForeColor = Color.Maroon;
        }

        public string StatusBarAciklama { get ; set ; }
    }
}