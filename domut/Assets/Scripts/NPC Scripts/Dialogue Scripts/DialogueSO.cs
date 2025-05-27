using UnityEngine;

[CreateAssetMenu(fileName = "DialogueSO", menuName = "Dialogue/DialogueNode")]
public class DialogueSO : ScriptableObject
{
    public DialogueLine[] dialogueLines;
}

[System.Serializable]
public class DialogueLine
{
    public ActorSO speaker;
    [TextArea(2, 4)] public string text; // adds scrollable bar to UI if text takes up more than 4 lines
}