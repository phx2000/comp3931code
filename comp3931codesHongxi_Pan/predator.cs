using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class predator : MonoBehaviour
{
    private float speed = 9f;
    public GameObject main_control;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-speed * Time.deltaTime, 0, 0);
        transform.Rotate(0, -speed * 3.4f * Time.deltaTime, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Worm")
        {
            main_control.SendMessage("game_over");
        }

    }
}
