using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class TouchShows : MonoBehaviour
{
    #region AllParams
    public Text ShowText;
    string BoxFallOnPlane = "Box Fall on Plane";
    string BoxFallOnWall = "Box Fall on Wall";
    float _timerToNullText = 0;
    #endregion
    private void Update()
    {
        if (_timerToNullText > 0) _timerToNullText -= 0.04f;
        else ShowText.text = "";

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Wall>() != null)
        {
            _timerToNullText = 0;
            ShowText.text = BoxFallOnWall;
            SpawnText();
        }else if (collision.gameObject.GetComponent<Plane>() != null)
        {
            _timerToNullText = 0;
            ShowText.text = BoxFallOnPlane;
            SpawnText();
        }
    }
    public void SpawnText()
    {
        _timerToNullText = 10;
    }

}
