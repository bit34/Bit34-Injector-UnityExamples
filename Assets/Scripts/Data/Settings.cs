public class Settings : ISettings
{
    //  MEMBERS
    public float SoundVolume { get; protected set; }
    public bool IsMusicPlaying { get; protected set; }
    
    //  CONSTRUCTOR
    public Settings()
    {
        SoundVolume = 1;
        IsMusicPlaying = true;
    }
    
    // METHODS
    public void SetSoundVolume(float value)
    {
        SoundVolume = value;
    }
    
    public void ToggleMusic()
    {
        IsMusicPlaying = !IsMusicPlaying;
    }

}
