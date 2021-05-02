using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigRoomLightTrigger : MonoBehaviour
{
    public new GameObject light;

    private void OnTriggerEnter(Collider other)
    {
        light.SetActive(false);
    }

    private void OnTriggerExit(Collider other)
    {
        light.SetActive(true);
    }
}
