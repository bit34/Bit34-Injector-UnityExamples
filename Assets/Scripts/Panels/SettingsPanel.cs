using UnityEngine;
using UnityEngine.UI;

public class SettingsPanel : MonoBehaviour
{
	//	MEMBERS
    //      For editor
    public Button volumeUpButton;
    public Button volumeDownButton;
    public Button toggleMusicButton;
    //      For injection
	[Inject]
    public ISettings _settings;
	
    //  METHODS
    private void Start()
    {
        volumeUpButton.onClick.AddListener(OnVolumeUpButtonClick);
        volumeDownButton.onClick.AddListener(OnVolumeDownButtonClick);
        toggleMusicButton.onClick.AddListener(OnToggleMusicButtonClick);
    }

    private void OnVolumeUpButtonClick()
    {
        _settings.SetSoundVolume(Mathf.Min(_settings.SoundVolume + 0.1f, 1.0f));
    }

    private void OnVolumeDownButtonClick()
    {
        _settings.SetSoundVolume(Mathf.Max(_settings.SoundVolume - 0.1f, 0.0f));
    }

    private void OnToggleMusicButtonClick()
    {
        _settings.ToggleMusic();
    }
}
