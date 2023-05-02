using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class main_control : MonoBehaviour
{
    public int score;
    public float times;
    public float hp = 300;
    public float drop = 1;
    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI TimeText;
    public TextMeshProUGUI LifeText;
    public TextMeshProUGUI winning;
    public GameObject worm;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hp != 0)
        {
            times += Time.deltaTime;
        }
        int times_10 = (int)(times * 10);
        TimeText.text = "" + (float)(times_10*1.0)/10 + "s";
        hp -=  drop * Time.deltaTime;
        if (hp <= 0)
        {
            game_over();
        }
        life_decrease();
    }
    public void addscore()
    {
        score += 1;
        ScoreText.text = "" + score;
    }
    public void addscore2()
    {
        score += 5;
        ScoreText.text = "" + score;
    }
    public void addhp()
    {
        hp += 30;
        LifeText.text = "" + (int)hp/3;
    }
    public void life_decrease()
    {
        LifeText.text = "" + (int)hp/3;
    }
    public void game_over()
    {
        hp = 0;
        drop = 0;
        winning.text = "" + "GAME OVER!";
        worm.SendMessage("stop");
    }
}
