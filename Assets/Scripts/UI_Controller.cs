using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Controller : MonoBehaviour
{
    public GameObject TCC;
    public GameObject color_Panel;
    public GameObject picture_Panel;
    // Start is called before the first frame update
    void Start()
    {
        TCC.SetActive(true);
        color_Panel.SetActive(false);
        picture_Panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Show_TCC()
    {
        TCC.SetActive(true);
        color_Panel.SetActive(false);
        picture_Panel.SetActive(false);
    }
    public void Show_Color()
    {
        TCC.SetActive(false);
        color_Panel.SetActive(true);
        picture_Panel.SetActive(false);
    }
    public void Show_Picture()
    {
        TCC.SetActive(false);
        color_Panel.SetActive(false);
        picture_Panel.SetActive(true);
    }
}
