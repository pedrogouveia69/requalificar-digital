namespace ExsUnipartner
{
    public class Despertador
    {
        private bool estado;
        private string data;
        private string hora;
        public void on() { estado = true; }
        public void off() { estado = false; }
        public string Data { set { data = value; } }
        public string Hora { set { hora = value; } }

    }
}
