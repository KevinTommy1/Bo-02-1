using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Dotty : MonoBehaviour
{
	Rigidbody2D rb;
	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}
	void Update()
	{
		Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		Vector3 direction = mousePosition - transform.position;
		float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
		//transform.rotation  = Quaternion.AngleAxis(angle, Vector3.forward);
		rb.rotation = angle;
	}
}

