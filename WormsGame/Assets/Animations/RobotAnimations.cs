using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotAnimations : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private RobotSounds soundController;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("JumpTrigger");
            soundController.PlayJumpSound();
        }

        bool isWalking = Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0;
        animator.SetBool("IsWalking", isWalking);
    }
}
