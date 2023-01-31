using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ManagerPoint : MonoBehaviour
{

    // Gestion UI
    public TextMeshProUGUI pointDisplay;
    public TextMeshProUGUI pointDisplayIdle;
    public TextMeshProUGUI pointDisplayClick;


    public float totalPoint;
    public float numberClick;
    public float numberIdle;


    public bool multiClickActif=false;
    public bool multiIdleActif=false;

    // Start is called before the first frame update
    void Start()
    {
        pointDisplay.text = "Pierre magique : " + totalPoint.ToString(); 
        pointDisplayIdle.text = "Idle: " + numberIdle.ToString(); 
        pointDisplayClick.text = "Click: " + numberClick.ToString();

        InvokeRepeating("IdlePlayer",1f,1f);
    }

    public void clickPlayer(){
        if (multiClickActif){
            totalPoint=totalPoint+numberClick*10;
        }else{
            totalPoint=totalPoint+numberClick;
        }
        pointDisplay.text = "Pierre magique: " + totalPoint.ToString("#.00");
    }

    public void IdlePlayer(){
        if (multiIdleActif){
            totalPoint=totalPoint+numberIdle*10;
        }else{
            totalPoint=totalPoint+numberIdle;
        }
        pointDisplay.text = "Pierre magique: " + totalPoint.ToString("#.00"); 
    }

    public void increaseClick(float priceIncrease, float valueIncrease){
        totalPoint=totalPoint-priceIncrease;
        pointDisplay.text = "Pierre magique: " + totalPoint.ToString("#.00"); 

        numberClick=numberClick+valueIncrease;
        pointDisplayClick.text = "Click: " + numberClick.ToString("#.00");
    }

    public void increaseIdle(float priceIncreaseIdle, float valueIncreaseIdle){
        totalPoint=totalPoint-priceIncreaseIdle;
        pointDisplay.text = "Pierre magique: " + totalPoint.ToString("#.00"); 

        numberIdle=numberIdle+valueIncreaseIdle;
        pointDisplayIdle.text = "Idle:" + numberIdle.ToString("#.00");
    }
}