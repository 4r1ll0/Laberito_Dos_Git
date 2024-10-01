using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPlayer : MonoBehaviour
{
    public float movientoEjeX;
    public float movientoEjeY;
    public float movientoEjeZ;

    public float speed;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movientoEjeX = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        movientoEjeZ = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        transform.Translate(movientoEjeX,movientoEjeY,movientoEjeZ);

    }
}
