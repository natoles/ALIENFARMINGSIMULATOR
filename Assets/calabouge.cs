using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class calabouge : MonoBehaviour
{
    [Range(0.5f, 3)]
     public float vitesseDeplacement = 1;
    
    [Range(150, 500)]
     public float hauteursaut = 250;

    Rigidbody2D corpsdelabouboule;

    // Start is called before the first frame update
    void Start()
    {
        corpsdelabouboule = GetComponent<Rigidbody2D>();
        hauteursaut = 250;
    }

    // Update is called once per frame
    void Update()
    {
        #region C'EST ICI QU'ON RENTRE LES TOUCHES POUR BOUGER LE PETIT ROND
        // GAUCHE DROITE
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            corpsdelabouboule.AddForce(new Vector2 (-vitesseDeplacement,0));
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            corpsdelabouboule.AddForce(new Vector2 (vitesseDeplacement,0));
        }

        //HAUT BAS
        if (Input.GetKeyDown(KeyCode.UpArrow)) //HAUT
        {
            corpsdelabouboule.AddForce(new Vector2 (0,hauteursaut));
        }
        #endregion
    }
}