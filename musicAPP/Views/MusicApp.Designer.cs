
namespace musicAPP
{
    partial class MusicApp
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.sideBar = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label_biblioteca = new System.Windows.Forms.Label();
            this.btn_canciones = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_album = new System.Windows.Forms.Button();
            this.label_playlist = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_add_pls = new System.Windows.Forms.Button();
            this.btn_pls_3 = new System.Windows.Forms.Button();
            this.btn_pls_2 = new System.Windows.Forms.Button();
            this.btn_pls_1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reproducerContainer = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_canciones = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.sideBar.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // sideBar
            // 
            this.sideBar.Controls.Add(this.panel4);
            this.sideBar.Controls.Add(this.panel3);
            this.sideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar.Location = new System.Drawing.Point(0, 0);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(237, 461);
            this.sideBar.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panel3.Controls.Add(this.btn_album);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.btn_canciones);
            this.panel3.Controls.Add(this.label_biblioteca);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(237, 232);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panel4.Controls.Add(this.btn_pls_3);
            this.panel4.Controls.Add(this.btn_pls_2);
            this.panel4.Controls.Add(this.btn_pls_1);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 232);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(237, 229);
            this.panel4.TabIndex = 1;
            // 
            // label_biblioteca
            // 
            this.label_biblioteca.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_biblioteca.Font = new System.Drawing.Font("Lato Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_biblioteca.Location = new System.Drawing.Point(0, 0);
            this.label_biblioteca.Name = "label_biblioteca";
            this.label_biblioteca.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label_biblioteca.Size = new System.Drawing.Size(237, 54);
            this.label_biblioteca.TabIndex = 0;
            this.label_biblioteca.Text = "Biblioteca";
            this.label_biblioteca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_biblioteca.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_canciones
            // 
            this.btn_canciones.BackColor = System.Drawing.Color.Transparent;
            this.btn_canciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_canciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_canciones.FlatAppearance.BorderSize = 0;
            this.btn_canciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_canciones.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_canciones.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_canciones.Location = new System.Drawing.Point(0, 54);
            this.btn_canciones.Name = "btn_canciones";
            this.btn_canciones.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_canciones.Size = new System.Drawing.Size(237, 33);
            this.btn_canciones.TabIndex = 1;
            this.btn_canciones.Text = "Canciones";
            this.btn_canciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_canciones.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(0, 87);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(237, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Artistas";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.button3.Location = new System.Drawing.Point(0, 194);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(237, 38);
            this.button3.TabIndex = 4;
            this.button3.Text = "Agregar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_album
            // 
            this.btn_album.BackColor = System.Drawing.Color.Transparent;
            this.btn_album.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_album.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_album.FlatAppearance.BorderSize = 0;
            this.btn_album.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_album.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_album.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_album.Location = new System.Drawing.Point(0, 120);
            this.btn_album.Name = "btn_album";
            this.btn_album.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_album.Size = new System.Drawing.Size(237, 33);
            this.btn_album.TabIndex = 5;
            this.btn_album.Text = "Álbumes";
            this.btn_album.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_album.UseVisualStyleBackColor = false;
            // 
            // label_playlist
            // 
            this.label_playlist.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_playlist.Font = new System.Drawing.Font("Lato Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_playlist.Location = new System.Drawing.Point(0, 0);
            this.label_playlist.Name = "label_playlist";
            this.label_playlist.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label_playlist.Size = new System.Drawing.Size(167, 61);
            this.label_playlist.TabIndex = 1;
            this.label_playlist.Text = "Playlists";
            this.label_playlist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_playlist.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_add_pls);
            this.panel5.Controls.Add(this.label_playlist);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(237, 61);
            this.panel5.TabIndex = 2;
            // 
            // btn_add_pls
            // 
            this.btn_add_pls.BackColor = System.Drawing.Color.Transparent;
            this.btn_add_pls.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_add_pls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_add_pls.FlatAppearance.BorderSize = 0;
            this.btn_add_pls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_pls.Font = new System.Drawing.Font("Lato Black", 20.25F, System.Drawing.FontStyle.Bold);
            this.btn_add_pls.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_add_pls.Location = new System.Drawing.Point(167, 0);
            this.btn_add_pls.Name = "btn_add_pls";
            this.btn_add_pls.Size = new System.Drawing.Size(70, 61);
            this.btn_add_pls.TabIndex = 3;
            this.btn_add_pls.Text = "+";
            this.btn_add_pls.UseVisualStyleBackColor = false;
            this.btn_add_pls.Click += new System.EventHandler(this.btn_add_pls_Click);
            // 
            // btn_pls_3
            // 
            this.btn_pls_3.BackColor = System.Drawing.Color.Transparent;
            this.btn_pls_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_pls_3.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_pls_3.FlatAppearance.BorderSize = 0;
            this.btn_pls_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pls_3.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pls_3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_pls_3.Location = new System.Drawing.Point(0, 127);
            this.btn_pls_3.Name = "btn_pls_3";
            this.btn_pls_3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_pls_3.Size = new System.Drawing.Size(237, 33);
            this.btn_pls_3.TabIndex = 8;
            this.btn_pls_3.Text = "Playlist 3";
            this.btn_pls_3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pls_3.UseVisualStyleBackColor = false;
            // 
            // btn_pls_2
            // 
            this.btn_pls_2.BackColor = System.Drawing.Color.Transparent;
            this.btn_pls_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_pls_2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_pls_2.FlatAppearance.BorderSize = 0;
            this.btn_pls_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pls_2.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pls_2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_pls_2.Location = new System.Drawing.Point(0, 94);
            this.btn_pls_2.Name = "btn_pls_2";
            this.btn_pls_2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_pls_2.Size = new System.Drawing.Size(237, 33);
            this.btn_pls_2.TabIndex = 7;
            this.btn_pls_2.Text = "Playlist 2";
            this.btn_pls_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pls_2.UseVisualStyleBackColor = false;
            // 
            // btn_pls_1
            // 
            this.btn_pls_1.BackColor = System.Drawing.Color.Transparent;
            this.btn_pls_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_pls_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_pls_1.FlatAppearance.BorderSize = 0;
            this.btn_pls_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pls_1.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pls_1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_pls_1.Location = new System.Drawing.Point(0, 61);
            this.btn_pls_1.Name = "btn_pls_1";
            this.btn_pls_1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_pls_1.Size = new System.Drawing.Size(237, 33);
            this.btn_pls_1.TabIndex = 6;
            this.btn_pls_1.Text = "Playlist 1";
            this.btn_pls_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pls_1.UseVisualStyleBackColor = false;
            this.btn_pls_1.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.reproducerContainer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(237, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 461);
            this.panel1.TabIndex = 2;
            // 
            // reproducerContainer
            // 
            this.reproducerContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.reproducerContainer.Location = new System.Drawing.Point(0, 0);
            this.reproducerContainer.Name = "reproducerContainer";
            this.reproducerContainer.Size = new System.Drawing.Size(647, 127);
            this.reproducerContainer.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.label_canciones);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 127);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(647, 334);
            this.panel2.TabIndex = 1;
            // 
            // label_canciones
            // 
            this.label_canciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_canciones.Font = new System.Drawing.Font("Lato Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_canciones.Location = new System.Drawing.Point(0, 0);
            this.label_canciones.Name = "label_canciones";
            this.label_canciones.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label_canciones.Size = new System.Drawing.Size(647, 54);
            this.label_canciones.TabIndex = 1;
            this.label_canciones.Text = "Canciones";
            this.label_canciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_canciones.Click += new System.EventHandler(this.label2_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(0, 120);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(647, 33);
            this.button2.TabIndex = 11;
            this.button2.Text = "3   Canción 3";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Location = new System.Drawing.Point(0, 87);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(647, 33);
            this.button4.TabIndex = 10;
            this.button4.Text = "2   Canción 2";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button5.Location = new System.Drawing.Point(0, 54);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(647, 33);
            this.button5.TabIndex = 9;
            this.button5.Text = "1   Canción 1";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // MusicApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(240)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sideBar);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MusicApp";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusicApp";
            this.Load += new System.EventHandler(this.MusicApp_Load);
            this.sideBar.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel sideBar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label_biblioteca;
        private System.Windows.Forms.Button btn_canciones;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_album;
        private System.Windows.Forms.Label label_playlist;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_add_pls;
        private System.Windows.Forms.Button btn_pls_3;
        private System.Windows.Forms.Button btn_pls_2;
        private System.Windows.Forms.Button btn_pls_1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_canciones;
        private System.Windows.Forms.Panel reproducerContainer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

