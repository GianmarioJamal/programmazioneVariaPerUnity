using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NascondiFoglie : MonoBehaviour
{
    public GameObject prefabFoglie;

    public void NascondiOggetto()
    {
        // Controlla se prefabFoglie è attivo
        if (prefabFoglie.activeSelf)
        {
            // Se è attivo, disattivalo
            prefabFoglie.SetActive(false);
        }
        else
        {
            // Se è disattivo, attivalo
            prefabFoglie.SetActive(true);
        }

        /*
        prefabFoglie.SetActive(false);
        */

    }

}
