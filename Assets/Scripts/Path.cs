using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]
public class Path : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       for (var i = 0; i < transform.childCount; i++)
        {
            //Draw line between Pints
          if(i > 0){
           Debug.DrawLine(transform.GetChild(i).position, transform.GetChild(i-1).position, Color.yellow);
             //fix position Point
           transform.GetChild(i).LookAt(transform.GetChild(i-1).position);
           }
            //rename cube to Point i
            transform.GetChild(i).name = "Point" + i;
        }
    }
        
    }

    // Update is called once per frame
//     void Update()
//     {
        
// }
