namespace Hash
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
            this.tbValor = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridHash = new System.Windows.Forms.DataGridView();
            this.cbHash = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHash)).BeginInit();
            this.SuspendLayout();
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(72, 86);
            this.tbValor.MaxLength = 11;
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(121, 20);
            this.tbValor.TabIndex = 0;
            this.tbValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbValor_KeyPress);
            // 
            // button1
            // 
            this.button1.Image = global::Hash.Properties.Resources._6098_32x32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(227, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 41);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridHash
            // 
            this.dataGridHash.AllowUserToAddRows = false;
            this.dataGridHash.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHash.Location = new System.Drawing.Point(23, 134);
            this.dataGridHash.Name = "dataGridHash";
            this.dataGridHash.Size = new System.Drawing.Size(225, 487);
            this.dataGridHash.TabIndex = 2;
            // 
            // cbHash
            // 
            this.cbHash.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHash.FormattingEnabled = true;
            this.cbHash.Items.AddRange(new object[] {
            "",
            "Folding",
            "MidSquare"});
            this.cbHash.Location = new System.Drawing.Point(72, 27);
            this.cbHash.Name = "cbHash";
            this.cbHash.Size = new System.Drawing.Size(121, 21);
            this.cbHash.TabIndex = 3;
            this.cbHash.SelectedIndexChanged += new System.EventHandler(this.cbHash_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Valor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hash:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(275, 248);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 238);
            this.listBox1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(263, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "VETOR DOS VALORES:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 644);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbHash);
            this.Controls.Add(this.dataGridHash);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbValor);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hash";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHash)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridHash;
        private System.Windows.Forms.ComboBox cbHash;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
    }
}

