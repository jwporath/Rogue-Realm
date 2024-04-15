using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; 
using UnityEngine.UI; 
using UnityEngine.SceneManagement; 
// using TMPro;

public class BCButton : ClickyButton
{  
    [SerializeField] private Player player;
    // [SerializeField] private TextMeshProUGUI playText; 
    [SerializeField] private Text playText; 
    [SerializeField] private Vector3 moveOffset; 

    // public void OnPointerDown(PointerEventData eventData) {          // STATIC BIND
    public override void OnPointerDown(PointerEventData eventData) {    // DYNAMIC BIND
        img.sprite = pressed; 
        // audioSource.PlayOneShot(compressClip); 
        if (playText != null) { 
            playText.rectTransform.localPosition += moveOffset; 
        } 
    }

    // public void OnPointerUp(PointerEventData eventData){             // STATIC BIND
    public override void OnPointerUp(PointerEventData eventData){       // DYNAMIC BIND
        img.sprite=up; 
        // buttonText=GetComponent<TMP_Text>();
        // audioSource.PlayOneShot(uncompressClip); 
        if (playText != null) 
        { 
            playText.rectTransform.localPosition -= moveOffset; 
        } 
    } 

    public void BCSet(){
        if(player.getBC()==false) player.BCModeON();
        else player.BCModeOFF();
    }
} 
