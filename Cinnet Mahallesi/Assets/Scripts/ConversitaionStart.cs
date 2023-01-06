using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class ConversitaionStart : MonoBehaviour
{
    public NPCConversation conversation;
    public CharacterMovement mvm;

    void Start() 
    {
        mvm = GetComponent<CharacterMovement>();

    }

    void Awake()
    {
        ConversationManager.Instance.StartConversation(conversation);
    }

   
    void Update()
    {
        mvm.canMove = !ConversationManager.Instance.IsConversationActive;
    }
}
