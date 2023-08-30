using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop : MonoBehaviour
{
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
    Debug.Log(isDragging);
  }

  private Vector3 GetMouseWorldPos()
  {
    Vector3 mousePos = Input.mousePosition;
    mousePos.z = Camera.main.nearClipPlane;
    return Camera.main.ScreenToWorldPoint(mousePos);

    Debug.Log(mousePos);
  }

  private void Update()
  {
    if (isDragging)
    {
      Vector3 newPos = GetMouseWorldPos() + offset;
      transform.position = newPos;
    }
  }
}
