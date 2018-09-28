using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditions : MonoBehaviour {
    // ! = inte lika med

    // == lika med

    // > större än

    // < mindre än

    // >= större eller lika med

    // <= mindre eller lika med

    // && och

    // || eller

    //(Input.GetKey(KeyCode.E))



    public bool ifbool;

    public int uservalue;

    public int Dicevalue = 10;

    public int DragonHP = 100;

    public int PlayerHP = 100;

    public float DragonDamage;

    bool start = false;

    public int superdragon;

    public int MinDamage;

    public int MaxDamage;

    public int Guessvalue;

    public int nasta;


    // Use this for initialization
    void Start() {

        Uppgift3();
        Guessvalue = Random.Range(0, 101);
        

        

    }

    // Update is called once per frame
    void Update() {


        //Uppgift1
        if (Input.GetKey(KeyCode.E))
        {
            print("Du E");
            Random.Range(0, 10);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            print(uservalue += 2);

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {

            print(uservalue /= 2);

        }
        if (Input.GetKey(KeyCode.UpArrow))
        {

            print(uservalue = 0);

        }
        //Uppgift2
        if (Input.GetKey(KeyCode.R))
        {

            Dicevalue += (Random.Range(0, 7)) - (Random.Range(0, 7));
            print(Dicevalue);


        }
        


        //if (value >= 5)
        //{
        //    print("hejsan");





        //}

        //else if (value == 4)
        //{ print("mada mada");




        //}

        //else if (value == 3)
        //{ print("lol");




        //}

        //else
        //{ print("tough luck");







    }

    void Uppgift3()
    {
        if (start == false)
        {
            print("Starting!");
            superdragon = Random.Range(0, 11);
            PlayerHP = 100;
            DragonHP = Random.Range(100, 151);
            Guessvalue = 50;
            nasta = Random.Range(0, 101);
            if (superdragon >= 0)
            {
                DragonHP *= 2;
            }
            start = true;
        }
        

        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Uppgift 3");
            DragonDamage = Random.Range(1, 3);
            if (DragonDamage == 1)
            {
                
                PlayerHP = PlayerHP - Random.Range(10, 21);
                
            }
            DragonHP = DragonHP - Random.Range(5, 26);
            if (DragonHP <= 0)
            {
                print("Player Wins");
           
            
                if (PlayerHP <= 0)
                {

                    print("Dragon Wins");

                }
                print(string.Format(
                    "DragonHP:" + DragonHP));

                print(string.Format(
                    "PlayerHP:" + PlayerHP));
            }
            
        }
        Debug.Log("Uppgift4");
    }
    int NextValue;
    void Uppgift5()
    {
        NextValue = Random.Range(0, 101);
        if (Input.GetKey(KeyCode.Y))
        {
            if (Guessvalue >= NextValue)
            {
                //print(NextValue == );

            } 
        }
        if (Input.GetKey(KeyCode.X))
        {
            print(string.Format("Lägre"));

        }






    }
}
