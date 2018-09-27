using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eynolmao : MonoBehaviour {

    public bool IsChecked;
    public int MyIntValue = 10;

	// Use this for initialization
	void Start ()
    {
        if (IsChecked == true)
        {
            Debug.Log("it's true");
        }
        else
        {
            Debug.Log("NO! eis nowt");
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
       
        // == lika med
        // != inte lika med
        // <= mindre eller lika med
        // >= större än eller lika med
        // > större än
        // < mindre än
        // && och (and)
        // || Eller (or) [alt gr + <]

        //if (MyIntValue >= 10)
        //{ 
        //    if(IsChecked == true)
        //    {
        //    print("måndag");

        //    }
        //}
        //else if (MyIntValue == 9)
        //{
        //    print("tisdag");
        //}
        //else
        //{
        //    print("okänd dag");
        //}
        //if (Input.GetKeyDown(KeyCode.R))
        //{
        //    print("Reloading");
        //}
        //if (Input.GetKeyDown(KeyCode.Q))
        //{
        //    //0 1 2 3 4 5 6 7 8 9 
        //    //Random.RandomRange (0, 1); nej.
        //    MyIntValue = Random.Range(0, 10);
        //    // 0.032f, 10.000f
        //    print(Random.Range(0f, 10f));
        //    print("Lean left");
        
        //}

	}
}
