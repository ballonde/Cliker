using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DataButtonAmelioration : MonoBehaviour
{   
    
    public TextMeshProUGUI prixAugmentationBouton;
    public TextMeshProUGUI LevelAugmentationObjet;
    public TextMeshProUGUI EffetObjet;
    public TextMeshProUGUI NameObjet;

    public float prixAugmentation;
    public float valeurAugmentation;
    public float LvAugmentation;
    public float ratioPrixAugmentation;
    public float ratioValeurAugmentation;
    public string type;
    public float totalEffect;
    public string name; 




    // Start is called before the first frame update
    void Start()
    {
        prixAugmentationBouton.text = "" + prixAugmentation.ToString();
        LevelAugmentationObjet.text = "Lv:" + LvAugmentation.ToString();
        EffetObjet.text = "" + totalEffect.ToString();
        NameObjet.text = "" + name.ToString();
    }
}
