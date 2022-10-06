using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GroundCollisions : MonoBehaviour
{


    public bool touchGround;

    private void Start()
    {
        touchGround = true;
    }

    [SerializeField] private MeshRenderer meshRenderer;

    public void OnCollisionEnter(Collision collision)
    {
        meshRenderer.material.color = GetRandomColor();
        touchGround = true;
    }

    public void OnCollisionExit(Collision collision)
    {
        meshRenderer.material.color = GetRandomColor();
        touchGround = false;
    }

    private Color GetRandomColor()
    {
        Color color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 1f);
        return color;
    }

    public bool GetCurrentCollision()
    {
        return touchGround;
    }

}
