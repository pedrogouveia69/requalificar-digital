namespace MusicPlayer
{
    internal interface IMusicPlayer
    {
        Instrument Instrument { get; set; }
        void Play();
    }
}
