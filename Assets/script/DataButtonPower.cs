using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DataButtonPower : MonoBehaviour
{   
    public ManagerPoint managerPoint;
    
    public TextMeshProUGUI EffetObjet;
    public TextMeshProUGUI NameObjet;
    public TextMeshProUGUI CooldownObjet;
    public TextMeshProUGUI DurationObjet;

    public string name;
    public string description;
    public float cooldown;
    public float duration;
    public bool cooldownActif=false;
    public bool durationActif=false;

    private float timerDuration=0;
    private float timerCooldown=0;



    // Start is called before the first frame update
    void Start()
    {
        NameObjet.text = "" + name.ToString();
        EffetObjet.text=description.ToString();
        CooldownObjet.text="Cooldown:"+cooldown.ToString()+"s";
        DurationObjet.text="Duration:"+duration.ToString()+"s";
    }

    void Update(){
        if(durationActif){
            timerDuration+= Time.deltaTime;

            if (timerDuration>=duration){
                timerDuration=0;
                cooldownActif=true;
                durationActif=false;
                if (managerPoint.multiClickActif){
                    managerPoint.multiClickActif=false;
                }
                if(managerPoint.multiIdleActif){
                    managerPoint.multiIdleActif=false;
                }
            }
            DurationObjet.text="Duration:"+(duration-timerDuration).ToString("#.0")+"s";
        }
        if(cooldownActif){
            timerCooldown+= Time.deltaTime;

            if (timerCooldown>=duration){
                timerCooldown=0;
                cooldownActif=false;
            }
            CooldownObjet.text="Cooldown:"+(cooldown-timerCooldown).ToString("#.0")+"s";
        }
    }

    // Update is called once per frame
    public void effectMultiClick()
    {
        if (cooldownActif==false && durationActif==false){
            durationActif=true;
            managerPoint.multiClickActif=true;
        }
    }

    public void effectMultiIdle()
    {
        if (cooldownActif==false && durationActif==false){
            durationActif=true;
            managerPoint.multiIdleActif=true;
        }
    }
}
