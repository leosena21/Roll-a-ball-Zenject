using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class WinMenssage : MonoBehaviour {

    public Text winMenssage;

    [Inject]
    WinSignal _winSignal;

    private void Start()
    {
        winMenssage.text = "";
        _winSignal.Listen(WIN);
    }

    private void OnDestroy()
    {
        _winSignal.Unlisten(WIN);
    }

    public void WIN()
    {
        winMenssage.text = "YOU WIN";
        Debug.Log("WinMenssage");
    }
}
