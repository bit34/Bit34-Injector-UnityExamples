public class Game2Settings : IGame2Settings
{
	//	MEMBERS
    public float Volume { get; set; }
    public bool IsMusicPlaying { get; set; }

    //  CONSTRUCTORS
    public Game2Settings()
    {
        Volume = 1.0f;
        IsMusicPlaying = true;
    }
}
