using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour 
{

	private void Awake() 
	{
		
	}
	
	private void Update () 
	{
        if (Input .GetKeyDown(KeyCode.S))
        {
            EventService.Instance.GetEvent<GameStartEvent>().Publish();
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            EventManager.TriggerEvent("OnGameStart");
        }


    }
}
