namespace ExsUnipartner
{
    public static class Despertador
    {
        private static bool estado;
        private static string data;
        private static string hora;

        public static void on() { estado = true; }
        public static void off() { estado = false; }
        public static string Data { set { data = value; } }
        public static string Hora { set { hora = value; } }

    }
}
