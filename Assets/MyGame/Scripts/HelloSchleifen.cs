using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloSchleifen : MonoBehaviour
{


    public int[,] array = new int [5,2];
  
    void Start()
    {
        
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Debug.Log(array[i, j]);
            }
        }
    }
}
