using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthOrb : MonoBehaviour
{
    [SerializeField] Image fillImage = null;

    // Start is called before the first frame update
    void Start()
    {
        fillImage.fillAmount = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReFillMe(float amount)
    {
        
    }
}
