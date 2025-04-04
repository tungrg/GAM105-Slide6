using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class MusicController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Slider musicSlider;
    public Toggle musicToggle;
    void Start()
    {
        //Neu da luu lai roi
        if (PlayerPrefs.HasKey("volBucket"))
        {
            LoadVolume();
        }
        //Neu chua thi cho am luong la 50%
        else
        {
            PlayerPrefs.SetFloat("volBucket", 0.5f);
            LoadVolume();
        }
    }
    //thay doi volume khi chay game (runtime)
    public void SetVolume()
    {
        AudioListener.volume = musicSlider.value;
        SaveVolume();
    }
    //Luu gia tri volume lai
    public void SaveVolume()
    {
        PlayerPrefs.SetFloat("volBucket", musicSlider.value);
    }
    //Lay gia tri volume ra
    public void LoadVolume()
    {
        musicSlider.value = PlayerPrefs.GetFloat("volBucket");
        SetVolume();
    }
    public void MuteVolume()
    {
        if (musicToggle.isOn) {
            AudioListener.volume = 0;
        }
        else
        {
            SetVolume();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
