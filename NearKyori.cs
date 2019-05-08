using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NearKyori : MonoBehaviour {

    GameObject stone;
    GameObject circle;
    GameObject distance;

    void Start()
    {
        this.stone = GameObject.Find("stone");
        this.circle = GameObject.Find("circle");
        this.distance = GameObject.Find("Distance");
    }

    void Update()
    {
        float length = this.stone.transform.position.y - this.circle.transform.position.y;
        if (length > 20)
        {
            this.distance.GetComponent<Text>().text = "あと" + length.ToString("F2") + "m" + "!";
        }
        else if (length > 11 && length <= 20)
        {
            this.distance.GetComponent<Text>().text = "むふふ(´∀｀=)\nあと？？？m!!";
        }
        else if (length > 3 && length <= 11)
        {
            this.distance.GetComponent<Text>().text = "いけ！o(^▽^)o\nあと"  + length.ToString("F2") + "m" + "！";
        }
        else if (length >= 1 && length <= 3)
        {
            this.distance.GetComponent<Text>().text = "いいぞ！(*･ω･)ﾉ\n" + length.ToString("F2") + "m" + "!!";
        }
        else if(length > -1 && length < 1)
        {
            this.distance.GetComponent<Text>().text = "す ご い！！\n♪☆o(≧▽≦)o☆♪\n" + length.ToString("F2") + "m" + "！！";
        }
        else if (length >= -3 && length <= -1)
        {
            this.distance.GetComponent<Text>().text = "やるね！(*´∀`)\n" + length.ToString("F2") + "m" + "!!";
        }
        else if(length < -3)
        {
            this.distance.GetComponent<Text>().text = "残念！(´Д`)";
        }
    }
}
