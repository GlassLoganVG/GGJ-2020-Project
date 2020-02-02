using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    GameObject MainMenu;
    GameObject Settings;
    GameObject OptionsHold;
    GameObject CreditsHold;
    GameObject MoreCreditsHold;

    public Slider bgmSlider;
    public Slider sfxSlider;

    void Awake()
    {
        GameObject.Find("__bgm").GetComponent<BGM_Manager>().musicFiles[0].source.volume = PlayerPrefs.GetFloat("BGM Volume");
        GameObject.Find("__sfx").GetComponent<SFX_Manager>().soundFiles[0].source.volume = PlayerPrefs.GetFloat("SFX Volume");
        GameObject.Find("__bgm").GetComponent<BGM_Manager>().PlayMusic("Title Theme");
    }
    // Start is called before the first frame update
    void Start()
    {
        MainMenu = GameObject.Find("Main Menu");
        Settings = GameObject.Find("Settings");
        OptionsHold = GameObject.Find("Options Holder");
        CreditsHold = GameObject.Find("Credits Holder");
        MoreCreditsHold = GameObject.Find("More Credits Holder");

        bgmSlider.value = PlayerPrefs.GetFloat("BGM Volume", 0.7f);
        sfxSlider.value = PlayerPrefs.GetFloat("SFX Volume", 0.7f);

        Settings.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        GameObject.Find("__bgm").GetComponent<BGM_Manager>().StopMusic("Title Theme");
        GameObject.Find("__sfx").GetComponent<SFX_Manager>().PlaySound("Confirm");
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
    }

    public void ActivateMainMenu()
    {
        GameObject.Find("__sfx").GetComponent<SFX_Manager>().PlaySound("Back");
        Settings.SetActive(false);
        MainMenu.SetActive(true);
    }

    public void ActivateSettings()
    {
        GameObject.Find("__sfx").GetComponent<SFX_Manager>().PlaySound("Confirm");
        MainMenu.SetActive(false);
        Settings.SetActive(true);
        OptionsHold.SetActive(true);

        bgmSlider.value = PlayerPrefs.GetFloat("BGM Volume");
        sfxSlider.value = PlayerPrefs.GetFloat("SFX Volume");

        CreditsHold.SetActive(false);
        MoreCreditsHold.SetActive(false);
    }

    public void ActivateCredits()
    {
        GameObject.Find("__sfx").GetComponent<SFX_Manager>().PlaySound("Confirm");
        OptionsHold.SetActive(false);
        CreditsHold.SetActive(true);
        MoreCreditsHold.SetActive(false);
    }

    public void ActivateMoreCredits()
    {
        GameObject.Find("__sfx").GetComponent<SFX_Manager>().PlaySound("Confirm");
        OptionsHold.SetActive(false);
        CreditsHold.SetActive(false);
        MoreCreditsHold.SetActive(true);
    }

    public void SetBGMVolume()
    {
        PlayerPrefs.SetFloat("BGM Volume", bgmSlider.value);
        foreach (AudioFile bgm in GameObject.Find("__bgm").GetComponent<BGM_Manager>().musicFiles)
        {
            bgm.source.volume = PlayerPrefs.GetFloat("BGM Volume");
        }
    }

    public void SetSFXVolume()
    {
        PlayerPrefs.SetFloat("SFX Volume", sfxSlider.value);
        foreach (AudioFile sfx in GameObject.Find("__sfx").GetComponent<SFX_Manager>().soundFiles)
        {
            sfx.source.volume = PlayerPrefs.GetFloat("SFX Volume");
        }
    }
}
