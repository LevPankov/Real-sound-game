using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInteractionScrypt : MonoBehaviour
{
    public GameObject mainCam;
    public LayerMask interactableLayerMask = 9;
    public IInteractable interactable;

    public GameObject End;
    int goal = 0;

    private void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(mainCam.transform.position, mainCam.transform.forward, out hit, 2, interactableLayerMask))
        {
            if (hit.collider.GetComponent<IInteractable>() != false)
            {
                if(interactable == null || interactable.ID != hit.collider.GetComponent<IInteractable>().ID)
                {
                    interactable = hit.collider.GetComponent<IInteractable>();
                }
                if (Input.GetKeyDown(KeyCode.E))
                {
                    goal++;
                    interactable.onInteract.Invoke();
                    if(goal == 2)
                    {
                        End.SetActive(true);
                        Time.timeScale = 0f;
                        Cursor.lockState = CursorLockMode.Confined;
                    }
                }
            }
        }
    }

}
