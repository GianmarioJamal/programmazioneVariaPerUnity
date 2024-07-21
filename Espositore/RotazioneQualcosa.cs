using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotazioneQualcosa : MonoBehaviour
{
    public float rotazioneVelocita = 10f;
    private GameObject[] qualcosaDaRuotare;


    // Update is called once per frame
    void Update()
    {
        qualcosaDaRuotare = GameObject.FindGameObjectsWithTag("Rotabile");
        
    }

    public void RuotaQualcose()
    {
        foreach (GameObject qualcose in qualcosaDaRuotare)
        {
            qualcose.transform.Rotate(Vector3.up * rotazioneVelocita);
        }
    }
}
