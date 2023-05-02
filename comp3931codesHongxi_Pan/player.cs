using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    public float speed = 40;
    public float xmove = 1;
    public float ymove = 1;
    public bool go = false;
    public GameObject first_sight;
    public GameObject second_sight;
    public GameObject third_sight;
    public GameObject forth_sight;
    public GameObject fifth_sight;
    public GameObject cameraa;
    public GameObject main_control;
    public int cameraa_number = 0;
    //public GameObject sight_rec;
    //public float see = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //camera Q E
        if (Input.GetKeyDown(KeyCode.Q) && cameraa_number < 5)
        {
            cameraa.transform.Translate(0, 0, 1);
            cameraa_number += 1;
        }
        else if (Input.GetKeyDown(KeyCode.E) && cameraa_number > -3)
        {
            cameraa.transform.Translate(0, 0, -1);
            cameraa_number -= 1;
        }
        //sight Z X C V B N
        if (Input.GetKeyDown(KeyCode.Z))
        {
            first_sight.SetActive(true);
            second_sight.SetActive(false);
            third_sight.SetActive(false);
            forth_sight.SetActive(false);
            fifth_sight.SetActive(false);
            //sight_rec = first_sight;
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            first_sight.SetActive(false);
            second_sight.SetActive(true);
            third_sight.SetActive(false);
            forth_sight.SetActive(false);
            fifth_sight.SetActive(false);
            //sight_rec = second_sight;
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            first_sight.SetActive(false);
            second_sight.SetActive(false);
            third_sight.SetActive(true);
            forth_sight.SetActive(false);
            fifth_sight.SetActive(false);
            //sight_rec = third_sight;
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            first_sight.SetActive(false);
            second_sight.SetActive(false);
            third_sight.SetActive(false);
            forth_sight.SetActive(true);
            fifth_sight.SetActive(false);
            //sight_rec = forth_sight;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            first_sight.SetActive(false);
            second_sight.SetActive(false);
            third_sight.SetActive(false);
            forth_sight.SetActive(false);
            fifth_sight.SetActive(true);
            //sight_rec = fifth_sight;
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            first_sight.SetActive(false);
            second_sight.SetActive(false);
            third_sight.SetActive(false);
            forth_sight.SetActive(false);
            fifth_sight.SetActive(false);
            //sight_rec = null;
        }
        //move SPACE
        if (Input.GetKeyDown(KeyCode.Space))
        {
            go = true;
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            go = false;
        }
        if (go)
        {
            transform.Translate(0, 0, speed / 400);
        }
        //rotate A D W S
        xmove = Input.GetAxis("Horizontal");
        transform.Rotate(0, xmove * speed * Time.deltaTime, 0);
        ymove = Input.GetAxis("Vertical");
        transform.Rotate(-ymove * speed * Time.deltaTime, 0, 0);

        //go up to ground
        //see = transform.rotation.x;
        //Debug.Log(transform.rotation.x);
        //if (transform.position.y >= 65.6f && transform.rotation.x < 0)
        //{
        //    transform.Translate(0, 67.6f - transform.position.y, 0);
        //    first_sight.SetActive(false);
        //    second_sight.SetActive(false);
        //    third_sight.SetActive(false);
        //    forth_sight.SetActive(false);
        //    fifth_sight.SetActive(false);
        //}
        //else if (transform.position.y > 67.6f && transform.rotation.x < 0)
        //{
        //    transform.Translate(0, 67.6f - transform.position.y, 0);
        //}
        //if ( transform.position.y >= 65.6f && transform.position.y < 67.6f && transform.rotation.x > 0)
        //{
        //    transform.Translate(0, -2, 0);
        //    sight_rec.SetActive(true);
        //}
    }
    public void stop()
    {
        speed = 0;
        xmove = 0;
        ymove = 0;
    }
}

