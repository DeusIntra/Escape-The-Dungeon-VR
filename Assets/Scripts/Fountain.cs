using UnityEngine;

public class Fountain : MonoBehaviour
{
    public Transform water;
    public Transform target;

    public void TakeWater()
    {
        water.position = target.position;
    }
}
