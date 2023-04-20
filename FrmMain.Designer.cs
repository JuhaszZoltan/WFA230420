namespace WFA230420
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnRogzit = new Button();
            txtJegyzet = new TextBox();
            lblJegyzetUI = new Label();
            lsbJegyzetek = new ListBox();
            btnTorol = new Button();
            SuspendLayout();
            // 
            // btnRogzit
            // 
            btnRogzit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRogzit.Location = new Point(562, 24);
            btnRogzit.Name = "btnRogzit";
            btnRogzit.Size = new Size(310, 91);
            btnRogzit.TabIndex = 1;
            btnRogzit.Text = "új sor rögzítése";
            btnRogzit.UseVisualStyleBackColor = true;
            btnRogzit.Click += OnBtnRogzitClick;
            // 
            // txtJegyzet
            // 
            txtJegyzet.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtJegyzet.Location = new Point(12, 68);
            txtJegyzet.Name = "txtJegyzet";
            txtJegyzet.Size = new Size(531, 47);
            txtJegyzet.TabIndex = 0;
            txtJegyzet.KeyDown += OnTxtJegyzetKeyDown;
            // 
            // lblJegyzetUI
            // 
            lblJegyzetUI.AutoSize = true;
            lblJegyzetUI.Location = new Point(12, 24);
            lblJegyzetUI.Name = "lblJegyzetUI";
            lblJegyzetUI.Size = new Size(153, 41);
            lblJegyzetUI.TabIndex = 2;
            lblJegyzetUI.Text = "új jegyzet:";
            // 
            // lsbJegyzetek
            // 
            lsbJegyzetek.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lsbJegyzetek.FormattingEnabled = true;
            lsbJegyzetek.ItemHeight = 40;
            lsbJegyzetek.Location = new Point(12, 157);
            lsbJegyzetek.Name = "lsbJegyzetek";
            lsbJegyzetek.ScrollAlwaysVisible = true;
            lsbJegyzetek.Size = new Size(531, 284);
            lsbJegyzetek.TabIndex = 2;
            // 
            // btnTorol
            // 
            btnTorol.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTorol.Location = new Point(562, 157);
            btnTorol.Name = "btnTorol";
            btnTorol.Size = new Size(310, 92);
            btnTorol.TabIndex = 3;
            btnTorol.Text = "kijelölt sor törlése";
            btnTorol.UseVisualStyleBackColor = true;
            btnTorol.Click += OnBtnTorolClick;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(16F, 40F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 461);
            Controls.Add(btnTorol);
            Controls.Add(lsbJegyzetek);
            Controls.Add(lblJegyzetUI);
            Controls.Add(txtJegyzet);
            Controls.Add(btnRogzit);
            Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(7, 8, 7, 8);
            MinimumSize = new Size(900, 500);
            Name = "FrmMain";
            Text = "JEGYZETFÜZET";
            FormClosing += OnFrmMainFormClosing;
            Load += OnFrmMainLoad;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRogzit;
        private TextBox txtJegyzet;
        private Label lblJegyzetUI;
        private ListBox lsbJegyzetek;
        private Button btnTorol;
    }
}