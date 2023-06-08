using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class FallowCamera : MonoBehaviour
{
    public Transform ballLocation;
    Vector3 differance;

    void Start()
    {
        differance = transform.position - ballLocation.position;
    }

    void Update()
    {
        if(BallBehavior.isFallDown == false)
        {
            transform.position = ballLocation.position + differance;
        }
        else if (BallBehavior.isFallDown == true)
        {
            StartCoroutine(ie());
            
        }
    }

    IEnumerator ie()
    {
        yield return new WaitForSecondsRealtime(1.5f);
        SceneManager.LoadScene(0);
    }
}
