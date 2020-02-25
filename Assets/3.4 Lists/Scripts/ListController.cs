using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListController : MonoBehaviour
{
	public List<string> Students;

	private void Start()
	{
		Students = new List<string>()
		{
			"Alex",
			"Bryan",
			"Corey"
		};
		PrintList();

		Students.Add("Devin");
		PrintList();

		Students.Remove("Bryan");
		PrintList();

		List<string> NewStudents = new List<string>() { "Eric", "Fran", "Garry" };
		Students.AddRange(NewStudents);
		PrintList();
	}

	private void PrintList()
	{
		string s = "Printing list:\n";
		foreach(string name in Students)
		{
			s += name + "\n";
		}
		Debug.Log(s);
	}
}
