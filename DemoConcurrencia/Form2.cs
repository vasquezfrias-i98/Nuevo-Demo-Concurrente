namespace DemoConcurrencia
{
    public partial class FrmBloqueos : Form
    {
        private int contador = 0;
        private object bloqueo = new();
        private SemaphoreSlim semaforo = new SemaphoreSlim(2);

        public FrmBloqueos()
        {
            InitializeComponent();
        }

        private void BtnIncrementar_Click(object sender, EventArgs e)
        {

        }

        private void BtnDisminuir_Click(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                semaforo.Wait();

                lock (bloqueo)
                {
                    contador++;
                    Thread.Sleep(1000);

                    this.Invoke((MethodInvoker)delegate
                    {

                        LblContador.Text = contador.ToString();

                    });
                    Monitor.Pulse(bloqueo);
                }
                //semaforo.Release();
            });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                lock (bloqueo)
                {
                    while (contador <= 0)
                    {
                        ActualizarResultado("Esperando...");
                        Monitor.Wait(bloqueo);
                    }
                    contador--;
                    Thread.Sleep(1000);

                    this.Invoke((MethodInvoker)delegate
                    {

                        LblContador.Text = contador.ToString();

                    });

                }
                ActualizarResultado("Procesando...");
            });
        }

        private void TxtResultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
