using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombRotetament : MonoBehaviour
{
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0,90,0)*Time.deltaTime);
    }
}
