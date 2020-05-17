using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager: MonoBehaviour
{
    [SerializeField] Text dialogText;
    [SerializeField] Text characterName;
    [SerializeField] TextDialog storyTextRef;
    TextDialog storyText;

    void Start()
    {
        
        SetStoryTextRef();
        SetStoryInformation();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetStoryTextRef(){
        storyText = storyTextRef;
    }

    void SetStoryInformation() {

        characterName.text = storyText.GetStoryCharacterName();
        dialogText.text = storyText.GetStoryText();
    }

}
