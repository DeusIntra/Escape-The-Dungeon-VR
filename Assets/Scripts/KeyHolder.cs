using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyHolder : MonoBehaviour
{
    public List<GameObject> fire;
    public GameObject key;

    private bool isFireOut = false;
    private Player player;

    private void Start()
    {
        player = FindObjectOfType<Player>();
    }
    
    public void PutOutFire()
    {
        // TODO проверка на воду
        foreach (var obj in fire)
        {
            obj.SetActive(false);
        }
        isFireOut = true;
    }

    public void TakeKey()
    {
        key.SetActive(false);
        // TODO: дать игроку ключ
        Debug.Log("TODO");
    }
}
