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
      easyButton.onClick.AddListener((() =>
      {
         OptionSelected(easyButton.GetComponentInChildren<Text>().text);
      }));
      
      mediumButton.onClick.AddListener((() =>
      {
         OptionSelected(mediumButton.GetComponentInChildren<Text>().text);
      }));
      
      hardButton.onClick.AddListener((() =>
      {
         OptionSelected(hardButton.GetComponentInChildren<Text>().text);
      }));
   }

   public void OptionSelected(string _level)
   {
      switch (_level)
      {
         case "EASY":
            easyButton.interactable = false;
            mediumButton.interactable = true;
            hardButton.interactable = true;
            break;
         case "MEDIUM":
            mediumButton.interactable = false;
            easyButton.interactable = true;
            hardButton.interactable = true;
            break;
         case "HARD":
            hardButton.interactable = false;
            easyButton.interactable = true;
            mediumButton.interactable = true;
            break;
         default:
            break;
      }
   }
}
