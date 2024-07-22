using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
    public float velocità = 3f;
   
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * velocità * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.back * velocità * Time.deltaTime);
        }


        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * velocità * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * velocità * Time.deltaTime);
        }
    }
}
