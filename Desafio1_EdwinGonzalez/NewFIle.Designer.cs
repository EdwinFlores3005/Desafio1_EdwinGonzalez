namespace Desafio1_EdwinGonzalez
{
    partial class NewFIle
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
            cnclBtn = new Button();
            okayBtn = new Button();
            nameFile = new TextBox();
            fileLabel = new Label();
            SuspendLayout();
            // 
            // cnclBtn
            // 
            cnclBtn.DialogResult = DialogResult.Cancel;
            cnclBtn.Location = new Point(241, 109);
            cnclBtn.Name = "cnclBtn";
            cnclBtn.Size = new Size(94, 29);
            cnclBtn.TabIndex = 7;
            cnclBtn.Text = "Cancelar";
            cnclBtn.UseVisualStyleBackColor = true;
            // 
            // okayBtn
            // 
            okayBtn.Location = new Point(123, 109);
            okayBtn.Name = "okayBtn";
            okayBtn.Size = new Size(94, 29);
            okayBtn.TabIndex = 6;
            okayBtn.Text = "Aceptar";
            okayBtn.UseVisualStyleBackColor = true;
            okayBtn.Click += okayBtn_Click;
            // 
            // nameFile
            // 
            nameFile.Location = new Point(241, 39);
            nameFile.Name = "nameFile";
            nameFile.Size = new Size(198, 27);
            nameFile.TabIndex = 5;
            // 
            // fileLabel
            // 
            fileLabel.AutoSize = true;
            fileLabel.Location = new Point(12, 42);
            fileLabel.Name = "fileLabel";
            fileLabel.Size = new Size(209, 20);
            fileLabel.TabIndex = 4;
            fileLabel.Text = "Ingrese el nombre del archivo:";
            // 
            // NewFIle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 172);
            Controls.Add(cnclBtn);
            Controls.Add(okayBtn);
            Controls.Add(nameFile);
            Controls.Add(fileLabel);
            Name = "NewFIle";
            Text = "NewFIle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cnclBtn;
        private Button okayBtn;
        private TextBox nameFile;
        private Label fileLabel;
    }
}