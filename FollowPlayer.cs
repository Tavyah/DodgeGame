using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        //Console skriver ut posisjon til spiller
        //Debug.Log(player.position);

        transform.position = player.position + offset;
    }
}
