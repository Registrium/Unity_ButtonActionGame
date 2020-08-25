using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeController : MonoBehaviour
{
    public static TimeController instance;
    public Text text;
    public float time;
    // Start is called before the first frame update
    void Start()
    {
        TimeController.instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        text.text = "Time : " + (10 - (int)time);
    }
}
