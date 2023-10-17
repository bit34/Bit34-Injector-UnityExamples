using UnityEngine;
using UnityEngine.UI;

public class Game3MusicPlayerPanel : MonoBehaviour
{
	//	MEMBERS
#pragma warning disable 0649
    [SerializeField] private Text _volumeValueText;
    [SerializeField] private Text _musicStateValueText;
    [Inject] private IGame3Settings _settings;
#pragma warning restore 0649

    //  METHODS
    private void Update ()
	{
        _volumeValueText.text = _settings.Volume.ToString("0.0");
        _musicStateValueText.text = _settings.IsMusicPlaying.ToString();
    }
}
