using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collider : MonoBehaviour
{
    
    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Mein Spieler kolidiert mit etwas!");
    }

 
}