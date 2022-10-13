using System;
using UnityEngine;

public class Cube_move : MonoBehaviour
{
    public float speed;
    public Vector3 target;

    private void Start()
    {
        Debug.Log(speed);
        Debug.Log(target);
    }

    private void Update()
    {
        try
        {
            var step =  speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target, step);

            if (Vector3.Distance(transform.position, target) < 0.001f)
            {
                Destroy(gameObject);
            }
        }
        catch
        {
            
        }
    }
}
