using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TMP_Text raqueta1Scoretext;
    [SerializeField] private TMP_Text raqueta2Scoretext;

    [SerializeField] private Transform raqueta1Transform;
    [SerializeField] private Transform raqueta2Transform;
    [SerializeField] private Transform ballTransform;

    private int raqueta1Score;
    private int raqueta2Score;

    private static GameManager instance;

    public static GameManager Instance
    {
        get
        {
            if(instance == null)
            {
                instance = FindObjectOfType<GameManager>();
            }
            return instance;
        }
    }

    public void Raqueta1Scored()
    {
        raqueta1Score++;
        raqueta1Scoretext.text = raqueta1Score.ToString();
    }

    public void Raqueta2Scored()
    {
        raqueta2Score++;
        raqueta2Scoretext.text = raqueta2Score.ToString();
    }

    public void Restart()
    {
        raqueta1Transform.position = new Vector2(raqueta1Transform.position.x, 0);
        raqueta2Transform.position = new Vector2(raqueta2Transform.position.x, 0);
        ballTransform.position = new Vector2(0, 0);

    }
}
