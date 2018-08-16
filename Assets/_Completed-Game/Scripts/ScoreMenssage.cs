using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Zenject;


[RequireComponent(typeof(Text))]
public class ScoreMenssage : MonoBehaviour {

    public Text scoreMenssage;
    private int count = 0;

    [Inject]
    ScoreSignal _scoreSignal;

    public ScoreMenssage(ScoreSignal scoreSignal)
    {
        _scoreSignal = scoreSignal;
    }

    private void Start()
    {
        scoreMenssage.text = "Score: 0";
        _scoreSignal.Listen(SCORE);
    }

    private void OnDestroy()
    {
        _scoreSignal.Unlisten(SCORE);
    }

    public void SCORE()
    {
        count += 1;
        scoreMenssage.text = "Score: " + count;
        Debug.Log("ScoreMenssage");
    }
}
