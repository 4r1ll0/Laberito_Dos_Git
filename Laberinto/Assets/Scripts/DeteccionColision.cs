using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeteccionColision : MonoBehaviour
{
    [SerializeField]
    Material materialPorDefecto;
    
    [SerializeField]
    Material materialChoque;

    bool paredRoja = false;

    float tiempoEnRojo = 5f;

    private void Update()
    {
        if (paredRoja == true)
        {
            tiempoEnRojo = tiempoEnRojo - Time.deltaTime;
            if (tiempoEnRojo < 0.0f)
            {
                gameObject.GetComponent<MeshRenderer>().material = materialPorDefecto;
                paredRoja=false;
                tiempoEnRojo = 5f;
            }
        }
    }

    private void OnCollisionEnter (Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            gameObject.GetComponent<MeshRenderer>().material = materialChoque;
            paredRoja = true;
        }
    }
    
}
