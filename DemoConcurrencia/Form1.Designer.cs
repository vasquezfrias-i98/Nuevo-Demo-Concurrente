namespace DemoConcurrencia
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
            fileSystemWatcher1 = new FileSystemWatcher();
            splitContainer1 = new SplitContainer();
            BtnCancelarHilo = new Button();
            BtnTarea = new Button();
            BtnHilo = new Button();
            BtnSecuencial = new Button();
            TxtResultado = new TextBox();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            fileSystemWatcher1.Changed += fileSystemWatcher1_Changed;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(BtnCancelarHilo);
            splitContainer1.Panel1.Controls.Add(BtnTarea);
            splitContainer1.Panel1.Controls.Add(BtnHilo);
            splitContainer1.Panel1.Controls.Add(BtnSecuencial);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(TxtResultado);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 266;
            splitContainer1.TabIndex = 0;
            // 
            // BtnCancelarHilo
            // 
            BtnCancelarHilo.Location = new Point(27, 178);
            BtnCancelarHilo.Name = "BtnCancelarHilo";
            BtnCancelarHilo.Size = new Size(207, 42);
            BtnCancelarHilo.TabIndex = 3;
            BtnCancelarHilo.Text = "Cancelar Hilo";
            BtnCancelarHilo.UseVisualStyleBackColor = true;
            BtnCancelarHilo.Click += BtnCancelar_Click;
            // 
            // BtnTarea
            // 
            BtnTarea.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnTarea.Location = new Point(27, 127);
            BtnTarea.Name = "BtnTarea";
            BtnTarea.Size = new Size(207, 45);
            BtnTarea.TabIndex = 2;
            BtnTarea.Text = "IniciarTarea";
            BtnTarea.UseVisualStyleBackColor = true;
            // 
            // BtnHilo
            // 
            BtnHilo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnHilo.Location = new Point(27, 73);
            BtnHilo.Name = "BtnHilo";
            BtnHilo.Size = new Size(207, 48);
            BtnHilo.TabIndex = 1;
            BtnHilo.Text = "Iniciar Hilos";
            BtnHilo.UseVisualStyleBackColor = true;
            BtnHilo.Click += BtnHilo_Click;
            // 
            // BtnSecuencial
            // 
            BtnSecuencial.Location = new Point(27, 24);
            BtnSecuencial.Name = "BtnSecuencial";
            BtnSecuencial.Size = new Size(207, 43);
            BtnSecuencial.TabIndex = 0;
            BtnSecuencial.Text = "Iniciar Secuencial";
            BtnSecuencial.UseVisualStyleBackColor = true;
            BtnSecuencial.Click += BtnSecuencial_Click;
            // 
            // TxtResultado
            // 
            TxtResultado.Dock = DockStyle.Fill;
            TxtResultado.Location = new Point(0, 0);
            TxtResultado.Multiline = true;
            TxtResultado.Name = "TxtResultado";
            TxtResultado.Size = new Size(530, 450);
            TxtResultado.TabIndex = 1;
            TxtResultado.TextChanged += TxtResultado_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Demostracion de Concurrencia";
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FileSystemWatcher fileSystemWatcher1;
        private SplitContainer splitContainer1;
        private Button BtnSecuencial;
        private Button BtnHilo;
        private TextBox TxtResultado;
        private Button BtnTarea;
        private Button BtnCancelarHilo;
    }
}
