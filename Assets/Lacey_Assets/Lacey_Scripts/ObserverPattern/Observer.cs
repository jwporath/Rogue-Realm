using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Observer : MonoBehaviour
{
    [SerializeField] private string eventTypeToObserve;
    private Text textToUpdate;
    private Player player;
    private void Awake()
    {
        player=FindObjectOfType<Player>();
        textToUpdate=GetComponentInChildren<Text>();
        // Subscribe to the player's event
        if (player!=null)
        {
            // player.ThingHappened += OnThingHappened;
            switch (eventTypeToObserve)
            {
                case "Coin":
                    player.ThingHappened += OnCoinPickedUp;
                    break;
                case "Speed":
                    player.ThingHappened += OnSpeedIncreased;
                    break;
                case "Jump":
                    player.ThingHappened += OnJumpPowerIncreased;
                    break;
            }
        }
    }

    private void OnDestroy()
    {
        // Unsubscribe when the observer is destroyed
        if (player != null)
        {
            // player.ThingHappened -= OnThingHappened;
            switch (eventTypeToObserve)
            {
                case "Coin":
                    player.ThingHappened -= OnCoinPickedUp;
                    break;
                case "Speed":
                    player.ThingHappened -= OnSpeedIncreased;
                    break;
                case "Jump":
                    player.ThingHappened -= OnJumpPowerIncreased;
                    break;
            }        
        }
    }

    // Event handling methods for different event types
    private void OnCoinPickedUp(string eventType, float num)
    {
        // Update the UI text element only if it's observing the "Coin" event
        if (eventType == "Coin")
        {
            textToUpdate.text = num.ToString();
        }
    }

    private void OnSpeedIncreased(string eventType, float num)
    {
        // Update the UI text element only if it's observing the "Speed" event
        if (eventType == "Speed")
        {
            textToUpdate.text = num.ToString();
        }
    }

    private void OnJumpPowerIncreased(string eventType, float num)
    {
        // Update the UI text element only if it's observing the "Jump" event
        if (eventType == "Jump")
        {
            textToUpdate.text = num.ToString();
        }
    }
}
