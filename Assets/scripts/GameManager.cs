using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{

    public static GameManager Instance;
    private string clicked;

    public string getInstance()
    {
        return clicked;
    }
    public void setClicked(string Clicked)
    {
        clicked = Clicked;
    }

    [SerializeField]
    public GameObject[] players;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnLevelFinishedLoading;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnLevelFinishedLoading;
    }

    void OnLevelFinishedLoading(Scene scene, LoadSceneMode mode)
    {
        if(scene.name == "Gameplay")
        {
            if (clicked == "Button1")
                Instantiate(players[0]);
            if (clicked == "Button2")
                Instantiate(players[1]);
        }
    }

}
