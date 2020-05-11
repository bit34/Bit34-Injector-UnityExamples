using UnityEngine;

public class Game2Controller : MonoBehaviour
{
    //  MEMBERS
#pragma warning disable 0649
    [SerializeField] private Game2SettingsPanel _settingsPanel;
    [SerializeField] private Game2MusicPlayerPanel _musicPlayerPanel;
#pragma warning restore 0649
    private Game2Settings _settings;
	
    //  METHODS
	void Awake ()
	{
        //  Load settings
        _settings = new Game2Settings();
        _settings.Volume = 0.5f;
        _settings.IsMusicPlaying = true;

        //  Set values to panels
        _settingsPanel.InjectValues(_settings);
        _musicPlayerPanel.InjectValues(_settings);
	}
}
