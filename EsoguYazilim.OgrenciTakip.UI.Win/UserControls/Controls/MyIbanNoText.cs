using DevExpress.XtraEditors.Mask;
using System.ComponentModel;

namespace EsoguYazilim.OgrenciTakip.UI.Win.UserControls.Controls
{
    public class MyIbanNoText : MyTextEdit
    {
        [ToolboxItem(true)]

        public MyIbanNoText()
        {
            Properties.Mask.MaskType = MaskType.Regular;
            Properties.Mask.EditMask = @"TR\d?\d? \d?\d?\d?\d? \d?\d?\d?\d? \d?\d?\d?\d? \d?\d?\d?\d? \d?\d?\d?\d? \d?\d?";
            Properties.Mask.AutoComplete = AutoCompleteType.None;
            StatusBarAciklama = "IBAN No Giriniz.";
        }
    }
}