using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop : MonoBehaviour
{
  [SerializeField] private float dragSpeed = 2.0f;
  private bool isDragging = false;
  private Vector3 offset;

  private void OnMouseDown()
  {
    offset = gameObject.transform.position - GetMouseWorldPos();
    isDragging = true;
    Debug.Log(isDragging);
  }

  private void OnMouseUp()
  {
    isDragging = false;
  }

  private Vector3 GetMouseWorldPos()
  {
    Vector3 mousePos = Input.mousePosition;
    mousePos.z = Camera.main.nearClipPlane;
    return Camera.main.ScreenToWorldPoint(mousePos);

    // Debug.Log(mousePos);
  }

  private void Update()
  {
    if (isDragging)
    {
      Vector3 mousePos = GetMouseWorldPos();

      mousePos.y = transform.position.y;
      Vector3 newPos = GetMouseWorldPos() + offset;

      //The player will be able to move the flags even when the game is paused
      Vector3 movement = (newPos - transform.position) * dragSpeed * Time.realtimeSinceStartup;
      transform.Translate(movement);
      transform.position = newPos;
    }
  }
}