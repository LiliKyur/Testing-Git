using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Testing : MonoBehaviour
{
	[SerializeField] Text GameTitle;


	private void Start()
	{
		GameTitle.text = "First Test";
	}
}
