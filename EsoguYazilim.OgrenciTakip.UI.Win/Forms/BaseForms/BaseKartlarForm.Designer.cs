namespace EsoguYazilim.OgrenciTakip.UI.Win.Forms.BaseForms
{
    partial class BaseKartlarForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseKartlarForm));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnYeni = new DevExpress.XtraBars.BarButtonItem();
            this.btnSil = new DevExpress.XtraBars.BarButtonItem();
            this.btnSec = new DevExpress.XtraBars.BarButtonItem();
            this.btnDuzelt = new DevExpress.XtraBars.BarButtonItem();
            this.btnYenile = new DevExpress.XtraBars.BarButtonItem();
            this.btnFiltrele = new DevExpress.XtraBars.BarButtonItem();
            this.btnKolonlar = new DevExpress.XtraBars.BarButtonItem();
            this.btnYazdir = new DevExpress.XtraBars.BarButtonItem();
            this.btnGonder = new DevExpress.XtraBars.BarButtonItem();
            this.btnCikis = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.DrawGroupCaptions = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.DrawGroupsBorderMode = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.ribbonControl.SearchEditItem,
            this.btnYeni,
            this.btnSil,
            this.btnSec,
            this.btnDuzelt,
            this.btnYenile,
            this.btnFiltrele,
            this.btnKolonlar,
            this.btnYazdir,
            this.btnGonder,
            this.btnCikis});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 12;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl.ShowQatLocationSelector = false;
            this.ribbonControl.ShowToolbarCustomizeItem = false;
            this.ribbonControl.Size = new System.Drawing.Size(592, 109);
            this.ribbonControl.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // btnYeni
            // 
            this.btnYeni.Caption = "Yeni";
            this.btnYeni.Id = 1;
            this.btnYeni.ImageOptions.DisabledLargeImage = global::EsoguYazilim.OgrenciTakip.UI.Win.Properties.Resources.addfile_32x32;
            this.btnYeni.ImageOptions.Image = global::EsoguYazilim.OgrenciTakip.UI.Win.Properties.Resources.addfile_16x16;
            this.btnYeni.ImageOptions.LargeImage = global::EsoguYazilim.OgrenciTakip.UI.Win.Properties.Resources.addfile_32x32;
            this.btnYeni.Name = "btnYeni";
            toolTipItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            toolTipItem1.Text = "Yeni Kart Ekle";
            superToolTip1.Items.Add(toolTipItem1);
            this.btnYeni.SuperTip = superToolTip1;
            // 
            // btnSil
            // 
            this.btnSil.Caption = "Sil";
            this.btnSil.Id = 2;
            this.btnSil.ImageOptions.DisabledLargeImage = global::EsoguYazilim.OgrenciTakip.UI.Win.Properties.Resources.deletelist_32x32;
            this.btnSil.ImageOptions.Image = global::EsoguYazilim.OgrenciTakip.UI.Win.Properties.Resources.deletelist_32x32;
            this.btnSil.ImageOptions.LargeImage = global::EsoguYazilim.OgrenciTakip.UI.Win.Properties.Resources.deletelist_32x32;
            this.btnSil.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Delete);
            this.btnSil.Name = "btnSil";
            // 
            // btnSec
            // 
            this.btnSec.Caption = "Seç";
            this.btnSec.Id = 3;
            this.btnSec.ImageOptions.Image = global::EsoguYazilim.OgrenciTakip.UI.Win.Properties.Resources.apply_16x16;
            this.btnSec.ImageOptions.LargeImage = global::EsoguYazilim.OgrenciTakip.UI.Win.Properties.Resources.apply_32x32;
            this.btnSec.Name = "btnSec";
            this.btnSec.ShortcutKeyDisplayString = "Enter";
            // 
            // btnDuzelt
            // 
            this.btnDuzelt.Caption = "Düzelt";
            this.btnDuzelt.Id = 4;
            this.btnDuzelt.ImageOptions.Image = global::EsoguYazilim.OgrenciTakip.UI.Win.Properties.Resources.edit_16x16;
            this.btnDuzelt.ImageOptions.LargeImage = global::EsoguYazilim.OgrenciTakip.UI.Win.Properties.Resources.edit_32x32;
            this.btnDuzelt.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F3);
            this.btnDuzelt.Name = "btnDuzelt";
            // 
            // btnYenile
            // 
            this.btnYenile.Caption = "Yenile";
            this.btnYenile.Id = 5;
            this.btnYenile.ImageOptions.Image = global::EsoguYazilim.OgrenciTakip.UI.Win.Properties.Resources.convert_16x16;
            this.btnYenile.ImageOptions.LargeImage = global::EsoguYazilim.OgrenciTakip.UI.Win.Properties.Resources.convert_32x32;
            this.btnYenile.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.btnYenile.Name = "btnYenile";
            // 
            // btnFiltrele
            // 
            this.btnFiltrele.Caption = "Filtrele";
            this.btnFiltrele.Id = 6;
            this.btnFiltrele.ImageOptions.Image = global::EsoguYazilim.OgrenciTakip.UI.Win.Properties.Resources.crossdatasourcefiltering__16x16;
            this.btnFiltrele.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnFiltrele.ImageOptions.LargeImage")));
            this.btnFiltrele.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F8);
            this.btnFiltrele.Name = "btnFiltrele";
            // 
            // btnKolonlar
            // 
            this.btnKolonlar.Caption = "Kolonlar";
            this.btnKolonlar.Id = 7;
            this.btnKolonlar.ImageOptions.Image = global::EsoguYazilim.OgrenciTakip.UI.Win.Properties.Resources.weekend_16x16;
            this.btnKolonlar.ImageOptions.LargeImage = global::EsoguYazilim.OgrenciTakip.UI.Win.Properties.Resources.weekend_32x32;
            this.btnKolonlar.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O));
            this.btnKolonlar.Name = "btnKolonlar";
            // 
            // btnYazdir
            // 
            this.btnYazdir.Caption = "Yazdır";
            this.btnYazdir.Id = 8;
            this.btnYazdir.ImageOptions.Image = global::EsoguYazilim.OgrenciTakip.UI.Win.Properties.Resources.print_16x16;
            this.btnYazdir.ImageOptions.LargeImage = global::EsoguYazilim.OgrenciTakip.UI.Win.Properties.Resources.print_32x32;
            this.btnYazdir.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P));
            this.btnYazdir.Name = "btnYazdir";
            // 
            // btnGonder
            // 
            this.btnGonder.Caption = "Gönder";
            this.btnGonder.Id = 9;
            this.btnGonder.ImageOptions.Image = global::EsoguYazilim.OgrenciTakip.UI.Win.Properties.Resources.exportfile_16x16;
            this.btnGonder.ImageOptions.LargeImage = global::EsoguYazilim.OgrenciTakip.UI.Win.Properties.Resources.exportfile_32x32;
            this.btnGonder.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F12);
            this.btnGonder.Name = "btnGonder";
            // 
            // btnCikis
            // 
            this.btnCikis.Caption = "Çıkış";
            this.btnCikis.Id = 11;
            this.btnCikis.ImageOptions.Image = global::EsoguYazilim.OgrenciTakip.UI.Win.Properties.Resources.close_16x16;
            this.btnCikis.ImageOptions.LargeImage = global::EsoguYazilim.OgrenciTakip.UI.Win.Properties.Resources.close_32x32;
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.ShortcutKeyDisplayString = "Esc";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnYeni);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSil);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSec);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDuzelt);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnYenile);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnFiltrele);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnKolonlar);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnYazdir);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnGonder);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCikis);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 334);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(592, 24);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // BaseKartlarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 358);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl);
            this.IconOptions.ShowIcon = false;
            this.MinimizeBox = false;
            this.Name = "BaseKartlarForm";
            this.Ribbon = this.ribbonControl;
            this.ShowInTaskbar = false;
            this.StatusBar = this.ribbonStatusBar1;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem btnYeni;
        private DevExpress.XtraBars.BarButtonItem btnSil;
        private DevExpress.XtraBars.BarButtonItem btnSec;
        private DevExpress.XtraBars.BarButtonItem btnDuzelt;
        private DevExpress.XtraBars.BarButtonItem btnYenile;
        private DevExpress.XtraBars.BarButtonItem btnFiltrele;
        private DevExpress.XtraBars.BarButtonItem btnKolonlar;
        private DevExpress.XtraBars.BarButtonItem btnYazdir;
        private DevExpress.XtraBars.BarButtonItem btnGonder;
        private DevExpress.XtraBars.BarButtonItem btnCikis;
    }
}