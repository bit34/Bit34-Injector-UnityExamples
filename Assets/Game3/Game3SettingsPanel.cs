using UnityEngine;
using UnityEngine.UI;

public class Game3SettingsPanel : MonoBehaviour
{
	//	MEMBERS
#pragma warning disable 0649
    [SerializeField] private Button _volumeUpButton;
    [SerializeField] private Button _volumeDownButton;
    [SerializeField] private Button _toggleMusicButton;
    [Inject] private Game3Settings _settings;
#pragma warning restore 0649
	
    //  METHODS
    public void InitPanel(Game3Settings settings)
    {
        _settings = settings;
    }

    private void Start()
    {
        _volumeUpButton.onClick.AddListener(OnVolumeUpButtonClick);
        _volumeDownButton.onClick.AddListener(OnVolumeDownButtonClick);
        _toggleMusicButton.onClick.AddListener(OnToggleMusicButtonClick);
    }

    private void OnVolumeUpButtonClick()
    {
        _settings.Volume = Mathf.Min(_settings.Volume + 0.1f, 1.0f);
    }

    private void OnVolumeDownButtonClick()
    {
        _settings.Volume = Mathf.Max(_settings.Volume - 0.1f, 0.0f);
    }

    private void OnToggleMusicButtonClick()
    {
        _settings.IsMusicPlaying = !_settings.IsMusicPlaying;
    }
}
