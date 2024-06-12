using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    Camera camera;
    GameObject player = BossFight.Boss.player1;
    Vector3 reft = Vector3.zero;
    void Start()
    {
        camera = Camera.main;
    }

    void Update()
    {
        transform.position = Vector3.SmoothDamp(transform.position, player.transform.position, ref reft, 1);
    }
}
