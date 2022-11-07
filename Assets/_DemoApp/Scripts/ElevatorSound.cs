using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorSound : MonoBehaviour
{
    private static ElevatorSound elevatorSound;
    void Awake()
    {
        if (elevatorSound == null)
        {
            elevatorSound = this;
            DontDestroyOnLoad(elevatorSound);
        }
        else 
        {
            Destroy(gameObject);
        }

    }
}
