using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{
    [SerializeField] Text score;
    float time = 0f;
    // Start is called before the first frame update
    void Start()
    {
        score.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        time = Time.timeSinceLevelLoad;
        score.text = Mathf.RoundToInt(time).ToString();
    }
}
