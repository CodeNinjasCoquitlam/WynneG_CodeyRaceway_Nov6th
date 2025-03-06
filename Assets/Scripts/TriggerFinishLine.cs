using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFinishLine : MonoBehaviour
{

    public CodeyMove codey;
    public CheckpointCounter checkpointTracker;
    public Text winLose;
    public string WinLoseTxt;
    public bool GameOver = false;



    private void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.tag == "Codey")
        {
            if (checkpointTracker.triggeredCheckpoints == checkpointTracker.numberOfCheckpoints)
            {
                print("You Win!");
                GameOver = true;
                codey.Speed = 0;
                WinLoseTxt = "You Win!";
                winLose.text = WinLoseTxt;
            }
            else
            {
                print("Cheater!");
            }

        }
    }
}
