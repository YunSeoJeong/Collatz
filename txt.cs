using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class txt : MonoBehaviour
{
    string fullpth = "Assets/Texts/text";

    // Start is called before the first frame update
    void Start()
    {
        StreamWriter sw = new StreamWriter(fullpth + ".txt");

        

        for(int i = 1; i < 10000; i++)
        {
            int n = i;
            sw.Write(n + ": ");
            while(n > 1)
            {
                if(n % 2 == 0)
                {
                    n /= 2;
                }
                else
                {
                    n = 3 * n + 1;
                }
                sw.Write(n + " ");
            }
            sw.WriteLine("");
        }

        sw.Flush();
        sw.Close();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
