using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    
    private const string horizontalInput = "Horizontal";
    private const string verticalInput = "Vertical";
    private const string isWalkingString = "isWalking";
    private const string jump = "jump";
    
    void Update()
    {
        DetectAnimation();
    }

    private void DetectAnimation()
    {
        if (Input.GetAxisRaw(verticalInput) != 0f || Input.GetAxisRaw(horizontalInput) != 0f)
        {
            _animator.SetBool(isWalkingString, true);
        }
        else
        {
            _animator.SetBool(isWalkingString, false);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _animator.SetTrigger(jump);
        }
    }
    
    
}
