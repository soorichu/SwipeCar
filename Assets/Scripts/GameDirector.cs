using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{

    GameObject car;
    GameObject flag;
    GameObject distance;
    // Start is called before the first frame update
    void Start()
    {
        this.car = GameObject.Find("car");
        this.flag = GameObject.Find("flag");
        this.distance = GameObject.Find("Distance");
    }

    // Update is called once per frame
    void Update()
    {
        float length = this.flag.transform.position.x - this.car.transform.position.x;
        if(length > 0.5f)
            this.distance.GetComponent<Text>().text = "목표 지점까지 " + length.ToString("F2") + "m";  //소숫점 2번째 자리까지의 값을 문자열로 구한다.
        else if(length <= 0.5f && length >= -0.5f)
            this.distance.GetComponent<Text>().text  = "YOU WIN!";
        else
            this.distance.GetComponent<Text>().text  = "GAMEOVER";
    }
}
