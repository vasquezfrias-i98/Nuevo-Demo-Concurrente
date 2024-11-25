﻿namespace DemoConcurrencia
{
    public sealed class Singleton
    {
        private static Singleton instancia = null;
        private static readonly object bloqueo = new object();

        public string cadenaConexion;
        public Singleton()
        {
            cadenaConexion = "";        }
        public static Singleton Instance
        {
            get
            {
                lock (bloqueo)
                {
                    if (instancia == null)
                    {
                        instancia = new Singleton();

                    }
                    return instancia;
                }

            }
        }
    }
}