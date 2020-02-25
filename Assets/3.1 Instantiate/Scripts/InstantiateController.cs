using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateController : MonoBehaviour
{
	public GameObject BouncyBoxPrefab;
	public GameObject StickyBoxPrefab;

	private void Update()
	{
		if(Input.GetKeyDown(KeyCode.LeftArrow))
		{
			Instantiate(BouncyBoxPrefab, new Vector3(-4f, 4f), Quaternion.identity);
		}
		else if(Input.GetKeyDown(KeyCode.RightArrow))
		{
			Instantiate(StickyBoxPrefab, new Vector3(4f, 4f), Quaternion.identity);
		}
	}
}
