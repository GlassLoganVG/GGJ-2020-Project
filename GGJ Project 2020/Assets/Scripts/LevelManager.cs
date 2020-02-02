using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class LevelManager : MonoBehaviour
{

    private void Awake()
    {
        if (!PlayerPrefs.HasKey("Level Select"))
        {
            PlayerPrefs.SetInt("Level Select", 0);
            PlayerPrefs.SetFloat("BGM Volume", 0.7f);
            PlayerPrefs.SetFloat("SFX Volume", 0.7f);
            PlayerPrefs.Save();
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
