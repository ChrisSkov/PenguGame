using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class CollectCoin : MonoBehaviour
{
    [SerializeField] int totalPoints;
    int startingPoints = 0;
    [SerializeField] TMP_Text pointsText;
    // Start is called before the first frame update
    void Start()
    {
        totalPoints = startingPoints;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int GetTotalPoints()
    {
        return totalPoints;
    }

    public void CollectACoin(PickUpScriptObj coinObj)
    {
        totalPoints += coinObj.points;
        UpdatePoints();
    }

    void UpdatePoints()
    {
        pointsText.text = totalPoints.ToString();
    }
}
