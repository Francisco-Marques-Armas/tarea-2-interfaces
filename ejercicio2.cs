using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Nombre del cubo: " + GameObject.FindGameObjectsWithTag("BasicCube")[0].name);
        Debug.Log("Nombre del cilindro: " + GameObject.FindGameObjectsWithTag("BasicCylinder")[0].name);
        Debug.Log("Nombre de la esfera: " + GameObject.FindGameObjectsWithTag("BasicSphere")[0].name);
        Debug.Log("Nombre del plano: " + GameObject.FindGameObjectsWithTag("BasicPlane")[0].name);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
