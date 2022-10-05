using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyManager : MonoBehaviour
{
    public delegate void KeyEvent();

    public static event KeyEvent KeyCollected;

    [SerializeField] private Key[] keys;

    void Start()
    {
        foreach (Key currentKey in keys)
        {
            currentKey.SetManager(this);
        }
    }

    public int GetKeysLeftForCollection()
    {
        int quantity = 0;
        foreach (Key currentKey in keys)
        {
            if (!currentKey.HasBeenCollected())
            {
                quantity += 1;
            }
        }

        return quantity;
    }

    public void KeyHasBeenCollected()
    {
        KeyCollected();
    }
}
