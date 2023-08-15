using UnityEngine;

public class CamereFollow : MonoBehaviour
{

    public Transform player;
    public Vector3 offset;
    void Update()
    {
        transform.position = player.position + offset;

    }
}
