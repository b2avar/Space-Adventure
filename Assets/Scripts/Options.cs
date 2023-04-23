using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Options
{
    public static string easy = "EASY";
    public static string medium = "MEDIUM";
    public static string hard = "HARD";
    
    public static void SetEasyValue(int easy)
    {
        PlayerPrefs.SetInt(Options.easy,easy);
    }
    
    public static int GetEasyValue()
    {
        return PlayerPrefs.GetInt(Options.easy);
    }
    
    
    public static void SetMediumValue(int medium)
    {
        PlayerPrefs.SetInt(Options.medium,medium);
    }
    
    public static int GetMediumValue()
    {
        return PlayerPrefs.GetInt(Options.medium);
    }
    
    public static void SetHardValue(int hard)
    {
        PlayerPrefs.SetInt(Options.hard,hard);
    }
    
    public static int GetHardValue()
    {
        return PlayerPrefs.GetInt(Options.hard);
    }

    public static bool HasKey()
    {
        if (PlayerPrefs.HasKey(Options.easy) || PlayerPrefs.HasKey(Options.medium) || PlayerPrefs.HasKey(Options.hard) )
        {
            return true;
        }

        else
        {
            return false;
        }
    }
}
