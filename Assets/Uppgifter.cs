using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uppgifter : MonoBehaviour
{


    public float  UserValue = 2;
    public int DiceValue = 10;

    // Use this for initialization
    void Start()
    {
    }
    void Uppgift1()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            UserValue = UserValue += 2;
            Debug.Log(string.Format("värdet {0}", UserValue));
        }

        
    }
void Uppgift12()
 {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            UserValue = UserValue /= 2;
            Debug.Log(string.Format("värdet {0}", UserValue));
        }
       

 }
    void Uppgift123()
{
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log(string.Format("nuvarande värde är {0}", UserValue));
        }

}
    void Uppgift2()
    {
        
        if (Input.GetKeyDown(KeyCode.Q))
        {
            //if else(Debug.Log(string.Format("{0}",DiceValue )));

            Debug.Log(string.Format("{0}", Random.Range(0, 7)));
        }
    }


    // Update is called once per frame
    void Update()
    {
        Uppgift1();
        Uppgift12();
        Uppgift123();
        Uppgift2();
    }
}
