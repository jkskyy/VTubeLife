using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class MenuLogic : MonoBehaviour
{
    public GameObject play, options, exit, mainMenu, playMenu;
    public DataPersistenceManager dataPersistenceManager;
    public LoadingScene loadingScene;
    public AudioMixer audioMixer;

    void Start()
    {
        float vol = PlayerPrefs.GetFloat("vol");
        if (vol != 0) audioMixer.SetFloat("volume", vol);
    }
    
    public void Play()
    {
        mainMenu.SetActive(false);
        playMenu.SetActive(true);
    }

    public void Settings()
    {
        SceneManager.LoadScene("Settings", LoadSceneMode.Single);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void NewGame(int sceneId)
    {
        loadingScene.LoadScene(sceneId);
        dataPersistenceManager.NewGame();
    }
    public void LoadGame(int sceneId)
    {
        loadingScene.LoadScene(sceneId);
        dataPersistenceManager.LoadGame();
    }
    public void Back()
    {
        mainMenu.SetActive(true);
        playMenu.SetActive(false);
    }
}
