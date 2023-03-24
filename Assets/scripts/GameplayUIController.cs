using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameplayUIController : MonoBehaviour
{
    // Start is called before the first frame update
   public void restartGame()
    {
        SceneManager.LoadScene("Gameplay");
    }

   public void Home()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
