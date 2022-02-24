using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
	public TMP_Text Text;

	private float ourTime = 0f;

	private void Update()
	{
		ourTime += Time.deltaTime;

		Text.text = "Score: " + Score.TotalPoints +
			"\nTime Scale: " + Time.timeScale +
			"\nTime Elapsed: " + Mathf.Round(Time.unscaledTime * 100f)/100f +
			"\nTime: " + Mathf.Round(ourTime * 100f)/100f;
	}
}
