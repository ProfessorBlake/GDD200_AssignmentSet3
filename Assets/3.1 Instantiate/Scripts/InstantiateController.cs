using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateController : MonoBehaviour
{
	public GameObject BouncyBoxPrefab;
	public GameObject StickyBoxPrefab;
	public GameObject IceBoxPrefab;

	private float delay;

	private void Update()
	{
		delay = delay - Time.deltaTime;

		if (delay <= 0)
		{
			if (Input.GetMouseButton(0))
			{
				Vector3 spawnPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
				spawnPos.z = 0;
				Instantiate(BouncyBoxPrefab, spawnPos, Quaternion.identity);
				delay = 0.5f;
			}
		}
	}
}
