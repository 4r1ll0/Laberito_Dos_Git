using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion : MonoBehaviour
{
    public float speed = 10f;

    void Update()
    {
        transform.Rotate(0f, 10f * Time.deltaTime * speed, 0f);
    }
}
