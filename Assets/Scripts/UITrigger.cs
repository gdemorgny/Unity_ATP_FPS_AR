using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UITrigger : MonoBehaviour
{
    public UnityEvent OnPlayerEnter;
    public UnityEvent OnPlayerExit;

    private void Start()
    {
        OnPlayerExit?.Invoke();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            OnPlayerEnter?.Invoke();
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            OnPlayerExit?.Invoke();
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = false;

        }
    }

}
