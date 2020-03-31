using UnityEngine;
using UnityEngine.UI;

public class SoundPlayerPanel : MonoBehaviour
{
	//	MEMBERS
    //      For editor
    public Text SoundVolumeText;
    public Text MusicStateText;
    //      For injection
	[Inject]
    public IReadonlySettings _settings;

    //  METHODS
    private void Update ()
	{
        SoundVolumeText.text = "Sound Volume:" + _settings.SoundVolume.ToString("0.0");
        MusicStateText.text = "Music playing:" + _settings.IsMusicPlaying;
    }
}
