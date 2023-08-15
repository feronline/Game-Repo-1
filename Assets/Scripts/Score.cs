using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text txt;
    // Update is called once per frame
    void Update()
    {
        txt.text = player.position.z.ToString("0");
    }
}
