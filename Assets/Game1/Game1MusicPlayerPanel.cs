using UnityEngine;
using UnityEngine.UI;

public class Game1MusicPlayerPanel : MonoBehaviour
{
	//	MEMBERS
    public Text VolumeValueText;
    public Text MusicStateValueText;
    public Game1SettingsPanel SettingsPanel;

    //  METHODS
    private void Update ()
	{
        VolumeValueText.text = SettingsPanel.Volume.ToString("0.0");
        MusicStateValueText.text = SettingsPanel.IsMusicPlaying.ToString();
    }
}
