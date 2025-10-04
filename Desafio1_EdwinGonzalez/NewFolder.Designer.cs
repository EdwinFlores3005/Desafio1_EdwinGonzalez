namespace Desafio1_EdwinGonzalez
{
    partial class NewFolder
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
            fldrLabel = new Label();
            nameFolder = new TextBox();
            okayBtn = new Button();
            cnclBtn = new Button();
            SuspendLayout();
            // 
            // fldrLabel
            // 
            fldrLabel.AutoSize = true;
            fldrLabel.Location = new Point(12, 51);
            fldrLabel.Name = "fldrLabel";
            fldrLabel.Size = new Size(223, 20);
            fldrLabel.TabIndex = 0;
            fldrLabel.Text = "Ingrese el nombre de la carpeta:";
            // 
            // nameFolder
            // 
            nameFolder.Location = new Point(241, 48);
            nameFolder.Name = "nameFolder";
            nameFolder.Size = new Size(198, 27);
            nameFolder.TabIndex = 1;
            // 
            // okayBtn
            // 
            okayBtn.Location = new Point(123, 118);
            okayBtn.Name = "okayBtn";
            okayBtn.Size = new Size(94, 29);
            okayBtn.TabIndex = 2;
            okayBtn.Text = "Aceptar";
            okayBtn.UseVisualStyleBackColor = true;
            okayBtn.Click += okayBtn_Click;
            // 
            // cnclBtn
            // 
            cnclBtn.DialogResult = DialogResult.Cancel;
            cnclBtn.Location = new Point(241, 118);
            cnclBtn.Name = "cnclBtn";
            cnclBtn.Size = new Size(94, 29);
            cnclBtn.TabIndex = 3;
            cnclBtn.Text = "Cancelar";
            cnclBtn.UseVisualStyleBackColor = true;
            // 
            // NewFolder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 174);
            Controls.Add(cnclBtn);
            Controls.Add(okayBtn);
            Controls.Add(nameFolder);
            Controls.Add(fldrLabel);
            Name = "NewFolder";
            Text = "NewFolder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label fldrLabel;
        private TextBox nameFolder;
        private Button okayBtn;
        private Button cnclBtn;
    }
}