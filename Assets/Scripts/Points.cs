using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Points : MonoBehaviour
{
    public static int points;
    public Text pointsText;
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        pointsText.text = points.ToString();
    }
}
