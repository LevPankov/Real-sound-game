using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class IInteractable: MonoBehaviour
{
    public UnityEvent onInteract;
    public Sprite interactIcon;
    public int ID;

    private void Start()
    {
        ID = Random.Range(0, 999999);
    }
}
