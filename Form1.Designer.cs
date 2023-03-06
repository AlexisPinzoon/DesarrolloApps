namespace Taller1
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
            User = new Label();
            Password = new Label();
            btn_entrar = new Button();
            TxtName = new TextBox();
            TxtPass = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // User
            // 
            User.AutoSize = true;
            User.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            User.Location = new Point(319, 81);
            User.Name = "User";
            User.Size = new Size(38, 20);
            User.TabIndex = 0;
            User.Text = "User";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Password.Location = new Point(319, 155);
            Password.Name = "Password";
            Password.Size = new Size(70, 20);
            Password.TabIndex = 1;
            Password.Text = "Password";
            // 
            // btn_entrar
            // 
            btn_entrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_entrar.Location = new Point(349, 237);
            btn_entrar.Name = "btn_entrar";
            btn_entrar.Size = new Size(107, 37);
            btn_entrar.TabIndex = 2;
            btn_entrar.Text = "Entrar";
            btn_entrar.UseVisualStyleBackColor = true;
            btn_entrar.Click += btn_entrar_Click;
            // 
            // TxtName
            // 
            TxtName.Location = new Point(319, 120);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(170, 23);
            TxtName.TabIndex = 3;
            TxtName.TextChanged += TxtName_TextChanged;
            // 
            // TxtPass
            // 
            TxtPass.Location = new Point(319, 190);
            TxtPass.Name = "TxtPass";
            TxtPass.Size = new Size(170, 23);
            TxtPass.TabIndex = 4;
            TxtPass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(333, 30);
            label1.Name = "label1";
            label1.Size = new Size(144, 30);
            label1.TabIndex = 5;
            label1.Text = "Iniciar Sesion";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(TxtPass);
            Controls.Add(TxtName);
            Controls.Add(btn_entrar);
            Controls.Add(Password);
            Controls.Add(User);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label User;
        private Label Password;
        private Button btn_entrar;
        private TextBox TxtName;
        private TextBox TxtPass;
        private Label label1;
    }
}