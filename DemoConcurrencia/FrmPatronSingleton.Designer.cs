namespace DemoConcurrencia
{
    partial class FrmPatronSingleton
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
            components = new System.ComponentModel.Container();
            bindingSource1 = new BindingSource(components);
            BtnAsignar = new Button();
            BtnRecuperar = new Button();
            LblCadenaConexionRecuperada = new Label();
            TxtCadenaConexion = new TextBox();
            LblCadenaConexion = new Label();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // BtnAsignar
            // 
            BtnAsignar.Location = new Point(47, 83);
            BtnAsignar.Name = "BtnAsignar";
            BtnAsignar.Size = new Size(131, 45);
            BtnAsignar.TabIndex = 0;
            BtnAsignar.Text = "Asignar Cadena de Conexion";
            BtnAsignar.UseVisualStyleBackColor = true;
            BtnAsignar.Click += BtnAsignar_Click;
            // 
            // BtnRecuperar
            // 
            BtnRecuperar.Location = new Point(47, 146);
            BtnRecuperar.Name = "BtnRecuperar";
            BtnRecuperar.Size = new Size(131, 48);
            BtnRecuperar.TabIndex = 1;
            BtnRecuperar.Text = "Obtener Cadena de Conexion";
            BtnRecuperar.UseVisualStyleBackColor = true;
            BtnRecuperar.Click += BtnRecuperar_Click;
            // 
            // LblCadenaConexionRecuperada
            // 
            LblCadenaConexionRecuperada.AutoSize = true;
            LblCadenaConexionRecuperada.Location = new Point(231, 146);
            LblCadenaConexionRecuperada.Name = "LblCadenaConexionRecuperada";
            LblCadenaConexionRecuperada.Size = new Size(0, 15);
            LblCadenaConexionRecuperada.TabIndex = 2;
            // 
            // TxtCadenaConexion
            // 
            TxtCadenaConexion.Location = new Point(47, 42);
            TxtCadenaConexion.Name = "TxtCadenaConexion";
            TxtCadenaConexion.Size = new Size(440, 23);
            TxtCadenaConexion.TabIndex = 3;
            // 
            // LblCadenaConexion
            // 
            LblCadenaConexion.AutoSize = true;
            LblCadenaConexion.Location = new Point(54, 22);
            LblCadenaConexion.Name = "LblCadenaConexion";
            LblCadenaConexion.Size = new Size(117, 15);
            LblCadenaConexion.TabIndex = 4;
            LblCadenaConexion.Text = "Cadena de Conexion";
            // 
            // FrmPatronSingleton
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 244);
            Controls.Add(LblCadenaConexion);
            Controls.Add(TxtCadenaConexion);
            Controls.Add(LblCadenaConexionRecuperada);
            Controls.Add(BtnRecuperar);
            Controls.Add(BtnAsignar);
            Name = "FrmPatronSingleton";
            Text = "FrmPatronSingleton";
            Load += FrmPatronSingleton_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource bindingSource1;
        private Button BtnAsignar;
        private Button BtnRecuperar;
        private Label LblCadenaConexionRecuperada;
        private TextBox TxtCadenaConexion;
        private Label LblCadenaConexion;
    }
}