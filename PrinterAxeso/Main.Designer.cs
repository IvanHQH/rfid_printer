namespace PrinterAxeso
{
    partial class Main
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
            this.sequenceFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.sequenceButton = new System.Windows.Forms.Button();
            this.sequenceLabel = new System.Windows.Forms.Label();
            this.templatePath = new System.Windows.Forms.Label();
            this.PrinterPath = new System.Windows.Forms.Label();
            this.TagLabel = new System.Windows.Forms.Label();
            this.templateButton = new System.Windows.Forms.Button();
            this.TagsButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.PrinterBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.templateFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tagFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // sequenceFileDialog
            // 
            this.sequenceFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.sequenceFileDialog_FileOk);
            // 
            // sequenceButton
            // 
            this.sequenceButton.Location = new System.Drawing.Point(782, 1);
            this.sequenceButton.Name = "sequenceButton";
            this.sequenceButton.Size = new System.Drawing.Size(75, 23);
            this.sequenceButton.TabIndex = 0;
            this.sequenceButton.Text = "Seleccionar";
            this.sequenceButton.UseVisualStyleBackColor = true;
            this.sequenceButton.Click += new System.EventHandler(this.sequenceButton_Click);
            // 
            // sequenceLabel
            // 
            this.sequenceLabel.AutoSize = true;
            this.sequenceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sequenceLabel.Location = new System.Drawing.Point(117, 12);
            this.sequenceLabel.Name = "sequenceLabel";
            this.sequenceLabel.Size = new System.Drawing.Size(18, 16);
            this.sequenceLabel.TabIndex = 1;
            this.sequenceLabel.Text = "--";
            // 
            // templatePath
            // 
            this.templatePath.AutoSize = true;
            this.templatePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.templatePath.Location = new System.Drawing.Point(117, 39);
            this.templatePath.Name = "templatePath";
            this.templatePath.Size = new System.Drawing.Size(18, 16);
            this.templatePath.TabIndex = 2;
            this.templatePath.Text = "--";
            // 
            // PrinterPath
            // 
            this.PrinterPath.AutoSize = true;
            this.PrinterPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrinterPath.Location = new System.Drawing.Point(13, 68);
            this.PrinterPath.Name = "PrinterPath";
            this.PrinterPath.Size = new System.Drawing.Size(82, 16);
            this.PrinterPath.TabIndex = 3;
            this.PrinterPath.Text = "Impresora:";
            // 
            // TagLabel
            // 
            this.TagLabel.AutoSize = true;
            this.TagLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TagLabel.Location = new System.Drawing.Point(171, 100);
            this.TagLabel.Name = "TagLabel";
            this.TagLabel.Size = new System.Drawing.Size(18, 16);
            this.TagLabel.TabIndex = 4;
            this.TagLabel.Text = "--";
            // 
            // templateButton
            // 
            this.templateButton.Location = new System.Drawing.Point(782, 32);
            this.templateButton.Name = "templateButton";
            this.templateButton.Size = new System.Drawing.Size(75, 23);
            this.templateButton.TabIndex = 5;
            this.templateButton.Text = "Seleccionar";
            this.templateButton.UseVisualStyleBackColor = true;
            this.templateButton.Click += new System.EventHandler(this.templateButton_Click);
            // 
            // TagsButton
            // 
            this.TagsButton.Location = new System.Drawing.Point(782, 89);
            this.TagsButton.Name = "TagsButton";
            this.TagsButton.Size = new System.Drawing.Size(75, 23);
            this.TagsButton.TabIndex = 6;
            this.TagsButton.Text = "Seleccionar";
            this.TagsButton.UseVisualStyleBackColor = true;
            this.TagsButton.Click += new System.EventHandler(this.TagsButton_Click);
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(782, 134);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(75, 23);
            this.PrintButton.TabIndex = 7;
            this.PrintButton.Text = "Imprimir";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // PrinterBox
            // 
            this.PrinterBox.Location = new System.Drawing.Point(120, 63);
            this.PrinterBox.Name = "PrinterBox";
            this.PrinterBox.Size = new System.Drawing.Size(644, 20);
            this.PrinterBox.TabIndex = 8;
            this.PrinterBox.TextChanged += new System.EventHandler(this.PrinterBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Template:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Secuencia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Etiquetas a imprimir:";
            // 
            // templateFileDialog
            // 
            this.templateFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.templateFileDialog_FileOk);
            // 
            // tagFileDialog
            // 
            this.tagFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.tagFileDialog_FileOk);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 173);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PrinterBox);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.TagsButton);
            this.Controls.Add(this.templateButton);
            this.Controls.Add(this.TagLabel);
            this.Controls.Add(this.PrinterPath);
            this.Controls.Add(this.templatePath);
            this.Controls.Add(this.sequenceLabel);
            this.Controls.Add(this.sequenceButton);
            this.Name = "Main";
            this.Text = "Imprimir";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog sequenceFileDialog;
        private System.Windows.Forms.Button sequenceButton;
        private System.Windows.Forms.Label sequenceLabel;
        private System.Windows.Forms.Label templatePath;
        private System.Windows.Forms.Label PrinterPath;
        private System.Windows.Forms.Label TagLabel;
        private System.Windows.Forms.Button templateButton;
        private System.Windows.Forms.Button TagsButton;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.TextBox PrinterBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog templateFileDialog;
        private System.Windows.Forms.OpenFileDialog tagFileDialog;
    }
}

