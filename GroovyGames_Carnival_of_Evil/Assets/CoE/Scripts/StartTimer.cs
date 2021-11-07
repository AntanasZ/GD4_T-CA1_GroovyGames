using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartTimer : MonoBehaviour
{
    [SerializeField]
    private Text timerText;

    [SerializeField]
    private GameObject carouselPuzzle;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player") && !carouselPuzzle.GetComponent<PullLever>().puzzleFinished)
        {
            timerText.GetComponent<Timer>().startTimer();
        }
    }


}
