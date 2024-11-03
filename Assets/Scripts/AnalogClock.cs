using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{

    public Transform MinHand;
    public Transform HourHand;
    public Transform SecHand;

    void Update()
    {
        System.DateTime currentTime = System.DateTime.Now;

        float hoursAngle = (currentTime.Hour % 12) * 30f + (currentTime.Minute /60f)*30f;
        float minutesAngle = currentTime.Minute * 6f;
        float secondsAngle = currentTime.Second * 6f;

        HourHand.rotation = Quaternion.Euler( hoursAngle +94f, 0f, -90f);
        MinHand.rotation = Quaternion.Euler(-minutesAngle +94f,-180f, -270f);
        SecHand.rotation = Quaternion.Euler(secondsAngle, 0f, -90f);
    }

    
}