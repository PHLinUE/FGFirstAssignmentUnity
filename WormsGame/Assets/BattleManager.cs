using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    float currenTime = 0f;
    float startingTime = 10f;

    void Start()
    {
        currenTime = startingTime;
    }

    void Update()
    {
        currenTime -= 1 * Time.deltaTime;
        print(currenTime);
    }

}
