using System.Collections;
using System.Collections.Generic;
using DialogueEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogueStart : MonoBehaviour
{
    public NPCConversation Conversation;
    public GameObject adriann;
    
    void Start()
    {
        ConversationManager.Instance.StartConversation(Conversation);
    }

    public void AdrianDisable()
    {
        adriann.SetActive(false);
    }

    public void AdrianTeleport()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LuciferDialogueStart()
    {
        
    }

    public void AdrianHome()
    {
        
    }

   
    void Update()
    {
        
    }
}
