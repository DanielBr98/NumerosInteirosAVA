namespace NumerosInteirosAVA
{
    partial class FrmNums
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
            this.btnFor = new System.Windows.Forms.Button();
            this.btnWhile = new System.Windows.Forms.Button();
            this.btnDo = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lstNums = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnFor
            // 
            this.btnFor.Location = new System.Drawing.Point(343, 69);
            this.btnFor.Name = "btnFor";
            this.btnFor.Size = new System.Drawing.Size(75, 23);
            this.btnFor.TabIndex = 0;
            this.btnFor.Text = "FOR";
            this.btnFor.UseVisualStyleBackColor = true;
            this.btnFor.Click += new System.EventHandler(this.btnFor_Click);
            // 
            // btnWhile
            // 
            this.btnWhile.Location = new System.Drawing.Point(343, 136);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(75, 23);
            this.btnWhile.TabIndex = 1;
            this.btnWhile.Text = "WHILE";
            this.btnWhile.UseVisualStyleBackColor = true;
            this.btnWhile.Click += new System.EventHandler(this.btnWhile_Click);
            // 
            // btnDo
            // 
            this.btnDo.Location = new System.Drawing.Point(343, 210);
            this.btnDo.Name = "btnDo";
            this.btnDo.Size = new System.Drawing.Size(75, 23);
            this.btnDo.TabIndex = 2;
            this.btnDo.Text = "DO";
            this.btnDo.UseVisualStyleBackColor = true;
            this.btnDo.Click += new System.EventHandler(this.btnDo_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(343, 273);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lstNums
            // 
            this.lstNums.FormattingEnabled = true;
            this.lstNums.Location = new System.Drawing.Point(20, 13);
            this.lstNums.Name = "lstNums";
            this.lstNums.Size = new System.Drawing.Size(230, 381);
            this.lstNums.TabIndex = 4;
            // 
            // FrmNums
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 407);
            this.Controls.Add(this.lstNums);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnDo);
            this.Controls.Add(this.btnWhile);
            this.Controls.Add(this.btnFor);
            this.Name = "FrmNums";
            this.Text = "Lista números inteiros";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFor;
        private System.Windows.Forms.Button btnWhile;
        private System.Windows.Forms.Button btnDo;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ListBox lstNums;
    }
}

