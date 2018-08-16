using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class WinMenssage : MonoBehaviour
{
    [Inject]
    SignalCreate.WinSignal _winSignal;

    public Text winText;

    private void Start()
    {
        winText.text = "";
        _winSignal.Listen(Menssagem);
    }
    private void OnDestroy()
    {
        _winSignal.Unlisten(Menssagem);
    }
    public void Menssagem()
    {
        winText.text = "YOU WIN!";
        Debug.Log("WinMessage - OK");
    }
}
