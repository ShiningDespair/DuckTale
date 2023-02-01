using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class OptionsManager : MonoBehaviour
{
    public Toggle fullScreenTog;
    public Toggle vsyncTog;

    public List<ResItem> resolutions = new List<ResItem>();
    public int selectedRes;

    public TMP_Text resolutionSize;

    // Start is called before the first frame update
    void Start()
    {
        fullScreenTog.isOn = Screen.fullScreen;

        if(QualitySettings.vSyncCount == 0)
        {
            vsyncTog.isOn = false;
        } else
        {
            vsyncTog.isOn = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResLeft()
    {
        selectedRes++;
        if (selectedRes > resolutions.Count - 1)
        {
            selectedRes = resolutions.Count - 1;
        }
        updateResolutionSize();
    }

    public void ResRight()
    {
        selectedRes--;
        if (selectedRes == 0)
        {
            selectedRes = 0;
        }
        updateResolutionSize();
    }

    public void updateResolutionSize()
    {
        resolutionSize.text = resolutions[selectedRes].horizontal.ToString() + "x" + resolutions[selectedRes].vertical.ToString();
    }

    public void DuckHeadsLinkedIn()
    {
        Application.OpenURL("https://www.linkedin.com/company/duckheads-studios/");
    }

    public void ApplyButton()
    {
        Screen.fullScreen = fullScreenTog.isOn;

        if(vsyncTog.isOn)
        {
            QualitySettings.vSyncCount = 1;
        } else
        {
            QualitySettings.vSyncCount = 0;
        }
     }
}

[System.Serializable]
public class ResItem
{
    public int horizontal, vertical;
}