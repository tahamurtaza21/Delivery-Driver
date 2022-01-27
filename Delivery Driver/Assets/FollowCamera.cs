using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    // camera position should be the same as car's position

    [SerializeField] GameObject Player;

    void LateUpdate()
    {
        transform.position = Player.transform.position + new Vector3(0,0,-10);  
    }
}
