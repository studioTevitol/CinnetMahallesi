using System;
using System.Collections;
using System.Collections.Generic;
using DialogueEditor;
using Mono.Cecil;
using Unity.VisualScripting;
using UnityEngine;

public class Conversation_ : MonoBehaviour
{
    public NPCConversation a;
    private void OnTriggerEnter2D(Collider2D col)
    {
        ConversationManager.Instance.StartConversation(a);
    }
}
