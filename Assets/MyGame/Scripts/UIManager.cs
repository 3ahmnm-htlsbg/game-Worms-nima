using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
   public void LoadGame()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void LoadControls()
    {
        SceneManager.LoadScene("Controls");
    }
}
