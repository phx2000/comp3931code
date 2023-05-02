using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light_controller : MonoBehaviour
{
    public GameObject light_green;
    public GameObject light_red;
    public int green_num = 0;
    // Start is called before the first frame update
    void Start()
    {
        light_green.SetActive(false);
        light_red.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "good")
        {
            light_green.SetActive(true);
            green_num += 1;
        }
        if (other.name == "predator")
        {
            light_red.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "good")
        {
            green_num -= 1;
            if (green_num == 0)
            {
                light_green.SetActive(false);
            }
        }
        if (other.name == "predator")
        {
            light_red.SetActive(false);
        }
    }
    public void change_num()
    {
        green_num -= 1;
        if (green_num == 0)
        {
            light_green.SetActive(false);
        }
    }
}
