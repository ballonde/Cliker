using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AchatOutils : MonoBehaviour
{

    public ManagerPoint managerClick;

    public TextMeshProUGUI prixAugmentationBoutonActuel;

    public TextMeshProUGUI levelActuel;
    public TextMeshProUGUI effectActuel;

    public float prixAugmentationActuel;
    public float valeurAugmentationActuel;
    public float LvAugmentationActuel;
    public string typeActuel;
    public float totalEffectActuel;

    public DataButtonAmelioration m_dataButton;

    public void effetBoutonClick(GameObject self){
        m_dataButton = self.GetComponent<DataButtonAmelioration>();
        prixAugmentationActuel=m_dataButton.prixAugmentation;
        valeurAugmentationActuel=m_dataButton.valeurAugmentation;
        prixAugmentationBoutonActuel=m_dataButton.prixAugmentationBouton;
        LvAugmentationActuel=m_dataButton.LvAugmentation;
        typeActuel=m_dataButton.type;
        levelActuel=m_dataButton.LevelAugmentationObjet;
        effectActuel=m_dataButton.EffetObjet;
        totalEffectActuel=m_dataButton.totalEffect;

        if (prixAugmentationActuel<=managerClick.totalPoint){
            if(typeActuel=="click"){
                managerClick.increaseClick(prixAugmentationActuel, valeurAugmentationActuel);
            }else if(typeActuel=="idle"){
                managerClick.increaseIdle(prixAugmentationActuel, valeurAugmentationActuel);
            }

            m_dataButton.prixAugmentation=m_dataButton.prixAugmentation+(m_dataButton.prixAugmentation/3);
            m_dataButton.prixAugmentationBouton.text = m_dataButton.prixAugmentation.ToString("#.00");
            prixAugmentationBoutonActuel.text = "" + m_dataButton.prixAugmentation.ToString("#.00");

            m_dataButton.LvAugmentation=LvAugmentationActuel+1;
            levelActuel.text = "Lv:" + m_dataButton.LvAugmentation.ToString();

            m_dataButton.totalEffect=totalEffectActuel+valeurAugmentationActuel;
            effectActuel.text = "" + m_dataButton.totalEffect.ToString();
        }
    }
}
