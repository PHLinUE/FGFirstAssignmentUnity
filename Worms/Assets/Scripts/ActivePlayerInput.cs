using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivePlayerInput : MonoBehaviour
{
    [SerializeField] private ActivePlayerManager manager;
    [SerializeField] private float rotationSpeed;
    [SerializeField] private float walkingSpeed;
  //  [SerializeField] private Rigidbody characterBody;

    void Update()
    {
        if (manager.PlayerCanPlay())
        {
            if (Input.GetAxis("Horizontal") != 0)
            {
                ActivePlayer currentPlayer = manager.GetCurrentPlayer();
                currentPlayer.transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime * Input.GetAxis("Horizontal"), Space.World);
            }

            if (Input.GetAxis("Vertical") != 0)
            {
                ActivePlayer currentPlayer = manager.GetCurrentPlayer();
                currentPlayer.transform.Translate(currentPlayer.transform.forward * walkingSpeed * Time.deltaTime * Input.GetAxis("Vertical"), Space.World);
            }

            if (Input.GetKeyDown(KeyCode.X))
            {
                ActivePlayer currentPlayer = manager.GetCurrentPlayer();
                currentPlayer.GetComponent<ActivePlayerWeapon>().ShootLaser();
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Jump();
            }
        }
    }

    private void Jump()
    {
        //characterBody.velocity = Vector3.up * 10f;
        //characterBody.AddForce(Vector3.up * 500f);
    }

    private bool IsTouchingFloor()
    {
        RaycastHit hit;
        // Parameters:
        // - The center from where we shoot
        // - Radius of the sphere
        // - Direction of the sphere
        // - hit parameter
        // - Distance the sphere
        bool result = Physics.SphereCast(transform.position, 0.15f, -transform.up, out hit, 1f);
        return result;
    
    }

}

