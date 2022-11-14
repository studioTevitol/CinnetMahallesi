using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.Mathematics;
using UnityEngine;
using Quaternion = System.Numerics.Quaternion;
using Vector2 = UnityEngine.Vector2;
using Vector3 = UnityEngine.Vector3;

public class AIPatroling : MonoBehaviour
{
	[SerializeField] private Transform[] movePoints;
	[SerializeField] private float speed = 5f;
	[SerializeField] private bool canMoveRight = false;
	[SerializeField] private float flipAngleLeft, flipAngleRight;
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		CheckCanMoveRight();
		MoveTowards();
		//Flip();
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
		if (Vector3.Distance(transform.position, movePoints[0].position) <= 0.1f)
		{
			//transform.Rotate(0, 0, 0);

			canMoveRight = true;
			Flip();
			print("Move Right");
		}
		else if (Vector3.Distance(transform.position, movePoints[1].position) <= 0.1f)
		{
			//transform.Rotate(0, 180, 0);
			canMoveRight = false;
			Flip();
			print("Move Left");
		}
	}

	private void Flip()
	{
		if (canMoveRight)
		{
			transform.eulerAngles = new Vector3(transform.eulerAngles.x, 0, transform.eulerAngles.z);
			Debug.Log("turn right");
		}

		if (!canMoveRight)
		{
			transform.eulerAngles = new Vector3(transform.eulerAngles.x, 180, transform.eulerAngles.z);
			Debug.Log("turn left");
		}
	}

	/*private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Bullet"))
        {
            enemyHp -= 10f;
            Debug.Log("Hit   " + enemyHp);
        }
    }*/
}
