using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class NewMainThreadDispatcher : MonoBehaviour
{
    private static NewMainThreadDispatcher instance;

    private Queue<Action> actionQueue = new Queue<Action>();

    void Awake()
    {
        if(instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public static void ExecuteInUpdate(Action action)
    {
        if(instance != null)
        {
            instance.actionQueue.Enqueue(action);
        }
    }

    void Update()
    {
        while(actionQueue.Count > 0)
        {
            actionQueue.Dequeue()?.Invoke();
        }
    }
}
