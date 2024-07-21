using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NascondiFoglie : MonoBehaviour
{
    public GameObject prefabFoglie;

    public void NascondiOggetto()
    {
        // Controlla se prefabFoglie � attivo
        if (prefabFoglie.activeSelf)
        {
            // Se � attivo, disattivalo
            prefabFoglie.SetActive(false);
        }
        else
        {
            // Se � disattivo, attivalo
            prefabFoglie.SetActive(true);
        }

        /*
        prefabFoglie.SetActive(false);
        */

    }

}
