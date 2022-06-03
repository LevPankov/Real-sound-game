using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Win : MonoBehaviour
{
    public GameObject sound1;
    public GameObject sound2;
    public GameObject End;

    private void Update()
    {
        if(!sound1.activeSelf && !sound2.activeSelf)
        {
            End.SetActive(true);
            Time.timeScale = 0f;
            Cursor.lockState = CursorLockMode.Confined;
        }
    }
}
