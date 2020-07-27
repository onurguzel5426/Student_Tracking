namespace EsoguYazilim.OgrenciTakip.UI.Win.UserControls.Navigators
{
    partial class InsUptNavigator
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsUptNavigator));
            this.Navigator = new DevExpress.XtraEditors.ControlNavigator();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // Navigator
            // 
            this.Navigator.Buttons.Append.ImageIndex = 6;
            this.Navigator.Buttons.CancelEdit.Visible = false;
            this.Navigator.Buttons.Edit.Visible = false;
            this.Navigator.Buttons.EndEdit.Visible = false;
            this.Navigator.Buttons.First.ImageIndex = 0;
            this.Navigator.Buttons.ImageList = this.imageCollection1;
            this.Navigator.Buttons.Last.ImageIndex = 5;
            this.Navigator.Buttons.Next.ImageIndex = 3;
            this.Navigator.Buttons.NextPage.Visible = false;
            this.Navigator.Buttons.Prev.ImageIndex = 2;
            this.Navigator.Buttons.PrevPage.Visible = false;
            this.Navigator.Buttons.Remove.ImageIndex = 7;
            this.Navigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Navigator.Location = new System.Drawing.Point(0, 0);
            this.Navigator.Name = "Navigator";
            this.Navigator.Size = new System.Drawing.Size(464, 24);
            this.Navigator.TabIndex = 0;
            this.Navigator.Text = "controlNavigator1";
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "first_16x16.png");
            this.imageCollection1.Images.SetKeyName(1, "doubleprev_16x16.png");
            this.imageCollection1.Images.SetKeyName(2, "prev_16x16.png");
            this.imageCollection1.Images.SetKeyName(3, "next_16x16.png");
            this.imageCollection1.Images.SetKeyName(4, "doublenext_16x16.png");
            this.imageCollection1.Images.SetKeyName(5, "last_16x16.png");
            this.imageCollection1.InsertImage(global::EsoguYazilim.OgrenciTakip.UI.Win.Properties.Resources.addfile_16x16, "addfile_16x16", typeof(global::EsoguYazilim.OgrenciTakip.UI.Win.Properties.Resources), 6);
            this.imageCollection1.Images.SetKeyName(6, "addfile_16x16");
            this.imageCollection1.InsertImage(global::EsoguYazilim.OgrenciTakip.UI.Win.Properties.Resources.deletelist_16x16, "deletelist_16x16", typeof(global::EsoguYazilim.OgrenciTakip.UI.Win.Properties.Resources), 7);
            this.imageCollection1.Images.SetKeyName(7, "deletelist_16x16");
            // 
            // InsUptNavigator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Navigator);
            this.Name = "InsUptNavigator";
            this.Size = new System.Drawing.Size(464, 24);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ControlNavigator Navigator;
        private DevExpress.Utils.ImageCollection imageCollection1;
    }
}
