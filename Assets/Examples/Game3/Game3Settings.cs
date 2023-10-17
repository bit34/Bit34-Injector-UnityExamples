public class Game3Settings : IGame3Settings
{
	//	MEMBERS
    public float Volume { get; set; }
    public bool IsMusicPlaying { get; set; }

    //  CONSTRUCTORS
    public Game3Settings()
    {
        Volume = 1.0f;
        IsMusicPlaying = true;
    }
}
