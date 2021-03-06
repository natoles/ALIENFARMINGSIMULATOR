﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class calabouge : MonoBehaviour
{
    [Range(0.5f, 3)]
     public float vitesseDeplacement;
    
    [Range(150, 500)]
     public float hauteursaut;

    Rigidbody2D corpsdelabouboule;

    public GameObject texteCESTWIN;

    // Start is called before the first frame update
    void Start()
    {
        texteCESTWIN.SetActive(false);

        corpsdelabouboule = GetComponent<Rigidbody2D>();
        hauteursaut = 450;
        vitesseDeplacement = 2.1f;
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

   // ICI C'EST POUR SAVOIR SI ON TOUCHE L'ETOILES ET DONC QU'ON A GAGNE BISOUS
    private void OnTriggerEnter2D(Collider2D catouche)
    {
        if (catouche.gameObject.name == "etoiles")
        {
           texteCESTWIN.SetActive(true);
           Time.timeScale = 0;
        }
    }
}