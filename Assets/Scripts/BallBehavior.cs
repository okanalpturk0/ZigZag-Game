using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehavior : MonoBehaviour
{
    Vector3 direction;
    public float speed;
    public GroundSpawner gs;
    public static bool isFallDown;
    public float addSpeed;
    public float x;
    public float z;
    public float y;
    void Start()
    {
        x = Time.deltaTime * 50;
        z = 0;
        y = 0;
        direction = Vector3.forward;
        isFallDown = false;

    }
    void Update()
    {
        transform.Rotate(new Vector3(x, y ,z));

        if (transform.position.y<=0.5f)
        {
            isFallDown=true;
        }
        if(isFallDown==true)
        {
            return;
        }
        if(Input.GetMouseButtonDown(0))
        {
            if(direction.x == 0)
            {
                y = 0;
                x = 0;
                z = Time.deltaTime *180;

                direction = Vector3.left;
            }
            else
            {
                y = 0;
                z = 0;
                x = Time.deltaTime * 180;
                direction = Vector3.forward;
            }
            speed += addSpeed * Time.deltaTime;
        }
    }
    private void FixedUpdate()
    {
        Vector3 behavior = direction * Time.deltaTime * speed;
        transform.position += behavior;
    }
    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag== "ground" )
        {
            Points.points++;
            collision.gameObject.AddComponent<Rigidbody>();
            gs.groundSpawn();
            StartCoroutine(deleteGround(collision.gameObject));
        }
    }
    IEnumerator deleteGround(GameObject whicIsDeletedGround)
    {
        yield return new WaitForSeconds(1.5f);
        Destroy(whicIsDeletedGround);
    }
}

