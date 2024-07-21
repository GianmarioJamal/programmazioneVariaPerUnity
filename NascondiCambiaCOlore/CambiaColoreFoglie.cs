using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiaColoreFoglie : MonoBehaviour
{
    public GameObject prefabFoglie;
    private MeshRenderer meshFoglie;

    private void Start()
    {
        meshFoglie = prefabFoglie.GetComponent<MeshRenderer>();
    }

    public void CambiaFoglie()
    {
        meshFoglie.material.color = new Color(Random.value, Random.value, Random.value);
    }

}
