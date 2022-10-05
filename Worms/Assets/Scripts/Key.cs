using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    [SerializeField] private GameObject keyVisuals;

    private KeyManager keyManager;
    private bool hasBeenCollected;

    void Start()
    {
        hasBeenCollected = false;
    }

    public void SetManager(KeyManager manager)
    {
        keyManager = manager;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (!hasBeenCollected)
        {
            keyVisuals.SetActive(false);
            hasBeenCollected = true;
            keyManager.KeyHasBeenCollected();
        }
    }

    public bool HasBeenCollected()
    {
        return hasBeenCollected;
    }
}
