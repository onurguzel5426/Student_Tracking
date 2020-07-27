using DevExpress.XtraEditors;
using EsoguYazilim.OgrenciTakip.UI.Win.Interfaces;
using System.ComponentModel;
using System.Drawing;

namespace EsoguYazilim.OgrenciTakip.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]

    public   class MyCheckEdit: CheckEdit,IStatusBarAciklama
    {
        public MyCheckEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.Transparent;
        }

        public override bool EnterMoveNextControl { get; set; } = true;

        public string StatusBarAciklama { get; set; }
    }
}