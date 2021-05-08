﻿using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent), typeof(AgentLinkMover))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private Camera Camera = null;
    private NavMeshAgent Agent;
    [SerializeField]
    private Animator Animator = null;
    private AgentLinkMover LinkMover;

    private const string IsWalking = "IsWalking";
    private const string Jump = "Jump";
    private const string Landed = "Landed";

    private RaycastHit Hit;

    private void Awake()
    {
        Agent = GetComponent<NavMeshAgent>();
        LinkMover = GetComponent<AgentLinkMover>();

        LinkMover.OnLinkStart += HandleLinkStart;
        LinkMover.OnLinkEnd += HandleLinkEnd;
    }

    private void HandleLinkStart()
    {
        Animator.SetTrigger(Jump);
    }

    private void HandleLinkEnd()
    {
        Animator.SetTrigger(Landed);
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            Ray ray = Camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out Hit))
            {
                Agent.SetDestination(Hit.point);
            }
        }

        Animator.SetBool(IsWalking, Agent.velocity.magnitude > 0.01f);
    }
}
