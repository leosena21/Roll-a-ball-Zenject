using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class ScoreMenssage : MonoBehaviour {

    public Text Score;

    [Inject]
    SignalCreate.ScoreSignal _scoreSignal;

    private void Start()
    {
        Score.text = "Score: 0";
        _scoreSignal.Listen(AddScore);
    }

    private void OnDestroy()
    {
        _scoreSignal.Unlisten(AddScore);
    }


    public void AddScore(int Pontos)
    {
        Score.text = "Score: " + Pontos;
    }


}
