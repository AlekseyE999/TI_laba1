namespace VisualInteface
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
            this.ListCiphers = new System.Windows.Forms.CheckedListBox();
            this.outputTextEdit = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.inputTextEdit = new System.Windows.Forms.TextBox();
            this.inputLabel = new System.Windows.Forms.Label();
            this.cipherButton = new System.Windows.Forms.Button();
            this.decipherButton = new System.Windows.Forms.Button();
            this.rankEdit = new System.Windows.Forms.NumericUpDown();
            this.rankLabel = new System.Windows.Forms.Label();
            this.stancilLabel = new System.Windows.Forms.Label();
            this.setStencilButton = new System.Windows.Forms.Button();
            this.railEdit = new System.Windows.Forms.NumericUpDown();
            this.keyLabel = new System.Windows.Forms.Label();
            this.columnarLabel = new System.Windows.Forms.Label();
            this.Ceaserlabel = new System.Windows.Forms.Label();
            this.ceasarEdit = new System.Windows.Forms.NumericUpDown();
            this.columnarEdit = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rankEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.railEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceasarEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // ListCiphers
            // 
            this.ListCiphers.CheckOnClick = true;
            this.ListCiphers.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListCiphers.FormattingEnabled = true;
            this.ListCiphers.Items.AddRange(new object[] {
            "Ceasar cipher",
            "Columnar transposition cipher",
            "Rail fence cipher",
            "Turning grille cipher"});
            this.ListCiphers.Location = new System.Drawing.Point(493, 10);
            this.ListCiphers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ListCiphers.Name = "ListCiphers";
            this.ListCiphers.Size = new System.Drawing.Size(225, 114);
            this.ListCiphers.Sorted = true;
            this.ListCiphers.TabIndex = 0;
            this.ListCiphers.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            // 
            // outputTextEdit
            // 
            this.outputTextEdit.AcceptsReturn = true;
            this.outputTextEdit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputTextEdit.Location = new System.Drawing.Point(270, 41);
            this.outputTextEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.outputTextEdit.MaxLength = 100;
            this.outputTextEdit.Name = "outputTextEdit";
            this.outputTextEdit.Size = new System.Drawing.Size(201, 27);
            this.outputTextEdit.TabIndex = 2;
            this.outputTextEdit.WordWrap = false;
            // 
            // labelResult
            // 
            this.labelResult.AllowDrop = true;
            this.labelResult.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.Location = new System.Drawing.Point(329, 7);
            this.labelResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(88, 28);
            this.labelResult.TabIndex = 3;
            this.labelResult.Text = "Result";
            // 
            // inputTextEdit
            // 
            this.inputTextEdit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputTextEdit.Location = new System.Drawing.Point(25, 41);
            this.inputTextEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputTextEdit.MaxLength = 100;
            this.inputTextEdit.Name = "inputTextEdit";
            this.inputTextEdit.Size = new System.Drawing.Size(201, 27);
            this.inputTextEdit.TabIndex = 4;
            this.inputTextEdit.WordWrap = false;
            // 
            // inputLabel
            // 
            this.inputLabel.AllowDrop = true;
            this.inputLabel.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputLabel.Location = new System.Drawing.Point(64, 7);
            this.inputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(131, 28);
            this.inputLabel.TabIndex = 5;
            this.inputLabel.Text = "Input Text";
            // 
            // cipherButton
            // 
            this.cipherButton.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cipherButton.Location = new System.Drawing.Point(25, 421);
            this.cipherButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cipherButton.Name = "cipherButton";
            this.cipherButton.Size = new System.Drawing.Size(92, 29);
            this.cipherButton.TabIndex = 6;
            this.cipherButton.Text = "Cipher Text";
            this.cipherButton.UseVisualStyleBackColor = true;
            this.cipherButton.Click += new System.EventHandler(this.cipherButton_Click);
            // 
            // decipherButton
            // 
            this.decipherButton.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decipherButton.Location = new System.Drawing.Point(153, 421);
            this.decipherButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.decipherButton.Name = "decipherButton";
            this.decipherButton.Size = new System.Drawing.Size(101, 29);
            this.decipherButton.TabIndex = 7;
            this.decipherButton.Text = "Decipher Text";
            this.decipherButton.UseVisualStyleBackColor = true;
            this.decipherButton.Click += new System.EventHandler(this.decipherButton_Click);
            // 
            // rankEdit
            // 
            this.rankEdit.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rankEdit.Location = new System.Drawing.Point(271, 191);
            this.rankEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rankEdit.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.rankEdit.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.rankEdit.Name = "rankEdit";
            this.rankEdit.Size = new System.Drawing.Size(38, 24);
            this.rankEdit.TabIndex = 9;
            this.rankEdit.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.rankEdit.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // rankLabel
            // 
            this.rankLabel.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rankLabel.Location = new System.Drawing.Point(25, 184);
            this.rankLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rankLabel.Name = "rankLabel";
            this.rankLabel.Size = new System.Drawing.Size(127, 28);
            this.rankLabel.TabIndex = 10;
            this.rankLabel.Text = "Rank Stencil";
            // 
            // stancilLabel
            // 
            this.stancilLabel.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stancilLabel.Location = new System.Drawing.Point(572, 142);
            this.stancilLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stancilLabel.Name = "stancilLabel";
            this.stancilLabel.Size = new System.Drawing.Size(73, 28);
            this.stancilLabel.TabIndex = 11;
            this.stancilLabel.Text = "Stencil";
            // 
            // setStencilButton
            // 
            this.setStencilButton.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.setStencilButton.Location = new System.Drawing.Point(292, 421);
            this.setStencilButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.setStencilButton.Name = "setStencilButton";
            this.setStencilButton.Size = new System.Drawing.Size(101, 29);
            this.setStencilButton.TabIndex = 15;
            this.setStencilButton.Text = "Set Stencil";
            this.setStencilButton.UseVisualStyleBackColor = true;
            this.setStencilButton.Click += new System.EventHandler(this.setStencilButton_Click);
            // 
            // railEdit
            // 
            this.railEdit.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.railEdit.Location = new System.Drawing.Point(270, 129);
            this.railEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.railEdit.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.railEdit.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.railEdit.Name = "railEdit";
            this.railEdit.Size = new System.Drawing.Size(38, 24);
            this.railEdit.TabIndex = 16;
            this.railEdit.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // keyLabel
            // 
            this.keyLabel.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.keyLabel.Location = new System.Drawing.Point(25, 129);
            this.keyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(216, 28);
            this.keyLabel.TabIndex = 17;
            this.keyLabel.Text = "Key for rail fence cipher";
            // 
            // columnarLabel
            // 
            this.columnarLabel.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.columnarLabel.Location = new System.Drawing.Point(25, 245);
            this.columnarLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.columnarLabel.Name = "columnarLabel";
            this.columnarLabel.Size = new System.Drawing.Size(216, 28);
            this.columnarLabel.TabIndex = 19;
            this.columnarLabel.Text = "Key for columnar cipher";
            // 
            // Ceaserlabel
            // 
            this.Ceaserlabel.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ceaserlabel.Location = new System.Drawing.Point(25, 312);
            this.Ceaserlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Ceaserlabel.Name = "Ceaserlabel";
            this.Ceaserlabel.Size = new System.Drawing.Size(216, 28);
            this.Ceaserlabel.TabIndex = 21;
            this.Ceaserlabel.Text = "Key for Ceaser cipher";
            // 
            // ceasarEdit
            // 
            this.ceasarEdit.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ceasarEdit.Location = new System.Drawing.Point(270, 312);
            this.ceasarEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ceasarEdit.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.ceasarEdit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ceasarEdit.Name = "ceasarEdit";
            this.ceasarEdit.Size = new System.Drawing.Size(38, 24);
            this.ceasarEdit.TabIndex = 20;
            this.ceasarEdit.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // columnarEdit
            // 
            this.columnarEdit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.columnarEdit.Location = new System.Drawing.Point(271, 245);
            this.columnarEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.columnarEdit.MaxLength = 100;
            this.columnarEdit.Name = "columnarEdit";
            this.columnarEdit.Size = new System.Drawing.Size(201, 27);
            this.columnarEdit.TabIndex = 22;
            this.columnarEdit.WordWrap = false;
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.Location = new System.Drawing.Point(424, 421);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(101, 29);
            this.exitButton.TabIndex = 23;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(743, 482);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.columnarEdit);
            this.Controls.Add(this.Ceaserlabel);
            this.Controls.Add(this.ceasarEdit);
            this.Controls.Add(this.columnarLabel);
            this.Controls.Add(this.keyLabel);
            this.Controls.Add(this.railEdit);
            this.Controls.Add(this.setStencilButton);
            this.Controls.Add(this.stancilLabel);
            this.Controls.Add(this.rankLabel);
            this.Controls.Add(this.rankEdit);
            this.Controls.Add(this.decipherButton);
            this.Controls.Add(this.cipherButton);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.inputTextEdit);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.outputTextEdit);
            this.Controls.Add(this.ListCiphers);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rankEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.railEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceasarEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button exitButton;

        public System.Windows.Forms.TextBox columnarEdit;

        private System.Windows.Forms.Label columnarLabel;
        private System.Windows.Forms.Label Ceaserlabel;
        private System.Windows.Forms.NumericUpDown ceasarEdit;

        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.NumericUpDown railEdit;

        private System.Windows.Forms.Button setStencilButton;

        //private System.Windows.Forms.DataGridView stencil;

        private System.Windows.Forms.Label stancilLabel;

        private System.Windows.Forms.Label rankLabel;

        private System.Windows.Forms.NumericUpDown rankEdit;

        private System.Windows.Forms.Button decipherButton;

        private System.Windows.Forms.Button cipherButton;

        public System.Windows.Forms.TextBox inputTextEdit;
        private System.Windows.Forms.Label inputLabel;

        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox outputTextEdit;

        private System.Windows.Forms.CheckedListBox ListCiphers;

        #endregion
    }
}