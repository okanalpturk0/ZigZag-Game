using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class MenuScript : MonoBehaviour
{
    
    public void Play()
    {

        SceneManager.LoadScene(1);
        Points.points = 0;
    }
    public void Quit()
    {
        Application.Quit();
    }

    void Start()
    {
       
    }
}
