using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreaQualcosa : MonoBehaviour
{
    public Qualcosa[] qualcose;

    public Text nomeQualcosa;
    GameObject nuovoQulcosa;

    public Transform postazione;


    public void CreaQualcose(int numeroQualcosa)
    {
        Destroy(nuovoQulcosa);

        nomeQualcosa.text = qualcose[numeroQualcosa].nomeQualcosa;
        nuovoQulcosa = Instantiate(qualcose[numeroQualcosa].prefabQualcosa);

        nuovoQulcosa.transform.position = postazione.position;
    }

}
