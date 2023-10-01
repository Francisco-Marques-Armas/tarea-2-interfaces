using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Posición de la esfera: " + GameObject.FindGameObjectsWithTag("BasicSphere")[0].transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
