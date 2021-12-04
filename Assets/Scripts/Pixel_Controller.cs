using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pixel_Controller : MonoBehaviour
{
	private SpriteRenderer sprRen;
	private Color n_color=Color.red;
	private bool _isChoose=false;

	public Choose_Color choose_Color;
	// Start is called before the first frame update
    void Start()
    {
		sprRen=GetComponent<SpriteRenderer>();
		choose_Color=FindObjectOfType<Choose_Color>();
    }

    // Update is called once per frame
    void Update()
    {
		
    }
	private void OnMouseDown()
	{
		if(_isChoose==false)
		{
			n_color=choose_Color.chooseColor;
			sprRen.color=n_color;
			_isChoose=true;
		}
		else
		{
			sprRen.color=Color.white;
			_isChoose=false;
		}

	}
}
