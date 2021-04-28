using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    public GameObject teleports;

    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void Open()
    {
        animator.SetTrigger("open");
    }

    public void ActivateTeleports()
    {
        teleports?.SetActive(true);
    }
}
