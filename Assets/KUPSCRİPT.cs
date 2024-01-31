using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KUPSCRİPT : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //for(int  i = 0; i < 10; i++)
        //{
        //    GameObject go= GameObject.CreatePrimitive(PrimitiveType.Cube);
        //    go.name = "MyCube";
        //    go.transform.position = new Vector3(i,0,0);
        //    go.transform.localScale = new Vector3(1,1,1);
        //}
        //for (int i = 1; i < 10; i++)
        //{
        //    GameObject go = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //    go.name = "MyCube";
        //    go.transform.position = new Vector3(0, 0, i);
        //    go.transform.localScale = new Vector3(1, 1, 1);
        //}
        //for (int i = 1; i < 10; i++)
        //{
        //    GameObject go = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //    go.name = "MyCube";
        //    go.transform.position = new Vector3(i, 0, 10-1);
        //    go.transform.localScale = new Vector3(1, 1, 1);
        //}
        //for (int i = 1; i < 10; i++)
        //{
        //    GameObject go = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //    go.name = "MyCube";
        //    go.transform.position = new Vector3(10-1, 0, i);
        //    go.transform.localScale = new Vector3(1, 1, 1);
        //}
        for(int i = 0; i < 10; i++)
        {
            for(int j=0; j < 10;j++)
            {
                GameObject go = GameObject.CreatePrimitive(PrimitiveType.Cube);
                go.transform.position =new Vector3(i,0,j);

            }
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
