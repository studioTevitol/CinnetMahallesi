using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.Mathematics;
using UnityEngine;
using Quaternion = System.Numerics.Quaternion;
using Vector2 = UnityEngine.Vector2;
using Vector3 = UnityEngine.Vector3;

public class EnemyAIPatrol : MonoBehaviour
{
    [SerializeField] private Transform[] movePoints;
    [SerializeField] private float speed = 5f;
    [SerializeField] private bool canMoveRight, isPlayerDetected = false;
    [SerializeField] private float shootRange = 10f;
    [SerializeField] private bool haveShoot = false;
    [SerializeField] private Transform FirePoint;

    //[SerializeField] private Transform movePoint1Pos, movePoint0Pos;
    //EnemyBullet Variables
    [SerializeField] private GameObject playerObj, bulletObj;
    [SerializeField] private float fireRate;
    
    void Start()
    {
        //movePoint1Pos = movePoints[1].transform;
        //movePoint0Pos = movePoints[0].transform;

        fireRate = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        //movePoints[1].transform.position = movePoint1Pos.position;
        //movePoints[0].transform.position = movePoint0Pos.position;
        CheckCanMoveRight();
        MoveTowards();
        DetectThePlayer();
        StartCoroutine(CheckIfTimeToFire());

    }

    private void MoveTowards()
    {
        if (canMoveRight)
        {
            transform.position = Vector3.MoveTowards(transform.position, movePoints[1].position, speed * Time.deltaTime);
            
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, movePoints[0].position, speed * Time.deltaTime);
        }
    }
    
    private void CheckCanMoveRight()
    {
        if (Vector3.Distance(transform.position,movePoints[0].position) <= 0.1f)
        {
            transform.Rotate(0, 180, 0);

            canMoveRight = true;
            print("Move Right");
        }
        else if (Vector3.Distance(transform.position, movePoints[1].position) <= 0.1f)
        {
            transform.Rotate(0, -180, 0);
            canMoveRight = false;
            print("Move Left");
        }
    }

    
    //Gun
    private void DetectThePlayer()
    {
        if (Vector3.Distance(transform.position, playerObj.transform.position) <= shootRange)
        {
            isPlayerDetected = true;
            //print("Player detected!");

        }
        else{isPlayerDetected = false;}
    }
    
    IEnumerator CheckIfTimeToFire()
    {
        if (isPlayerDetected && !haveShoot)
            {
                FirePointAim();
                Instantiate(bulletObj, FirePoint.position, FirePoint.rotation);
                haveShoot = true;
                Debug.Log("fire");
                yield return new WaitForSeconds(fireRate);
                haveShoot = false;
            }
        else
        {
            StopCoroutine(CheckIfTimeToFire());
        }
    }
    
    //Firepoint
    private void FirePointAim()
    {
        
        FirePoint.right = playerObj.transform.position - FirePoint.position;
    }
}
