using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class Coilider : MonoBehaviour
{
    public int index;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnTriggerEnter(Collider other)
    {
        if(other.tag =="Points"){
            transform.parent.GetComponent<CarAIControl>().SetNewTarget(); 
            //GameObject.FindWithTag("AI_Player").GetComponent<CarAIControl>().SetNewTarget();
        }
    }
}
