using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using EsoguYazilim.OgrenciTakip.UI.Win.Interfaces;
using System;
using System.ComponentModel;
using System.Drawing;

//using System.Drawing.Configuration;

namespace EsoguYazilim.OgrenciTakip.UI.Win.UserControls.Controls
{
    public class MyButtonEdit : ButtonEdit, IStatusBarKisaYol
    {
        [ToolboxItem(true)]

      
        public MyButtonEdit()
        {
            Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            Properties.AppearanceFocused.BackColor = Color.LightCyan;

        }

        public override bool EnterMoveNextControl { get; set; } = true;

        public string StatusBarAciklama { get; set; }

        public string StatusBarKisaYol { get; set; } = "F4 :";

        public string StatusBarKisaYolAciklama { get; set; }

        #region Events

        private long? _id;

        [Browsable(false)]

        public long? Id
        {
            get => _id;

            set
            {
                var oldValue = _id;
                var newValue = value;
                if (oldValue == newValue) return;
                _id = value;
                IdChanged(this, new IdChangedEventArgs(oldValue, newValue));
            }
        }

        public event EventHandler<IdChangedEventArgs> IdChanged = delegate { }; 
        #endregion
    }

    public class IdChangedEventArgs : EventArgs
    {
        public IdChangedEventArgs(long? oldValue, long? newValue)
        {
            OldValue = oldValue;
            NewValue = newValue;
        }

        public long? OldValue { get; }

        public long? NewValue { get; }
    }
}