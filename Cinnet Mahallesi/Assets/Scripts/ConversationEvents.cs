using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversationEvents : MonoBehaviour
{
    public GameObject demon;
    public void Next()
    {
        Destroy(demon);
    }
}
