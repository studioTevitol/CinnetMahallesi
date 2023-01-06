using System;
using System.Collections;
using System.Collections.Generic;
using DialogueEditor;
using UnityEngine;

public class StarterScript : MonoBehaviour
{
    public NPCConversation conversation;
    public CharacterMovement player;
   
    private void OnTriggerEnter2D(Collider2D col)
    {
        ConversationManager.Instance.StartConversation(conversation);
        Debug.Log("trigger enter");
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        Destroy(gameObject);
    }

    private void Update()
    {
        player.canMove = !ConversationManager.Instance.IsConversationActive;
    }
}
