using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToNextWaypoint : MonoBehaviour
{
  //Stores waypoints
  [SerializeField] private Waypoints waypoints;
  [SerializeField] private PlayerController playerAI;

  [Range(0f, 15f)]
  [SerializeField] private float rotateSpeed = 10f;
  [SerializeField] private float distanceThreshold = 0.1f;

  private Transform currentWaypoint;
  private Quaternion rotationGoal;
  private Vector3 directionToWaypoint;

  void Start()
  {
    // Initial Waypoint
    currentWaypoint = waypoints.GetNextWaypoint(currentWaypoint);
  }

  void Update()
  {
    transform.position = Vector3.MoveTowards(transform.position, currentWaypoint.position, playerAI.playerSpeed * Time.deltaTime);
    if (Vector3.Distance(transform.position, currentWaypoint.position) < distanceThreshold)
    {
      currentWaypoint = waypoints.GetNextWaypoint(currentWaypoint);
    }

    RotateToWaypoint();
  }

  private void RotateToWaypoint()
  {
    directionToWaypoint = (currentWaypoint.position - transform.position).normalized;
    rotationGoal = Quaternion.LookRotation(directionToWaypoint);

    transform.rotation = Quaternion.Slerp(transform.rotation, rotationGoal, rotateSpeed * Time.deltaTime);
  }


}
