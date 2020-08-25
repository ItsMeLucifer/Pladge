using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Your : MonoBehaviour
{
    Text yourscore;
    public GameObject YOURSCORE;
    public float your1 = 0;
    string score;
    void Awake()
    {
        GameObject platforma = GameObject.Find("platforma");
        SaveLoad saveload = platforma.GetComponent<SaveLoad>();
        your1 = saveload.points;
        Destroy(platforma);
    }
    void Start()
    {
        yourscore = YOURSCORE.GetComponent<Text>();
        score = your1.ToString();
        yourscore.text = score;
    }
}
