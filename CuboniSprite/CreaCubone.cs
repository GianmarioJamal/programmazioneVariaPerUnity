using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreaCubone : MonoBehaviour
{
    public Cubone[] cuboni;

    public Text nomeCubone;
    public Image spriteCubone;
    public Transform posizioneCubone;

    GameObject nuovoCubone;

    public void CreaCuboni(int numeroCuboni)
    {

        Destroy(nuovoCubone);
        nomeCubone.text = cuboni[numeroCuboni].nomeCubone;
        nuovoCubone = Instantiate(cuboni[numeroCuboni].prefabCubone);
        spriteCubone.sprite = cuboni[numeroCuboni].spriteCubone; 

        nuovoCubone.transform.position = posizioneCubone.position; 

    }
}
