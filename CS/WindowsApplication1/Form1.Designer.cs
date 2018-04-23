namespace WindowsApplication1
{
    partial class Form1
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
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.dnDHighlightHelper1 = new WindowsApplication1.DnDHighlightHelper();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeList1
            // 
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.Location = new System.Drawing.Point(0, 0);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsBehavior.DragNodes = true;
            this.treeList1.OptionsBehavior.Editable = false;
            this.treeList1.Size = new System.Drawing.Size(572, 482);
            this.treeList1.TabIndex = 0;
            // 
            // dnDHighlightHelper1
            // 
            this.dnDHighlightHelper1.AppearanceHighlight.BackColor = System.Drawing.Color.Gold;
            this.dnDHighlightHelper1.AppearanceHighlight.BackColor2 = System.Drawing.Color.DarkOrange;
            this.dnDHighlightHelper1.AppearanceHighlight.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dnDHighlightHelper1.AppearanceHighlight.Options.UseBackColor = true;
            this.dnDHighlightHelper1.SelectedTreeList = this.treeList1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 482);
            this.Controls.Add(this.treeList1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeList1;
        private DnDHighlightHelper dnDHighlightHelper1;
    }
}

