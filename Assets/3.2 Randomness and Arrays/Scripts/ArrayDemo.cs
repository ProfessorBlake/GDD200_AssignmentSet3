using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayDemo : MonoBehaviour
{
	public float[] arr;

	private void Start()
	{
		arr = new float[1000];

		for(int i = 0; i < arr.Length; i++)
		{
			arr[i] = i * Random.value;
		}
	}
}
