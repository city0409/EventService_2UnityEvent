using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Enemy : MonoBehaviour 
{
    private Action onGameStart;

    private void OnEnable()
    {
        onGameStart = OnGameStart;
        EventService.Instance.GetEvent<GameStartEvent>().Subscribe(onGameStart);
    }

    private void Update () 
	{
        if (Input .GetKeyDown(KeyCode.D))
        {
            Destroy(gameObject);
        }
	}

    private void OnDisable()
    {
        print("OnDisable");
        EventService.Instance.GetEvent<GameStartEvent>().UnSubscribe(onGameStart);
    }

    private void OnGameStart()
    {
        print("Event_OnGameStart");
    }

    private void OnDestroy()
    {
        print("OnDestroy");
        EventService.Instance.GetEvent<GameStartEvent>().UnSubscribe(onGameStart);

    }
}
