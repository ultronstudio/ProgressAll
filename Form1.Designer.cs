namespace ProgressAll
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusProgress = new System.Windows.Forms.StatusStrip();
            this.stripStatus_Stav = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.tabPage_Oaplikaci = new System.Windows.Forms.TabPage();
            this.tabPage_GitHub = new System.Windows.Forms.TabPage();
            this.webGitHub = new System.Windows.Forms.WebBrowser();
            this.panelProgress = new System.Windows.Forms.Panel();
            this.btnAkce = new System.Windows.Forms.Button();
            this.pbarProgress = new System.Windows.Forms.ProgressBar();
            this.timerProgress = new System.Windows.Forms.Timer(this.components);
            this.lbl_oAplikaci = new System.Windows.Forms.Label();
            this.statusProgress.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.tabPage_Oaplikaci.SuspendLayout();
            this.tabPage_GitHub.SuspendLayout();
            this.panelProgress.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusProgress
            // 
            this.statusProgress.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripStatus_Stav});
            this.statusProgress.Location = new System.Drawing.Point(0, 428);
            this.statusProgress.Name = "statusProgress";
            this.statusProgress.Size = new System.Drawing.Size(800, 22);
            this.statusProgress.TabIndex = 0;
            this.statusProgress.Text = "statusStrip1";
            // 
            // stripStatus_Stav
            // 
            this.stripStatus_Stav.Name = "stripStatus_Stav";
            this.stripStatus_Stav.Size = new System.Drawing.Size(32, 17);
            this.stripStatus_Stav.Text = "STAV";
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.tabPage_Oaplikaci);
            this.tabMenu.Controls.Add(this.tabPage_GitHub);
            this.tabMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMenu.Location = new System.Drawing.Point(0, 55);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(800, 373);
            this.tabMenu.TabIndex = 1;
            // 
            // tabPage_Oaplikaci
            // 
            this.tabPage_Oaplikaci.Controls.Add(this.lbl_oAplikaci);
            this.tabPage_Oaplikaci.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Oaplikaci.Name = "tabPage_Oaplikaci";
            this.tabPage_Oaplikaci.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Oaplikaci.Size = new System.Drawing.Size(792, 347);
            this.tabPage_Oaplikaci.TabIndex = 0;
            this.tabPage_Oaplikaci.Text = "O aplikaci";
            this.tabPage_Oaplikaci.UseVisualStyleBackColor = true;
            // 
            // tabPage_GitHub
            // 
            this.tabPage_GitHub.Controls.Add(this.webGitHub);
            this.tabPage_GitHub.Location = new System.Drawing.Point(4, 22);
            this.tabPage_GitHub.Name = "tabPage_GitHub";
            this.tabPage_GitHub.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_GitHub.Size = new System.Drawing.Size(792, 347);
            this.tabPage_GitHub.TabIndex = 1;
            this.tabPage_GitHub.Text = "GitHub";
            this.tabPage_GitHub.UseVisualStyleBackColor = true;
            // 
            // webGitHub
            // 
            this.webGitHub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webGitHub.Location = new System.Drawing.Point(3, 3);
            this.webGitHub.MinimumSize = new System.Drawing.Size(20, 20);
            this.webGitHub.Name = "webGitHub";
            this.webGitHub.ScriptErrorsSuppressed = true;
            this.webGitHub.ScrollBarsEnabled = false;
            this.webGitHub.Size = new System.Drawing.Size(786, 341);
            this.webGitHub.TabIndex = 0;
            this.webGitHub.Url = new System.Uri("https://guthib.com", System.UriKind.Absolute);
            // 
            // panelProgress
            // 
            this.panelProgress.Controls.Add(this.btnAkce);
            this.panelProgress.Controls.Add(this.pbarProgress);
            this.panelProgress.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProgress.Location = new System.Drawing.Point(0, 0);
            this.panelProgress.Name = "panelProgress";
            this.panelProgress.Size = new System.Drawing.Size(800, 55);
            this.panelProgress.TabIndex = 2;
            // 
            // btnAkce
            // 
            this.btnAkce.Location = new System.Drawing.Point(713, 16);
            this.btnAkce.Name = "btnAkce";
            this.btnAkce.Size = new System.Drawing.Size(75, 23);
            this.btnAkce.TabIndex = 1;
            this.btnAkce.Text = "AKCE";
            this.btnAkce.UseVisualStyleBackColor = true;
            this.btnAkce.Click += new System.EventHandler(this.btnAkce_Click);
            // 
            // pbarProgress
            // 
            this.pbarProgress.Location = new System.Drawing.Point(12, 16);
            this.pbarProgress.Name = "pbarProgress";
            this.pbarProgress.Size = new System.Drawing.Size(695, 23);
            this.pbarProgress.Step = 1;
            this.pbarProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbarProgress.TabIndex = 0;
            // 
            // timerProgress
            // 
            this.timerProgress.Interval = 50;
            this.timerProgress.Tick += new System.EventHandler(this.timerProgress_Tick);
            // 
            // lbl_oAplikaci
            // 
            this.lbl_oAplikaci.AutoSize = true;
            this.lbl_oAplikaci.Location = new System.Drawing.Point(6, 3);
            this.lbl_oAplikaci.Name = "lbl_oAplikaci";
            this.lbl_oAplikaci.Size = new System.Drawing.Size(263, 13);
            this.lbl_oAplikaci.TabIndex = 0;
            this.lbl_oAplikaci.Text = "Procvičení dalších různých prvků pro Windows Forms";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabMenu);
            this.Controls.Add(this.panelProgress);
            this.Controls.Add(this.statusProgress);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProgressAll";
            this.statusProgress.ResumeLayout(false);
            this.statusProgress.PerformLayout();
            this.tabMenu.ResumeLayout(false);
            this.tabPage_Oaplikaci.ResumeLayout(false);
            this.tabPage_Oaplikaci.PerformLayout();
            this.tabPage_GitHub.ResumeLayout(false);
            this.panelProgress.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusProgress;
        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.TabPage tabPage_Oaplikaci;
        private System.Windows.Forms.TabPage tabPage_GitHub;
        private System.Windows.Forms.Panel panelProgress;
        private System.Windows.Forms.ProgressBar pbarProgress;
        private System.Windows.Forms.Button btnAkce;
        private System.Windows.Forms.WebBrowser webGitHub;
        private System.Windows.Forms.ToolStripStatusLabel stripStatus_Stav;
        private System.Windows.Forms.Timer timerProgress;
        private System.Windows.Forms.Label lbl_oAplikaci;
    }
}

