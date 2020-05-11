using UnityEngine;
using UnityEngine.UI;

public class Game1SettingsPanel : MonoBehaviour
{
	//	MEMBERS
    public float Volume;
    public bool IsMusicPlaying;
    public Button VolumeUpButton;
    public Button VolumeDownButton;
    public Button ToggleMusicButton;
	
    //  METHODS
    private void Start()
    {
        VolumeUpButton.onClick.AddListener(OnVolumeUpButtonClick);
        VolumeDownButton.onClick.AddListener(OnVolumeDownButtonClick);
        ToggleMusicButton.onClick.AddListener(OnToggleMusicButtonClick);
    }

    private void OnVolumeUpButtonClick()
    {
        Volume = Mathf.Min(Volume + 0.1f, 1.0f);
    }

    private void OnVolumeDownButtonClick()
    {
        Volume = Mathf.Max(Volume - 0.1f, 0.0f);
    }

    private void OnToggleMusicButtonClick()
    {
        IsMusicPlaying = !IsMusicPlaying;
    }
}
