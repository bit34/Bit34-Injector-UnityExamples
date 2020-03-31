public class SettingsDummy : ISettings
{
    //  MEMBERS
    public float SoundVolume { get { return 0; } }
    public bool IsMusicPlaying { get { return false; } }

    //  METHODS
    public void SetSoundVolume(float value) { }

    public void ToggleMusic() { }
}
