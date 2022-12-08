using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RateUs : MonoBehaviour
{
    public string ANDROID_OTHER1_URL = "market://details?id=com.ra.Hold";
    public string ANDROID_OTHER2_URL = "market://details?id=com.ra.HorizonHill";
    public string ANDROID_OTHER3_URL = "market://details?id=com.ra.StarScraper";
    public string ANDROID_OTHER4_URL = "market://details?id=com.ra.MVPChallenge";
    public string ANDROID_OTHER5_URL = "market://details?id=com.Turned.tn";

    public void PressedButtonOther1()
    {
#if UNITY_ANDROID
        Application.OpenURL(ANDROID_OTHER1_URL);
        Debug.Log("Rate on Android");
#elif UNITY_IOS
        Application.OpenURL(IOS_RATE_URL);
                Debug.Log("Rate on Iphone");
#endif
    }

    public void PressedButtonOther2()
    {
#if UNITY_ANDROID
        Application.OpenURL(ANDROID_OTHER2_URL);
        Debug.Log("Rate on Android");
#elif UNITY_IOS
        Application.OpenURL(IOS_RATE_URL);
                Debug.Log("Rate on Iphone");
#endif
    }

    public void PressedButtonOther3()
    {
#if UNITY_ANDROID
        Application.OpenURL(ANDROID_OTHER3_URL);
        Debug.Log("Rate on Android");
#elif UNITY_IOS
        Application.OpenURL(IOS_RATE_URL);
                Debug.Log("Rate on Iphone");
#endif
    }

    public void PressedButtonOther4()
    {
#if UNITY_ANDROID
        Application.OpenURL(ANDROID_OTHER4_URL);
        Debug.Log("Rate on Android");
#elif UNITY_IOS
        Application.OpenURL(IOS_RATE_URL);
                Debug.Log("Rate on Iphone");
#endif
    }

    public void PressedButtonOther5()
    {
#if UNITY_ANDROID
        Application.OpenURL(ANDROID_OTHER5_URL);
        Debug.Log("Rate on Android");
#elif UNITY_IOS
        Application.OpenURL(IOS_RATE_URL);
                Debug.Log("Rate on Iphone");
#endif
    }
}
