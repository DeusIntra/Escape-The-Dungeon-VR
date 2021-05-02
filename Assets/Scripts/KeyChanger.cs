using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyChanger : MonoBehaviour
{
    public GameObject keySilver;
    public GameObject keyGolden;

    private Player player;

    private void Awake()
    {
        player = GetComponent<Player>();
    }

    public void ChangeKey()
    {
        if (player.leftObject == keySilver)
        {
            player.leftObject = keyGolden;
        }
        else
        {
            player.leftObject = keySilver;
        }
    }

}
