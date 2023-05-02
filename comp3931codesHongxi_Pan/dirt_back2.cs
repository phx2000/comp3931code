using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dirt_back2 : MonoBehaviour
{
    public GameObject worm;
    public float posx = 0;
    public float posy = 0;
    public float posz = 0;
    public float move_in_all = 0;
    //public float number = 10;
    // Start is called before the first frame update
    void Start()
    {
        posx = worm.transform.position.x;
        posy = worm.transform.position.y;
        posz = worm.transform.position.z;
        //transform.localScale = transform.localScale * number;
        //transform.Translate(transform.position.x * number, transform.position.y * number, transform.position.z * number);
    }

    // Update is called once per frame
    void Update()
    {
        float pos1 = worm.transform.position.x;
        float pos2 = worm.transform.position.y;
        float pos3 = worm.transform.position.z;
        float moves = Mathf.Pow((Mathf.Pow(posx - pos1, 2.0f) + Mathf.Pow(posy - pos2, 2.0f) + Mathf.Pow(posz - pos3, 2.0f)), 0.5f);
        transform.Translate(0, -moves, 0);
        posx = pos1;
        posy = pos2;
        posz = pos3;
        move_in_all += moves;
        if (move_in_all > 10)
        {
            transform.Translate(0, 10, 0);
            move_in_all -= 10;
        }
    }
}
