namespace Desafio1_EdwinGonzalez
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            ArchivoView = new TreeView();
            fldrBtn = new Button();
            fileBtn = new Button();
            routeBtn = new Button();
            srchBox = new TextBox();
            srchBtn = new Button();
            SuspendLayout();
            // 
            // ArchivoView
            // 
            ArchivoView.BackColor = SystemColors.Window;
            ArchivoView.Location = new Point(12, 58);
            ArchivoView.Name = "ArchivoView";
            ArchivoView.Size = new Size(372, 380);
            ArchivoView.TabIndex = 0;
            // 
            // fldrBtn
            // 
            fldrBtn.BackColor = SystemColors.Window;
            fldrBtn.Location = new Point(12, 12);
            fldrBtn.Name = "fldrBtn";
            fldrBtn.Size = new Size(147, 29);
            fldrBtn.TabIndex = 1;
            fldrBtn.Text = "Nueva carpeta";
            fldrBtn.UseVisualStyleBackColor = false;
            fldrBtn.Click += fldrBtn_Click;
            // 
            // fileBtn
            // 
            fileBtn.BackColor = SystemColors.Window;
            fileBtn.Location = new Point(176, 12);
            fileBtn.Name = "fileBtn";
            fileBtn.Size = new Size(147, 29);
            fileBtn.TabIndex = 2;
            fileBtn.Text = "Nuevo archivo";
            fileBtn.UseVisualStyleBackColor = false;
            fileBtn.Click += fileBtn_Click;
            // 
            // routeBtn
            // 
            routeBtn.BackColor = SystemColors.Window;
            routeBtn.Location = new Point(341, 13);
            routeBtn.Name = "routeBtn";
            routeBtn.Size = new Size(147, 29);
            routeBtn.TabIndex = 3;
            routeBtn.Text = "Mostrar ruta";
            routeBtn.UseVisualStyleBackColor = false;
            routeBtn.Click += routeBtn_Click;
            // 
            // srchBox
            // 
            srchBox.Cursor = Cursors.IBeam;
            srchBox.Location = new Point(505, 14);
            srchBox.Name = "srchBox";
            srchBox.PlaceholderText = "Buscar en archivos";
            srchBox.Size = new Size(189, 27);
            srchBox.TabIndex = 4;
            // 
            // srchBtn
            // 
            srchBtn.BackColor = SystemColors.Window;
            srchBtn.Location = new Point(700, 14);
            srchBtn.Name = "srchBtn";
            srchBtn.Size = new Size(76, 29);
            srchBtn.TabIndex = 5;
            srchBtn.Text = "Buscar";
            srchBtn.UseVisualStyleBackColor = false;
            srchBtn.Click += srchBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(srchBtn);
            Controls.Add(srchBox);
            Controls.Add(routeBtn);
            Controls.Add(fileBtn);
            Controls.Add(fldrBtn);
            Controls.Add(ArchivoView);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Sistema de archivos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView ArchivoView;
        private Button fldrBtn;
        private Button fileBtn;
        private Button routeBtn;
        private TextBox srchBox;
        private Button srchBtn;
    }
}
