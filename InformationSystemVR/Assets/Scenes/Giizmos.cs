using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Giizmos : MonoBehaviour
{
    [SerializeField]
    public float radio;
    public bool Activate= true;
    public bool color = true;

    void OnDrawGizmosSelected()
    {
        // Draws a 5 unit long red line in front of the object
        if(color)
            Gizmos.color = Color.green;
        else
            Gizmos.color = Color.red;
        if(Activate)
            Gizmos.DrawWireSphere(transform.position, radio );
    }
}
