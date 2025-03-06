using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimersCountdown : MonoBehaviour
{
    public Text lapTime;
    public Text startCountdown;
    public float totalLapTime;
    public float totalCountdownTime;
    public CodeyMove codey;
    public Text winLose;
    public string WinLoseTxt;
    public TriggerFinishLine o;

    // Update is called once per frame
    void Update()
    {
//        totalLapTime -= Time.deltaTime;
  //      totalCountdownTime -= Time.deltaTime;
    //    lapTime.text = Mathf.Round(totalLapTime).ToString();
      //  startCountdown.text = Mathf.Round(totalCountdownTime).ToString();
        if (totalCountdownTime > 0)
        {
            totalCountdownTime -= Time.deltaTime;
            startCountdown.text = Mathf.Round(totalCountdownTime).ToString();
            codey.Speed = 0;
        }
        if (totalCountdownTime < 0&&o.GameOver==false)
        {
            startCountdown.text = "";
            totalLapTime -= Time.deltaTime;
            lapTime.text = Mathf.Round(totalLapTime).ToString();
            codey.Speed = 40;
        }
        if (totalLapTime < 0)
        {
            print("Time is up!");
            codey.Speed = 0;
            totalLapTime = 0;
            WinLoseTxt = "You Lose!";
            winLose.text = WinLoseTxt;

        }
    }
}
