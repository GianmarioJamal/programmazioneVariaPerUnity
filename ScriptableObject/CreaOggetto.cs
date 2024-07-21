using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CreaOggetto : MonoBehaviour
{
    public Oggetto[] oggetti;

    public TMP_Text nomeOggetto;
    GameObject nuovoOggetto;
    public Transform posizione;

    public void CreaOggetti(int numeroOggetto)
    {
        Destroy(nuovoOggetto);

        nomeOggetto.text = oggetti[numeroOggetto].nomeOggetto;
        nuovoOggetto = Instantiate(oggetti[numeroOggetto].prefabOggetto);

        nuovoOggetto.transform.position = posizione.position;

    }

}
