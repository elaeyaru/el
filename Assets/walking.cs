using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walking : MonoBehaviour
{
  public int food;
  public float speed;

  public Transform[] moveSpots;
  private int currentSpot;


  // Use this for initialization
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

    if (food == 0)
    {
      currentSpot = 0;
    }

    transform.position = Vector2.MoveTowards(transform.position, moveSpots[currentSpot].position, speed * Time.deltaTime);

    if (Vector2.Distance(transform.position, moveSpots[0].position) < 0.2f && food == 0)
    {
      food = 20;
      currentSpot = 1;
      Debug.Log(food);
    }
    if (Vector2.Distance(transform.position, moveSpots[1].position) < 0.2f && food != 0)
    {
      food = 0;
      currentSpot = 0;
      Debug.Log(food);
    }

  }
}
