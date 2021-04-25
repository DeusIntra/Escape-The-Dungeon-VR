using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject rightObject;
    public GameObject leftObject;
    public GameObject cauldronPrefab;
    public GameObject filledCauldronPrefab;

    private bool hasRight = false;
    private bool hasLeft = false;

    public void Take(bool right = true)
    {
        if (right)
        {
            rightObject.SetActive(true);
            hasRight = true;
        }
        else
        {
            leftObject.SetActive(true);
            hasLeft = true;
        }
    }

    public void TakeCauldron()
    {
        leftObject = cauldronPrefab;
        Take(false);
    }

    public void FillCauldron()
    {
        leftObject.SetActive(false);
        leftObject = filledCauldronPrefab;
        Take(false);
    }
}
