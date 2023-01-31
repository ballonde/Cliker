using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabGroup : MonoBehaviour
{

    public PanelGroup panelGroup;
    public List<TabButton> tabButtons;
    public Sprite tabIdle;
    public Sprite tabHover;
    public Sprite tabActive;
    public TabButton tabSelected;
    public List<GameObject> objectsToSwap;
    // Start is called before the first frame update

    public void Suscribe(TabButton button){
        if(tabButtons==null){
            tabButtons=new List<TabButton>();
        }
        tabButtons.Add(button);
    }

    public void OnTabEnter(TabButton button){
        ResetTab();
        button.background.sprite=tabHover;
        //button.background.material.color = Color.blue;
        //m_Rigidbody.GetComponent<Renderer>().material.color = Color.white;

    }

    public void OnTabExit(TabButton button){
        ResetTab();
    }

    public void OnTabSelected(TabButton button){
        if(tabSelected!=null){
            tabSelected.Deselect();
        }
        if (tabSelected==button){
            tabSelected=null;
        }else{
            tabSelected=button;
        }

        tabSelected.Select();

        ResetTab();
        button.background.sprite=tabActive;
        //button.background.material.color = Color.red;
        int index=button.transform.GetSiblingIndex();
        for (int i=0; i<objectsToSwap.Count; i++){
            if(i==index){
                objectsToSwap[i].SetActive(true);
            }else{
                objectsToSwap[i].SetActive(false);
            }
        }

        if(panelGroup!=null){
            panelGroup.SetPageIndex(tabSelected.transform.GetSiblingIndex());
        }
    }    

    public void ResetTab(){
        foreach(TabButton button in tabButtons){
            if (tabSelected!=null && tabSelected!=button){
                button.background.sprite=tabIdle;
            }
            //button.background.material.color = Color.white;
            //m_Rigidbody.GetComponent<Renderer>().material.color = Color.white;

        }
    }
}
