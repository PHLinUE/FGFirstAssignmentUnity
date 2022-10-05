using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeyCounterUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI counter;
    [SerializeField] private KeyManager keyManager;

    void Start()
    {
        KeyManager.KeyCollected += UpdateKeyCounter;
        UpdateKeyCounter();
    }
    
    private void UpdateKeyCounter()
    {
        counter.text = "Keys Left: " + keyManager.GetKeysLeftForCollection();
    }

    void OnDestroy()
    {
        KeyManager.KeyCollected -= UpdateKeyCounter;
    }
}
