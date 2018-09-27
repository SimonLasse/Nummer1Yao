using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{

    //public = syns i unity.
    public int testInt;
    public float testFloat;
    public double testDouble;
    public bool testBool;
    public char testChar;
    public string testString;
    //string är flera cha
    // char är 1 charactär
    // bool är ja eller nej
    // int är ett heltal
    // Double är ett längre float
    // float är ett nummer med decimaler
    //Debug.log och print är samma sak
    public string scentence1;
    public string scentence2;
    public string scentence3;
    public float number;
    public int @base;
    [Range(1, 360)]
    public float angle;
    public float pieces;
    public string usernamne;
    public float radius;

    void TestFunktion()
    {

        Debug.Log("detta är big gaie()");
    }
    // Use this for initialization
    void Start()
    {
        Uppgift1();
        Uppgift2();
        Uppgift3();
        Uppgift4();
        Uppgift5();
        Uppgift5a();
        Uppgift6();
        Uppgift7();
        Uppgift8();
    }




    // Update is called once per frame
    void Update()
    {
        //Debug.Log("hej");
    }

    void Uppgift1()
    {
        Debug.Log("(963*421)");
        Debug.Log(string.Format(
            "svaret på (963*421) - (175463 / 87) är {0}"
            , (963f * 421f) - (175463f / 87f)));
    }

    void Uppgift2()
    {
        Debug.Log(scentence1);
        Debug.Log(scentence2);
        Debug.Log(scentence3);
    }

    void Uppgift3()
    {
        Debug.Log(string.Format("Hej {0} upphöjt med 2 blir {1}  roten ur {0} blir {2}"
            , number, Mathf.Pow(number, 2), Mathf.Sqrt(number)));
    }
    void Uppgift4()
    {
        Debug.Log(string.Format("arean på en triangel med höjden 8 är {0}", @base *8 /2 ));

    }

    void Uppgift5()
    {
        Debug.Log(string.Format("Om man delar tårtan i bitar med vinkeln {0} så kan man få {1} hela bitar", 
            angle, (360 / angle )));

    }

    void Uppgift5a()
    {
        Debug.Log(string.Format("om du vill få {0} pecies så får du vinkeln {1} på varje bit", pieces, (360 / pieces)));

    }
    void Uppgift6()
    {
        Debug.Log(string.Format("Boss {0} of doom",usernamne));
    
    }
    void Uppgift7()
    {
        Debug.Log(string.Format("om du har en radie på {0} så är volymen på 2978 klot {1}",
            radius,(4*3.14 * Mathf.Pow(radius,2) /3) *2978));

    }
    void Uppgift8()
    {


    }

}
