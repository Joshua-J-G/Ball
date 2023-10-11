using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovebetweenPoints : MonoBehaviour
{
    public Vector3 Position1;
    public Vector3 Position2;
    bool movingtoposition1 = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    float time;
    // Update is called once per frame
    void Update()
    {
       if (movingtoposition1)
        {
            time += Time.deltaTime;
         
            transform.position = Vector3.Lerp(transform.position, Position1, time);
            if (time >= 1)
            {
                time = 0;
                movingtoposition1 = false;
            }
        }
        else
        {
            time += Time.deltaTime;
          
            transform.position = Vector3.Lerp(transform.position, Position2, time);
            if(time >= 1)
            {
                time = 0;
                movingtoposition1 = true;
            }
        }
    }
}
