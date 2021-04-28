using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WhiteFadeout : MonoBehaviour
{
    public void MakeWhite()
    {
        GetComponent<Image>().color = new Color(1, 1, 1, 0);
    }
}
