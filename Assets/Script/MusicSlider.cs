using UnityEngine;
using UnityEngine.UI;

public class MusicSlider : MonoBehaviour
{
    public Slider slider;
    public Toggle toggle;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (PlayerPrefs.HasKey("soundVol"))
        {
            LoadVolume();
        }
        else
        {
            PlayerPrefs.SetFloat("soundVol", 0.5f);
            LoadVolume();
        }
    }
    public void SetVolume()
    {
        AudioListener.volume = slider.value;
        SaveVolume();
    }
    public void SaveVolume()
    {
        PlayerPrefs.SetFloat("soundVol", slider.value);
    }
    public void LoadVolume()
    {
        slider.value = PlayerPrefs.GetFloat("soundVol");
    }
    public void SwitchOnOff()
    {
        if(toggle.isOn)
        {
            AudioListener.volume = slider.value;
        }
        else
        {
            AudioListener.volume = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
