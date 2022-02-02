namespace ExsUnipartner
{
    public static class Despertador
    {
        public static bool Estado { get; set; }
        public static string Data { get; set; }
        public static string Hora { get; set; }

        public static void On() { Estado = true; }
        public static void Off() { Estado = false; }
    }
}
