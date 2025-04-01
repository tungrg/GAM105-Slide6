using UnityEngine;
using UnityEngine.UI;

public class MusicSlider : MonoBehaviour
{
    public Slider slider;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (PlayerPrefs.HasKey("soundVol"))
        {
            LoadVolume();
        } else
        {
            PlayerPrefs.SetFloat("soundVol", 0.5f);
            LoadVolume();
        }
    }
    public void SetVolume()
    {
        AudioListener.volume = slider.value;

        
    }
    public void SaveVolume()
    {
        PlayerPrefs.SetFloat("soundVol", slider.value);
        PlayerPrefs.Save();
    }
    public void LoadVolume()
    {
        PlayerPrefs.SetFloat("soundVol", slider.value);
    }

    // Update is called once per frame
    void Update()
    {
        //AudioListener.volume = slider.value;
    }
}
