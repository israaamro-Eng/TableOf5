using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultyTable : MonoBehaviour
{
    // Start is called before the first frame update
     void Start()
    {
        for(int x=1 ; x <=10 ; x++)
        {
            int five=5;
            int theMulti;
            theMulti= Multiply(five,x);
            Debug.Log("5" + "*" + x + "=" + theMulti);
        }
        
    }

     int Multiply(int num1 , int num2) 
     {
         int theResult;
         theResult= num1 * num2;
         return theResult;
     }
}
