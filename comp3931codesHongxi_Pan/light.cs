using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light : MonoBehaviour
{
    public float transform_value = 0;
    public float transform_num = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform_value > 2 || transform_value < -2)
        {
            transform_num = -transform_num;
        }
        transform.Translate(0, 0, transform_num * Time.deltaTime);
        transform_value += transform_num * Time.deltaTime;
    }
}
