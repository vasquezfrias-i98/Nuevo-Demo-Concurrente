using System.Drawing.Text;

namespace DemoConcurrencia
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource _cts;
        public Form1()
        {
            InitializeComponent();
        }

        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {

        }

        private void BtnSecuencial_Click(object sender, EventArgs e)
        {
            ActualizarResultado("Iniciando proceso secuencial...");
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(2000);
                ActualizarResultado($" Actividad = paso {i + 1}");
            }
            ActualizarResultado("Fin proceso secuencial");
        }

        private void ActualizarResultado(string mensaje)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => ActualizarResultado(mensaje)));
                return;
            }
            TxtResultado.AppendText($"{DateTime.Now:HH:mm:ss.fff}:{mensaje}{Environment.NewLine}");

        }

        private void BtnHilo_Click(object sender, EventArgs e)
        {
            _cts = new CancellationTokenSource();
            var token = _cts.Token;

            Thread Hilo1 = new Thread(() =>
            {
                try
                {
                    ActualizarResultado($"Iniciar un nuevo theard{Thread.CurrentThread.ManagedThreadId}...");
                    for (int i = 0; i < 5; i++)
                    {
                        token.ThrowIfCancellationRequested();

                        Thread.Sleep(5000);
                        ActualizarResultado($" thread {Thread.CurrentThread.ManagedThreadId} paso {i + 1}");
                    }
                    ActualizarResultado($"theard {Thread.CurrentThread.ManagedThreadId} terminado");
                }
                catch (OperationCanceledException)
                {

                    ActualizarResultado("Hilos cancelados");
                }

            });
            Hilo1.Start();
        }

        private async void BtnTarea_Click(object sender, EventArgs e)
        {
            _cts = new CancellationTokenSource();
            var token = _cts.Token;

            await Task.Run(async () =>
             {
                 try
                 {
                     ActualizarResultado($"Iniciando Task {Task.CurrentId}..");
                     for (int i = 0; i < 5; i++)
                     {
                         token.ThrowIfCancellationRequested();

                         Thread.Sleep(2000);
                         ActualizarResultado($" Actividad en tarea {Thread.CurrentThread.ManagedThreadId} {i + 1}");
                     }
                     Thread.Sleep(5000);
                     ActualizarResultado($"Task {Task.CurrentId} Completada");

                 }
                 catch (OperationCanceledException)
                 {

                     ActualizarResultado("tarea cancelada");
                 }


             });
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            _cts?.Cancel();
        }

        private void TxtResultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
