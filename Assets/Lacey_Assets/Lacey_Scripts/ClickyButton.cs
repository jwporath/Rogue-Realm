using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; 
using UnityEngine.UI; 
using UnityEngine.SceneManagement; 

public class ClickyButton : MonoBehaviour, IPointerUpHandler, IPointerDownHandler 
{
    [SerializeField] private Image img; 
    [SerializeField] private Sprite up, pressed;    
    // [SerializeField] private AudioClip compressClip, uncompressClip; 
    // [SerializeField] private AudioSource audioSource; 

    public void OnPointerDown(PointerEventData eventData) { 
        img.sprite = pressed; 
        // audioSource.PlayOneShot(compressClip); 
    } 

    public void OnPointerUp(PointerEventData eventData){ 
        img.sprite=up; 
        // buttonText=GetComponent<TMP_Text>();
        // audioSource.PlayOneShot(uncompressClip); 
    } 

    public void SwitchScene(string sceneName){ 
        SceneManager.LoadScene(sceneName); 
    } 
    public void LeaveTheGame(){ 
        Application.Quit(); 
    } 
} 
