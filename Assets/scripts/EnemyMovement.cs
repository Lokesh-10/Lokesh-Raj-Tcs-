using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] Transform Target;
    [SerializeField] float MovementSpeed = 10.0f;
    [SerializeField] float rotationalDamp=.5f;


    void Update()
    {
        Turn();
        Move();
    }

    void Turn()
    {
        Vector3 pos = Target.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(pos);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rotationalDamp * Time.deltaTime);
    }

     void Move()
    {
        transform.position += transform.forward* MovementSpeed * Time.deltaTime;
    }

    void OnTriggerEnter(Collider col)
    {
        GetComponent<BoxCollider>().enabled = false;
        Destroy(col.gameObject);
       
        Destroy(gameObject, 1);
        GameObject zombie = Instantiate(Resources.Load("Enemy", typeof(GameObject))) as GameObject;

      

    }
}
