using UnityEngine;
using System.Collections;
using Zenject;

public class Rotator : MonoBehaviour {

    [Inject]
    WinManager _winManager;

	// Before rendering each frame..
	void Update () 
	{
		// Rotate the game object that this script is attached to by 15 in the X axis,
		// 30 in the Y axis and 45 in the Z axis, multiplied by deltaTime in order to make it per second
		// rather than per frame.
		transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);
	}

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            gameObject.SetActive(false);
            _winManager.Score();
            Debug.Log("Rotator - OK");

        }
    }
}	