using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerButton : MonoBehaviour
{
    public Text answerText;
    private AnswerData answerData;
    private GameController gameController;
    private Button btn;
    // Start is called before the first frame update
    void Start()
    {
        gameController = FindObjectOfType<GameController>();
        btn = gameObject.GetComponent<Button>();
        btn.onClick.AddListener(HandleClick);
    }

    public void Setup(AnswerData data)
    {
        answerData = data;
        answerText.text = answerData.answerText;
    }
     public void HandleClick()
    {
        gameController.AnswerButtonClicked(answerData.isCorrect);
    }
}
