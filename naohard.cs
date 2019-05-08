using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class naohard : MonoBehaviour {

    GameObject timerText;
    GameObject pointText;
    float time = 30.0f;
    int point = 0;
    GameObject generator;
    ItemGenerator ig;
    Text tx;
    Text tt;

    public void GetApple()
    {
        this.point += 100;
    }

    public void GetBomb()
    {
        this.point /= 2;
    }

    void Start()
    {
        this.generator = GameObject.Find("ItemGenerator");
        this.timerText = GameObject.Find("Time");
        this.pointText = GameObject.Find("Point");
        ig = this.generator.GetComponent<ItemGenerator>();
        tx = this.timerText.GetComponent<Text>();
        tt = this.pointText.GetComponent<Text>();
    }

    void Update()
    {
        this.time -= Time.deltaTime;

        if (this.time < 0)
        {
            this.time = 0;
            ig.SetParameter(10000.0f, 0, 0);

        }
        else if (0 <= this.time && this.time < 4)
        {
            ig.SetParameter(0.5f, -2.2f * Time.deltaTime, 2);
        }
        else if (4 <= this.time && this.time < 11)
        {
            ig.SetParameter(0.4f, -2.8f * Time.deltaTime, 6);
        }
        else if (11 <= this.time && this.time < 17)
        {
            ig.SetParameter(0.5f, -2.6f * Time.deltaTime, 4);
        }
        else if (17 <= this.time && this.time < 26)
        {
            ig.SetParameter(0.6f, -2.4f * Time.deltaTime, 3);
        }
        else if (26 <= this.time && this.time < 30)
        {
            ig.SetParameter(0.8f, -2.0f * Time.deltaTime, 2);
        }

        tx.text = this.time.ToString("F1");
        tt.text = this.point.ToString() + "point";
    }
}