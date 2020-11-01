using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class etoiles : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    // ICI C'EST POUR SAVOIR SI ON TOUCHE L'ETOILES ET DONC QU'ON A GAGNE BISOUS
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("BIENJOUE");
    }

    private void OnCollisionEnter(Collision testcollision)
    {
        Debug.Log("BIENJOUE");
    }

}
