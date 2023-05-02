using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diamond : MonoBehaviour
{
    private Transform myTransform;
    private float move_num1 = 0;
    private float move_num2 = -0.2f;
    public GameObject pick_up_effect_prefab;
    public GameObject light_trigger;
    // Start is called before the first frame update
    void Start()
    {
        myTransform = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (move_num1 >= 10 || move_num1 <= -10)
        {
            move_num2 = -move_num2;
        }
        move_num1 += move_num2;
        transform.Translate(0, move_num2 * Time.deltaTime, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Worm")
        {
            GameObject main_control = GameObject.Find("main_control");
            main_control.SendMessage("addscore2");
            GameObject pick_up_effect = Instantiate(pick_up_effect_prefab);
            pick_up_effect.transform.position = transform.position;
            light_trigger.SendMessage("change_num");
            Destroy(this.gameObject);
        }
    }
}
