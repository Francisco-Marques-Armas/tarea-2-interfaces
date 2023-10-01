using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3 : MonoBehaviour
{
    [SerializeField] Vector3 vector1;
    [SerializeField] Vector3 vector2;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Magnitud Vector1: 3 (Es un Vector3)");
        Debug.Log("Magnitud Vector2: 3 (Es un Vector3)");
        Debug.Log("Ángulo entre ellos: " + Vector3.Angle(vector1, vector2));
        Debug.Log("Distancia entre ellos: " + Vector3.Distance(vector1, vector2));
        float biggestY = 0;
        bool vecOneBigger = true;
        if (vector1.y > vector2.y)
        {
            biggestY = vector1.y;
        }
        else
        {
            biggestY = vector2.y;
            vecOneBigger = false;
        }
        if (vecOneBigger)  {
            Debug.Log("El vector1 tiene el mayor valor de Y: " + biggestY);
        }
        else {
            Debug.Log("El vector2 tiene el mayor valor de Y: " + biggestY);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
