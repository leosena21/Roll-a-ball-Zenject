using UnityEngine;
using System.Collections;
using Zenject;

public class Rotator : MonoBehaviour {

    [Inject]
    SignalManager _signalManager;

	void Update () 
	{
		transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);
	}

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            gameObject.SetActive(false);
            _signalManager.Score();
            Debug.Log("Rotator - OK");

        }
    }
}	