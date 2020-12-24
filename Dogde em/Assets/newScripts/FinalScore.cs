using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FinalScore : MonoBehaviour
{
    public newScore ns;
    public TextMeshProUGUI score;
    // Start is called before the first frame update
    void Start()
    {
        float pos = ns.getScore();
        score.text = pos.ToString("0");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
