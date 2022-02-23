namespace MusicPlayer
{
    internal class Guitarist : Person, IMusicPlayer
    {
        private Instrument instrument;

        public Guitarist(string name) : base(name)
        {
            instrument = new Instrument("Guitar");
        }

        public Instrument Instrument { get { return instrument; } set { instrument = value; } }

        public void Play()
        {
            Console.WriteLine("♫ ♫ ♫ ♫ ♫");
        }
    }
}
