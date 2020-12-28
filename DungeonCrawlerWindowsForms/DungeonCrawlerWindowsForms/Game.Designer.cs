namespace DungeonCrawlerWindowsForms
{
    partial class Game
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
            this.encounterLabel = new System.Windows.Forms.Label();
            this.backgroundPanel = new System.Windows.Forms.Panel();
            this.encounterPrompt = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.actionLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.backgroundPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // encounterLabel
            // 
            this.encounterLabel.AutoSize = true;
            this.encounterLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.encounterLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.encounterLabel.Location = new System.Drawing.Point(13, 10);
            this.encounterLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.encounterLabel.Name = "encounterLabel";
            this.encounterLabel.Size = new System.Drawing.Size(320, 50);
            this.encounterLabel.TabIndex = 0;
            this.encounterLabel.Text = "Encounter Label";
            // 
            // backgroundPanel
            // 
            this.backgroundPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.backgroundPanel.Controls.Add(this.encounterPrompt);
            this.backgroundPanel.Controls.Add(this.panel2);
            this.backgroundPanel.Location = new System.Drawing.Point(-5, 57);
            this.backgroundPanel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.backgroundPanel.Name = "backgroundPanel";
            this.backgroundPanel.Size = new System.Drawing.Size(754, 427);
            this.backgroundPanel.TabIndex = 1;
            // 
            // encounterPrompt
            // 
            this.encounterPrompt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.encounterPrompt.BackColor = System.Drawing.SystemColors.GrayText;
            this.encounterPrompt.Location = new System.Drawing.Point(25, 0);
            this.encounterPrompt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.encounterPrompt.Name = "encounterPrompt";
            this.encounterPrompt.Size = new System.Drawing.Size(258, 367);
            this.encounterPrompt.TabIndex = 1;
            this.encounterPrompt.Text = "This is the encounter prompt\nWe can Programaticaly edit this box\n\n";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.Controls.Add(this.actionLayout);
            this.panel2.Location = new System.Drawing.Point(377, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 367);
            this.panel2.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(372, 30);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(6, 6);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // actionLayout
            // 
            this.actionLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actionLayout.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.actionLayout.Location = new System.Drawing.Point(0, 0);
            this.actionLayout.Name = "actionLayout";
            this.actionLayout.Size = new System.Drawing.Size(288, 367);
            this.actionLayout.TabIndex = 3;
            this.actionLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.actionLayout_Paint);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(683, 436);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.backgroundPanel);
            this.Controls.Add(this.encounterLabel);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Game";
            this.Text = "Ender\'s Dungeon 2";
            this.backgroundPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label encounterLabel;
        private System.Windows.Forms.Panel backgroundPanel;
        private System.Windows.Forms.RichTextBox encounterPrompt;
        private System.Windows.Forms.Panel panel2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.FlowLayoutPanel actionLayout;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}