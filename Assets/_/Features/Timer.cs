using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    [SerializeField] private float chrono;
    [HideInInspector]public float _currentTime;
    public UnityEvent<string> OnTimerEnd;

    private void Awake()
    {
        if (chrono == 0) chrono = 60f;
    }

    private void OnEnable()
    {
        StartTheChrono();
    }

    private void Update()
    {
        
        if (_currentTime <= 0f)
        {
            string end = ("Time over");
            OnTimerEnd?.Invoke(end);
        } else _currentTime -= Time.deltaTime;
    }


    [ContextMenu("Start The Chrono")]
    public void StartTheChrono()
    {
        _currentTime = chrono;
    }
}
