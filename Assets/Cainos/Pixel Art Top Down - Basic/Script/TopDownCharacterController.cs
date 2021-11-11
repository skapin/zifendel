using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cainos.PixelArtTopDown_Basic
{
    public class TopDownCharacterController : MonoBehaviour
    {
        public float speed;

        private Animator animator;

        private void Start()
        {
            animator = GetComponent<Animator>();
        }


        private void Update()
        {
            Vector2 dir = Vector2.zero;

            // dir.x = Input.GetAxisRaw("Horizontal");
            // dir.y = Input.GetAxisRaw("Vertical");
            if (Input.GetKey(KeyCode.Q))
            {
                dir.x = -1;
                // animator.SetFloat("Direction", 3);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                dir.x = 1;
                // animator.SetFloat("Direction", 2);
            }

            if (Input.GetKey(KeyCode.Z))
            {
                dir.y = 1;
                // animator.SetFloat("Direction", 1);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                dir.y = -1;
                // animator.SetFloat("Direction", 0);
            }

            dir.Normalize();
            // animator.SetBool("IsMoving", dir.magnitude > 0);
            animator.SetBool("IsMoving", dir.magnitude > 0);
            if (dir.magnitude > 0) {
	            animator.SetFloat("MoveX", dir.x);
	            animator.SetFloat("MoveY", dir.y);
            }
            GetComponent<Rigidbody2D>().velocity = speed * dir;
        }
    }
}
