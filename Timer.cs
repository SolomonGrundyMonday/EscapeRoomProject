using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    // Private floating-point members for minutes and seconds.
    private float seconds;
    private float minutes;

    // Start is called before the first frame update
    void Start()
    {
       seconds = 0.0f;
       minutes = 5.0f;
       
    }

    // Update is called once per frame
    void Update()
    {

       string countdown;

       // Roll over the seconds counter if we go negative, and decrement minutes by one.
       if(seconds - Time.deltaTime < 0.0f)
       {
          seconds = 60.0f + (seconds - Time.deltaTime);
	      minutes = (minutes - 1.0f);
       }
       // Otherwise decrement seconds by Time.deltaTime.
       else
       {
          seconds = (seconds - Time.deltaTime);
       }

       // If seconds less than ten, insert leading zero into seconds counter.
       if (seconds < 10.0f)
       {
           countdown = string.Format("{0:N0}", minutes) + ":0" + string.Format("{0:N2}", seconds);
       }
       else
       {
           countdown = string.Format("{0:N0}", minutes) + ":" + string.Format("{0:N2}", seconds);
       }

       // Retrieve the Text object from the Canvas GameObject.
       GameObject textBox = GameObject.Find("Canvas");
       Text timerDisplay = textBox.GetComponentInChildren<Text>();

       // Change text color to red if user has <= 30 seconds left.
       if (minutes == 0.0f && seconds <= 30.0f)
       {
           timerDisplay.color = Color.red;
       }

       // If the timer runs out, terminate the application.
       if (minutes < 0.0f)
       {
           Application.Quit();
       }

        timerDisplay.text = countdown;
    }
}
