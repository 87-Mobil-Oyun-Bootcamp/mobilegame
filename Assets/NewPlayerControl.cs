using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPlayerControl : MonoBehaviour
{
    [Space]
    [SerializeField]
    private float speed = 1f;

    Vector3 firstTouchPos = Vector3.zero;
    Vector3 deltaTouchPos = Vector3.zero;
    Vector3 direction = Vector3.zero;

    Rigidbody body;

    void Awake()
    {
        body = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            firstTouchPos = Input.mousePosition;
        }

        if (Input.GetMouseButton(0))
        {
            deltaTouchPos = Input.mousePosition - firstTouchPos;
            direction = new Vector3(deltaTouchPos.x, 0f, deltaTouchPos.y);

            //body.velocity = direction.normalized * speed;
            body.position = Vector3.MoveTowards(body.position, direction, speed * Time.deltaTime);

            body.rotation = Quaternion.LookRotation(direction);
        }
       /* if(Input.GetMouseButtonUp(0))
        {

          
        }*/
    }

}
