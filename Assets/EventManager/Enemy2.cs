using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Enemy2 : MonoBehaviour 
{
    private UnityAction onGameStart;

	private void Awake() 
	{
        onGameStart = new UnityAction(OnGameStart);
	}
	
	private void OnEnable () 
	{
        EventManager.StartListening("OnGameStart", onGameStart);
	}

    private void OnDisable()
    {
        EventManager.StopListening("OnGameStart", onGameStart);
    }

    private void OnGameStart()
    {
        print("Event2_OnGameStart");
    }
}
