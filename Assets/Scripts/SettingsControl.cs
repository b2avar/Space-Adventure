using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SettingsControl : MonoBehaviour
{
   [SerializeField] private Button easyButton, mediumButton, hardButton;
   
   public void MainMenu()
   {
      SceneManager.LoadScene("Menu");
   }

   private void Start()
   {
      if (Options.GetEasyValue() == 1)
      {
         easyButton.interactable = false;
         mediumButton.interactable = true;
         hardButton.interactable = true;
      }
      
      if (Options.GetMediumValue() == 1)
      {
         mediumButton.interactable = false;
         easyButton.interactable = true;
         hardButton.interactable = true;
      }
      
      if (Options.GetHardValue() == 1)
      {
         hardButton.interactable = false;
         easyButton.interactable = true;
         mediumButton.interactable = true;
      }
   }

   public void OptionSelected(string _level)
   {
      switch (_level)
      {
         case "easy":
            Options.SetEasyValue(1);
            Options.SetMediumValue(0);
            Options.SetHardValue(0);
            easyButton.interactable = false;
            mediumButton.interactable = true;
            hardButton.interactable = true;
            break;
         case "medium":
            Options.SetMediumValue(1);
            Options.SetEasyValue(0);
            Options.SetHardValue(0);
            mediumButton.interactable = false;
            easyButton.interactable = true;
            hardButton.interactable = true;
            break;
         case "hard":
            Options.SetHardValue(1);
            Options.SetEasyValue(0);
            Options.SetMediumValue(0);
            hardButton.interactable = false;
            easyButton.interactable = true;
            mediumButton.interactable = true;
            break;
         default:
            break;
      }
   }
}
