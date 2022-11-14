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
    }

    private void Update()
    {
        player.canMove = !ConversationManager.Instance.IsConversationActive;
    }
}