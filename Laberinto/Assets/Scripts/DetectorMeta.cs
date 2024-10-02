using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DetectorMeta : MonoBehaviour
{
    [SerializeField]
    GameObject pantallaFinal;

    [SerializeField]
    TextMeshProUGUI textLabelTime;

    public float tiempoDePartida = 0.0f;
    bool estaJugando = true;

    void update()
    {
        if (estaJugando == true)
        {
            tiempoDePartida = tiempoDePartida + Time.deltaTime;
        }

    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            pantallaFinal.SetActive(true);
            collider.GetComponent<MovPlayer>().enabled = false;
            bool estaJugando = false;
            textLabelTime.text = tiempoDePartida.ToString();

        }
    }
}
