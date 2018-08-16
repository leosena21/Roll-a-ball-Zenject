using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class SignalCreate{

    public class WinSignal : Signal<WinSignal>{}

    public class ScoreSignal : Signal<ScoreSignal, int>{}
}
