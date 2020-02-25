using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{
	private void Update()
	{
		transform.localScale = Vector2.one * (Mathf.Sin(Time.time * 5f) + 2f) * 0.5f;
	}
}
