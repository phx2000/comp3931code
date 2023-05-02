using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class money : MonoBehaviour
{
    private Transform myTransform;
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
        myTransform.Rotate(Vector3.down, 3);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Worm")
        {
            GameObject main_control = GameObject.Find("main_control");
            main_control.SendMessage("addscore");
            GameObject pick_up_effect = Instantiate(pick_up_effect_prefab);
            pick_up_effect.transform.position = transform.position;
            light_trigger.SendMessage("change_num");
            Destroy(this.gameObject);
        }
    }
}
