using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class DucksInARow : MonoBehaviour
{
    [SerializeField] private int position;
    [SerializeField] private Duck newDuck;

    private List<Duck> ducks;

    // Start is called before the first frame update
    void Start()
    {
        ducks = GetComponentsInChildren<Duck>().ToList();    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ducks[position].SetRandomColor();
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            ducks.Add(newDuck);
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            foreach (Duck duck in ducks)
            {
                duck.SetRandomColor();
            }
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            foreach (Duck duck in ducks)
            {
                if (duck.transform.position.z < 0)
                { 
                    duck.SetRandomColor();
                }
            }
        }
    }
}
