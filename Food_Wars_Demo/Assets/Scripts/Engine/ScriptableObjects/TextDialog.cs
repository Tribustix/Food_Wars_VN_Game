using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "TextDialog")]
public class TextDialog : ScriptableObject
{
    [SerializeField] string characterName;
    [TextArea(14, 10)] [SerializeField] string storyText;
    

    public string GetStoryText() {

        return storyText;
    }

    public string GetStoryCharacterName() {
        
        return characterName;
    }


}

