namespace Bolanos_GUI_Winforms_Activity
{
    partial class Form1_LoginPage
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1_LoginPage));
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            pictureBox2 = new PictureBox();
            button1 = new Button();

            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();

            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 3);
            pictureBox1.Size = new Size(440, 443);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;

            textBox1.Location = new Point(517, 157);
            textBox1.Size = new Size(218, 27);
            textBox1.PlaceholderText = "Username";

            textBox2.Location = new Point(517, 209);
            textBox2.Size = new Size(218, 27);
            textBox2.PlaceholderText = "Password";
            textBox2.UseSystemPasswordChar = true;

            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18F);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(544, 64);
            label1.Text = "WELCOME";

            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 9F);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(549, 99);
            label2.Text = "Sign in to your account.";

            button1.BackColor = Color.DarkGreen;
            button1.ForeColor = Color.White;
            button1.Location = new Point(573, 291);
            button1.Size = new Size(98, 30);
            button1.Text = "Sign In";
            button1.FlatStyle = FlatStyle.Flat;
            button1.Click += button1_Click;

            label5.AutoSize = true;
            label5.ForeColor = Color.DarkGreen;
            label5.Location = new Point(610, 240);
            label5.Text = "Forgot Password?";

            label7.AutoSize = true;
            label7.ForeColor = Color.DarkGreen;
            label7.Location = new Point(490, 366);
            label7.Text = "Don't have an account?";

            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.ForeColor = Color.DarkGreen;
            label8.Location = new Point(649, 366);
            label8.Text = "Register now.";

            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(707, 213);
            pictureBox2.Size = new Size(19, 20);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Click += pictureBox2_Click;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);

            Name = "Form1_LoginPage";
            Text = "Login Page";
            Load += Form1_Load;

            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label label7;
        private Label label8;
        private PictureBox pictureBox2;
        private Button button1;
    }
}