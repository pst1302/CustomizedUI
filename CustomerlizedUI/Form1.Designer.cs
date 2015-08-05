namespace CustomerlizedUI
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.topPanel = new System.Windows.Forms.Panel();
            this.Cmb = new System.Windows.Forms.ComboBox();
            this.paintingPanel = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.Cmb);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(737, 94);
            this.topPanel.TabIndex = 0;
            // 
            // Cmb
            // 
            this.Cmb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb.FormattingEnabled = true;
            this.Cmb.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14"});
            this.Cmb.Location = new System.Drawing.Point(38, 33);
            this.Cmb.Name = "Cmb";
            this.Cmb.Size = new System.Drawing.Size(165, 20);
            this.Cmb.TabIndex = 0;
            this.Cmb.SelectedIndexChanged += new System.EventHandler(this.Cmb_SelectedIndexChanged);
            // 
            // paintingPanel
            // 
            this.paintingPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.paintingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paintingPanel.Location = new System.Drawing.Point(0, 94);
            this.paintingPanel.Name = "paintingPanel";
            this.paintingPanel.Size = new System.Drawing.Size(737, 405);
            this.paintingPanel.TabIndex = 1;
            this.paintingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.paintingPanel_Paint);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 499);
            this.Controls.Add(this.paintingPanel);
            this.Controls.Add(this.topPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.ComboBox Cmb;
        private System.Windows.Forms.Panel paintingPanel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

