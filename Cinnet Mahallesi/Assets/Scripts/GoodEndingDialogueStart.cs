using System;
using System.Collections;
using System.Collections.Generic;
using DialogueEditor;
using UnityEngine;

public class GoodEndingDialogueStart : MonoBehaviour
{
  [SerializeField] public NPCConversation a;

  private void Start()
  {
    ConversationManager.Instance.StartConversation(a);
  }
}
