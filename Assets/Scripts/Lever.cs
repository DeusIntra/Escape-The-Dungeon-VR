using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    [ContextMenu("Pull")]
    public void Pull()
    {
        animator.enabled = true;
        animator.Play("pull");
    }
}
