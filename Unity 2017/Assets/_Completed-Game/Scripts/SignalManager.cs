using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class SignalManager {

    [Inject]
    SignalCreate.WinSignal _winSignal;

    [Inject]
    SignalCreate.ScoreSignal _scoreSignal;

    private int Pontos=0;

    public SignalManager(SignalCreate.WinSignal winSignal, SignalCreate.ScoreSignal scoreSignal)
    {
        _winSignal = winSignal;
        _scoreSignal = scoreSignal;
    }

    public void Score()
    {
        Pontos += 1;
        _scoreSignal.Fire(Pontos);

        if(Pontos >= 12)
        {
            _winSignal.Fire();
        }
    }
}
