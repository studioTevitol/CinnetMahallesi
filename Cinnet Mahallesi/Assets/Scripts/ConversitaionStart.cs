using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class ConversitaionStart : MonoBehaviour
{
    public NPCConversation conversation;
    public CharacterMovement player;
    void Start()
    {
        ConversationManager.Instance.StartConversation(conversation);
    }

   
    private void Update()
    {
        player.canMove = !ConversationManager.Instance.IsConversationActive;
    }
}
