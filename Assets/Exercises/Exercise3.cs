using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise3 : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            // TODO: On every space pressed set the local scale of the GameObject to 10% smaller (so basically multiply transform.localScale by 0.9).
            // bonus: instead of 0.9 use a variable to determine the factor
        }
    }
}
