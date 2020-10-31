using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class calabouge : MonoBehaviour
{
    [Range(0, 0.1f)]
     public float vitesseDeplacement = 0.01f;

    Rigidbody2D corpsdelabouboule;

    // Start is called before the first frame update
    void Start()
    {
        corpsdelabouboule = GetComponent<RigidBody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        #region C'EST ICI QU'ON RENTRE LES TOUCHES POUR BOUGER LE PETIT ROND
        // GAUCHE DROITE
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //transform.position = new Vector3(transform.position.x - vitesseDeplacement, transform.position.y);
            corpsdelabouboule.AddForce(new Vector2 (-1,0));
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = new Vector3(transform.position.x + vitesseDeplacement, transform.position.y);
        }

        //HAUT BAS
        if (Input.GetKey(KeyCode.UpArrow)) //HAUT
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + vitesseDeplacement);
        }

        if (Input.GetKey(KeyCode.DownArrow)) //BAS
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - vitesseDeplacement);
        }
        #endregion
    }
}