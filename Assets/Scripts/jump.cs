using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * 400f);
    }
}
