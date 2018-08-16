using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class SignalManager{

    [Inject]
    WinSignal _winSignal;

    [Inject]
    ScoreSignal _scoreSignal;

    private int count;

    public SignalManager(WinSignal winSignal, ScoreSignal scoreSignal)
    {
        _winSignal = winSignal;
        _scoreSignal = scoreSignal;
    }

    public void AddScore()
    {
        count += 1;
        _scoreSignal.Fire();

        if (count >= 2)
        {
            _winSignal.Fire();
            Debug.Log("SignalManager");
        }

    }
}
