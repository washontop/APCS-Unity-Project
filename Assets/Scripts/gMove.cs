using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gMove : MonoBehaviour
{
    public Vector3 ghost;
    public float ypos;
    public float xspeed;
    public float limit;

 
    // Start is called before the first frame update
    void Start()
    {
      
        ypos = Random.Range(-3, 3);
        xspeed = Random.Range(0, 2);
        
    }

    // Update is called once per frame
    void Update()
    {
        ghost = new Vector3(8f - xspeed, ypos, 0f);
        limit = transform.position.x;
        if (limit == -8)
        {
            ghost = new Vector3(8f - xspeed, ypos, 0f);
        }
    }
}
