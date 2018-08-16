using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class WinManager {

    [Inject]
    WinSignal _winSignal;

    [Inject]
    ScoreSignal _scoreSignal;

    private int Pontos=0;

    public WinManager(WinSignal winSignal, ScoreSignal scoreSignal)
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
