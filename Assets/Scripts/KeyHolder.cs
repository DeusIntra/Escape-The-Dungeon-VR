using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyHolder : MonoBehaviour
{
    public List<GameObject> fire;
    public GameObject key;
    public GameObject playerKey;
    public SphereCollider door3;

    private bool isOnFire = true;
    
    public void PutOutFire()
    {
        // проверка на огонь
        if (isOnFire == false) return;

        foreach (var obj in fire)
        {
            obj.SetActive(false);
        }

        isOnFire = false;   
    }

    public void TakeKey()
    {
        if (isOnFire) return;

        key.SetActive(false);
        playerKey.SetActive(true);
        door3.enabled = true;

        GetComponent<SphereCollider>().enabled = false;
    }
}
