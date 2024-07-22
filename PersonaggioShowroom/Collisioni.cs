using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisioni : MonoBehaviour
{
    public GameManager gameManager;

    //public GameObject prefabSfera;

    private void Start()
    {
        /*for (int i = 0; i < 5; i++)
        {
            GameObject nuovaSfera = Instantiate(prefabSfera); 

            float asseX = Random.Range(-10, 10);
            float asseY = Random.Range(-10, 10);
            float asseZ = Random.Range(-10, 10);
            nuovaSfera.transform.position = new Vector3(asseX, asseY, asseZ);
            
        }*/

        
    }
    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Nemico")
        {
            gameManager.IncrementaPunteggio();
            Destroy(other.gameObject);
        }
    }
}
