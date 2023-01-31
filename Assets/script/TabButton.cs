using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Image))]
public class TabButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    public TabGroup tabGroup;
    public Image background;
    // Start is called before the first frame update
    void Start()
    {
      background = GetComponent<Image>();
      tabGroup.Suscribe(this);
    }


    public void OnPointerEnter(PointerEventData eventData){
        tabGroup.OnTabEnter(this);
    }
    public void OnPointerClick(PointerEventData eventData){
        tabGroup.OnTabSelected(this);
    }
    public void OnPointerExit(PointerEventData eventData){
        tabGroup.OnTabExit(this);
    }
    // Update is called once per frame
    public void Select(){

    }
    public void Deselect(){
        
    }
}
