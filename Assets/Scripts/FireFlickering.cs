using UnityEngine;

public class FireFlickering : MonoBehaviour
{
    public float speed = 1f;
    public Vector3 multiplier = Vector3.one;

    private Vector3 _origin;
    private float t = 0;

    private void Start()
    {
        _origin = transform.position;
    }
    
    private void Update()
    {
        t += Time.deltaTime * Mathf.PerlinNoise(0, Time.time) * speed;

        float x = Mathf.PerlinNoise(1, t) * multiplier.x - multiplier.x / 2;
        float y = Mathf.PerlinNoise(2, t) * multiplier.y;
        float z = Mathf.PerlinNoise(3, t) * multiplier.z - multiplier.z / 2;

        transform.position = _origin + new Vector3(x, y, z);
    }
}
