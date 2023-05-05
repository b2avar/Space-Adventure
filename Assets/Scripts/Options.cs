using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Options
{
    public static string easy = "easy";
    public static string medium = "medium";
    public static string hard = "hard";
 
    public static string easyScore = "easyScore";
    public static string mediumScore = "mediumScore";
    public static string hardScore = "hardScore";

    public static string easyToken = "easyToken";
    public static string mediumToken = "mediumToken";
    public static string hardToken = "hardToken";

    public static string musicOpen = "musicOpen";

    
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
    
    
    public static void SetEasyScoreValue(int easyScore)
    {
        PlayerPrefs.SetInt(Options.easyScore,easyScore);
    }
    
    public static int GetEasyScoreValue()
    {
        return PlayerPrefs.GetInt(Options.easyScore);
    }
    
    
    public static void SetMediumScoreValue(int mediumScore)
    {
        PlayerPrefs.SetInt(Options.mediumScore,mediumScore);
    }
    
    public static int GetMediumScoreValue()
    {
        return PlayerPrefs.GetInt(Options.mediumScore);
    }
    
    public static void SetHardScoreValue(int hardScore)
    {
        PlayerPrefs.SetInt(Options.hardScore,hardScore);
    }
    
    public static int GetHardScoreValue()
    {
        return PlayerPrefs.GetInt(Options.hardScore);
    }
    
    
    public static void SetEasyTokenValue(int easyToken)
    {
        PlayerPrefs.SetInt(Options.easyToken,easyToken);
    }
    
    public static int GetEasyTokenValue()
    {
        return PlayerPrefs.GetInt(Options.easyToken);
    }
    
    
    public static void SetMediumTokenValue(int mediumToken)
    {
        PlayerPrefs.SetInt(Options.mediumToken,mediumToken);
    }
    
    public static int GetMediumTokenValue()
    {
        return PlayerPrefs.GetInt(Options.mediumToken);
    }
    
    public static void SetHardTokenValue(int hardToken)
    {
        PlayerPrefs.SetInt(Options.hardToken,hardToken);
    }
    
    public static int GetHardTokenValue()
    {
        return PlayerPrefs.GetInt(Options.hardToken);
    }
    
    
    public static void SetMusicOpenValue(int musicOpen)
    {
        PlayerPrefs.SetInt(Options.musicOpen,musicOpen);
    }
    
    public static int GetMusicOpenValue()
    {
        return PlayerPrefs.GetInt(Options.musicOpen);
    }




    public static bool SettingsHasKey()
    {
        if (PlayerPrefs.HasKey(Options.easy) || PlayerPrefs.HasKey(Options.medium)|| PlayerPrefs.HasKey(Options.hard))
        {
            return true;
        }

        else
        {
            return false;
        }
    }

    public static bool MusicHaskey()
    {
        if (PlayerPrefs.HasKey(Options.musicOpen))
        {
            return true;
        }

        else
        {
            return false;
        }
    }
}
