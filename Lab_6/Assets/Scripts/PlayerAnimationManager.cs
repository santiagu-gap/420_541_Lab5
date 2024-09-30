using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationManager : MonoBehaviour
{
  private Animator animator;
  private PlayerMovement movement;
  public void Start()
  {
      animator = GetComponent<Animator>();
      movement = GetComponent<PlayerMovement>();
  }
  public void LateUpdate()
  {
      if (animator == null || movement == null)
      {
        return;
      }

      animator.SetFloat("CharacterSpeed", movement.GetMoveSpeed());
      animator.SetBool("IsFalling",!movement.isGrounded);
      if (Input.GetButtonUp("Fire1"))
      {
        animator.SetTrigger("doRoll");
      }
      if (Input.GetButtonUp("Fire2"))
<<<<<<< HEAD
      {
        animator.SetTrigger("doPunch");
      }
=======
        {
            animator.SetTrigger("doPunch");
        }
>>>>>>> 775a50f4808668894864e408ed2c40b70fe9d3f8
     
  }

}
