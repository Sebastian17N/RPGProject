using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Cinemachine;

public class PlayerMove : MonoBehaviour
{
    private NavMeshAgent nav;
    private Animator anim;
    private Ray ray;
    private RaycastHit hit;

    private float x;
    private float z;
    private float velocitySpeed;

    CinemachineTransposer ct;
    public CinemachineVirtualCamera playerCam;
    private Vector3 pos;
    private Vector3 currPos;

    public static bool canMove = true;

    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        ct = playerCam.GetCinemachineComponent<CinemachineTransposer>();
        currPos = ct.m_FollowOffset;
    }

    // Update is called once per frame
    void Update()
    {
        x = nav.velocity.x;
        z = nav.velocity.z;
        velocitySpeed = x + z;

        pos = Input.mousePosition;
        ct.m_FollowOffset = currPos;

        if (Input.GetMouseButtonDown(0))
        {
            if(canMove == true)
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit))
                {
                    nav.destination = hit.point;
                }
            }
        }

        if(velocitySpeed != 0)
        {
            anim.SetBool("sprinting", true);
        }
        else if(velocitySpeed == 0)
        {
            anim.SetBool("sprinting", false);
        }

        if (Input.GetMouseButton(1))
        {
            if (pos.x != 0 || pos.y != 0)
            {
                currPos = pos / 150;
            }
        }
    }
}
