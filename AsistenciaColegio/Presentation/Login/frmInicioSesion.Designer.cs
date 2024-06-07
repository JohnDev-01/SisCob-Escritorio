namespace SisCob.Presentation.Login
{
    partial class frmInicioSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicioSesion));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelUsuarios = new System.Windows.Forms.Panel();
            this.Pcontra = new System.Windows.Forms.Panel();
            this.PcontenedorContra = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnDeUsuario = new System.Windows.Forms.Button();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblNombreUser = new System.Windows.Forms.Label();
            this.IconoContra = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnborrartodo = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnBorrarUnCaracter = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblIngresa = new System.Windows.Forms.Label();
            this.txtContra = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelUsuarios.SuspendLayout();
            this.Pcontra.SuspendLayout();
            this.PcontenedorContra.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconoContra)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 50);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(52, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "SisCob";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::SisCob.Properties.Resources.siscobIcono;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(101, 63);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 63);
            this.label2.TabIndex = 0;
            this.label2.Text = "Inicio De Sesión. \r\nUsuarios Disponibles:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 63);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(101, 6);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // panelUsuarios
            // 
            this.panelUsuarios.Controls.Add(this.flowLayoutPanel1);
            this.panelUsuarios.Controls.Add(this.panel2);
            this.panelUsuarios.Location = new System.Drawing.Point(17, 141);
            this.panelUsuarios.Name = "panelUsuarios";
            this.panelUsuarios.Size = new System.Drawing.Size(101, 69);
            this.panelUsuarios.TabIndex = 3;
            // 
            // Pcontra
            // 
            this.Pcontra.Controls.Add(this.PcontenedorContra);
            this.Pcontra.Location = new System.Drawing.Point(56, 82);
            this.Pcontra.Name = "Pcontra";
            this.Pcontra.Size = new System.Drawing.Size(700, 402);
            this.Pcontra.TabIndex = 4;
            // 
            // PcontenedorContra
            // 
            this.PcontenedorContra.Controls.Add(this.panel6);
            this.PcontenedorContra.Controls.Add(this.panel3);
            this.PcontenedorContra.Location = new System.Drawing.Point(57, 3);
            this.PcontenedorContra.Name = "PcontenedorContra";
            this.PcontenedorContra.Size = new System.Drawing.Size(610, 407);
            this.PcontenedorContra.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnDeUsuario);
            this.panel6.Controls.Add(this.lblRol);
            this.panel6.Controls.Add(this.lblNombreUser);
            this.panel6.Controls.Add(this.IconoContra);
            this.panel6.Location = new System.Drawing.Point(22, 53);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(292, 261);
            this.panel6.TabIndex = 3;
            // 
            // btnDeUsuario
            // 
            this.btnDeUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btnDeUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDeUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDeUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeUsuario.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDeUsuario.Location = new System.Drawing.Point(3, 184);
            this.btnDeUsuario.Name = "btnDeUsuario";
            this.btnDeUsuario.Size = new System.Drawing.Size(286, 33);
            this.btnDeUsuario.TabIndex = 4;
            this.btnDeUsuario.Text = "Cambiar de usuario";
            this.btnDeUsuario.UseVisualStyleBackColor = false;
            this.btnDeUsuario.Click += new System.EventHandler(this.btnDeUsuario_Click);
            // 
            // lblRol
            // 
            this.lblRol.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.ForeColor = System.Drawing.Color.DarkGray;
            this.lblRol.Location = new System.Drawing.Point(0, 145);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(292, 16);
            this.lblRol.TabIndex = 3;
            this.lblRol.Text = "Rol";
            this.lblRol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNombreUser
            // 
            this.lblNombreUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNombreUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUser.ForeColor = System.Drawing.Color.White;
            this.lblNombreUser.Location = new System.Drawing.Point(0, 122);
            this.lblNombreUser.Name = "lblNombreUser";
            this.lblNombreUser.Size = new System.Drawing.Size(292, 23);
            this.lblNombreUser.TabIndex = 2;
            this.lblNombreUser.Text = "Nombre Usuario: ";
            this.lblNombreUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IconoContra
            // 
            this.IconoContra.Dock = System.Windows.Forms.DockStyle.Top;
            this.IconoContra.Image = global::SisCob.Properties.Resources.siscobIcono;
            this.IconoContra.Location = new System.Drawing.Point(0, 0);
            this.IconoContra.Name = "IconoContra";
            this.IconoContra.Size = new System.Drawing.Size(292, 122);
            this.IconoContra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconoContra.TabIndex = 1;
            this.IconoContra.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn9);
            this.panel3.Controls.Add(this.btnborrartodo);
            this.panel3.Controls.Add(this.btn0);
            this.panel3.Controls.Add(this.btnBorrarUnCaracter);
            this.panel3.Controls.Add(this.btn8);
            this.panel3.Controls.Add(this.btn7);
            this.panel3.Controls.Add(this.btn6);
            this.panel3.Controls.Add(this.btn5);
            this.panel3.Controls.Add(this.btn4);
            this.panel3.Controls.Add(this.btn3);
            this.panel3.Controls.Add(this.btn2);
            this.panel3.Controls.Add(this.btn1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(330, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(264, 363);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btn9
            // 
            this.btn9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn9.BackgroundImage")));
            this.btn9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn9.FlatAppearance.BorderSize = 0;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.Color.White;
            this.btn9.Location = new System.Drawing.Point(176, 198);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 80);
            this.btn9.TabIndex = 1;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btnborrartodo
            // 
            this.btnborrartodo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnborrartodo.BackgroundImage")));
            this.btnborrartodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnborrartodo.FlatAppearance.BorderSize = 0;
            this.btnborrartodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnborrartodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnborrartodo.ForeColor = System.Drawing.Color.White;
            this.btnborrartodo.Location = new System.Drawing.Point(10, 274);
            this.btnborrartodo.Name = "btnborrartodo";
            this.btnborrartodo.Size = new System.Drawing.Size(75, 80);
            this.btnborrartodo.TabIndex = 1;
            this.btnborrartodo.Text = "Borrar Todo";
            this.btnborrartodo.UseVisualStyleBackColor = true;
            this.btnborrartodo.Click += new System.EventHandler(this.btnborrartodo_Click);
            // 
            // btn0
            // 
            this.btn0.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn0.BackgroundImage")));
            this.btn0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn0.FlatAppearance.BorderSize = 0;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.Color.White;
            this.btn0.Location = new System.Drawing.Point(92, 274);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(75, 80);
            this.btn0.TabIndex = 1;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnBorrarUnCaracter
            // 
            this.btnBorrarUnCaracter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBorrarUnCaracter.BackgroundImage")));
            this.btnBorrarUnCaracter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBorrarUnCaracter.FlatAppearance.BorderSize = 0;
            this.btnBorrarUnCaracter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarUnCaracter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarUnCaracter.ForeColor = System.Drawing.Color.White;
            this.btnBorrarUnCaracter.Location = new System.Drawing.Point(176, 274);
            this.btnBorrarUnCaracter.Name = "btnBorrarUnCaracter";
            this.btnBorrarUnCaracter.Size = new System.Drawing.Size(75, 80);
            this.btnBorrarUnCaracter.TabIndex = 1;
            this.btnBorrarUnCaracter.Text = "<--";
            this.btnBorrarUnCaracter.UseVisualStyleBackColor = true;
            this.btnBorrarUnCaracter.Click += new System.EventHandler(this.btnBorrarUnCaracter_Click);
            // 
            // btn8
            // 
            this.btn8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn8.BackgroundImage")));
            this.btn8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.Color.White;
            this.btn8.Location = new System.Drawing.Point(92, 198);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 80);
            this.btn8.TabIndex = 1;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn7.BackgroundImage")));
            this.btn7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.Color.White;
            this.btn7.Location = new System.Drawing.Point(10, 198);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 80);
            this.btn7.TabIndex = 1;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn6
            // 
            this.btn6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn6.BackgroundImage")));
            this.btn6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.Color.White;
            this.btn6.Location = new System.Drawing.Point(176, 122);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 80);
            this.btn6.TabIndex = 1;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn5.BackgroundImage")));
            this.btn5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.White;
            this.btn5.Location = new System.Drawing.Point(92, 122);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 80);
            this.btn5.TabIndex = 1;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn4.BackgroundImage")));
            this.btn4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.White;
            this.btn4.Location = new System.Drawing.Point(10, 122);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 80);
            this.btn4.TabIndex = 1;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.BackgroundImage = global::SisCob.Properties.Resources.rectangulo_con_esquinas_redondeadas__3_;
            this.btn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.White;
            this.btn3.Location = new System.Drawing.Point(176, 49);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 80);
            this.btn3.TabIndex = 1;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.BackgroundImage = global::SisCob.Properties.Resources.rectangulo_con_esquinas_redondeadas__3_;
            this.btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.White;
            this.btn2.Location = new System.Drawing.Point(92, 49);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 80);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn1.BackgroundImage")));
            this.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.White;
            this.btn1.Location = new System.Drawing.Point(10, 49);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 80);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lblIngresa);
            this.panel4.Controls.Add(this.txtContra);
            this.panel4.Location = new System.Drawing.Point(10, 11);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(241, 29);
            this.panel4.TabIndex = 0;
            // 
            // lblIngresa
            // 
            this.lblIngresa.AutoSize = true;
            this.lblIngresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresa.ForeColor = System.Drawing.Color.Gray;
            this.lblIngresa.Location = new System.Drawing.Point(61, 4);
            this.lblIngresa.Name = "lblIngresa";
            this.lblIngresa.Size = new System.Drawing.Size(114, 18);
            this.lblIngresa.TabIndex = 1;
            this.lblIngresa.Text = "Ingresa Tu Pin...";
            // 
            // txtContra
            // 
            this.txtContra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txtContra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContra.ForeColor = System.Drawing.Color.White;
            this.txtContra.Location = new System.Drawing.Point(0, 0);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(239, 26);
            this.txtContra.TabIndex = 4;
            this.txtContra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtContra.UseSystemPasswordChar = true;
            this.txtContra.TextChanged += new System.EventHandler(this.txtContra_TextChanged);
            // 
            // frmInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(976, 577);
            this.Controls.Add(this.Pcontra);
            this.Controls.Add(this.panelUsuarios);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmInicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInicioSesion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panelUsuarios.ResumeLayout(false);
            this.Pcontra.ResumeLayout(false);
            this.PcontenedorContra.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IconoContra)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelUsuarios;
        private System.Windows.Forms.Panel Pcontra;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblIngresa;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnborrartodo;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnBorrarUnCaracter;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Panel PcontenedorContra;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblNombreUser;
        private System.Windows.Forms.PictureBox IconoContra;
        private System.Windows.Forms.Button btnDeUsuario;
        private System.Windows.Forms.MaskedTextBox txtContra;
    }
}