using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
	public Rigidbody2D Rb;

	private string myMessage = "";

	public void Launch(Vector2 moveVector, string message)
	{
		Rb.velocity = moveVector;
		myMessage = message;
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.CompareTag("Lava"))
		{
			Debug.Log(myMessage);
			Destroy(this.gameObject);
		}
	}
}
