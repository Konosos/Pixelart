using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choose_Color : MonoBehaviour
{
	public Color chooseColor=Color.red;

	public void ChooseRed()
	{
		chooseColor=Color.red;
	}
	public void ChooseGreen()
	{
		chooseColor=Color.green;
	}
	public void ChooseYellow()
	{
		chooseColor=Color.yellow;
	}
	public void ChooseBlue()
	{
		chooseColor=Color.blue;
	}
	public void ChooseBlack()
	{
		chooseColor=Color.black;
	}
	public void ChooseGray()
	{
		chooseColor=Color.gray;
	}
}
