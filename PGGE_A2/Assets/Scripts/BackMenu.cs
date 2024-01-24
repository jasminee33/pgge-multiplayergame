using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackMenu : MonoBehaviour
{
    //creates a function that takes a variable name of the scene
    public void LoadScene(string scene)
    {
        //specifing to load scene named "Menu" using unity scene manager
        SceneManager.LoadScene("Menu");
    }
}
