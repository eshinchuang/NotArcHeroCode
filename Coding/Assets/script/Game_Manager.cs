using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Game_Manager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnSliderChange(float speed)
    {
        EventSystem.current.SetSelectedGameObject(null);
    }
    public void OnDropdownChange(int index)
    {
         EventSystem.current.SetSelectedGameObject(null);
    }
}
