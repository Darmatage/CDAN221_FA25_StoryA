using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene2aDialogue : MonoBehaviour {
// These are the script variables.
// For more character images / buttons, copy & renumber the variables:
        public int primeInt = 1;        // This integer drives game progress!
        public TMP_Text Char1name;
        public TMP_Text Char1speech;
        public TMP_Text Char2name;
        public TMP_Text Char2speech;
       //public TMP_Text Char3name;
       //public TMP_Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1a;
       public GameObject ArtChar1b;
       public GameObject ArtChar1c;
       public GameObject ArtChar1d;
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
        public GameObject NextScene3Button;
        public GameObject NextScene4Button;
        public GameObject NextScene5Button;
        public GameObject NextScene6Button;
        public GameObject nextButton;
       //public AudioSource audioSource1;
        private bool allowSpace = true;

// Set initial visibility. Added images or buttons need to also be SetActive(false);
        void Start(){  
             DialogueDisplay.SetActive(false);
             ArtChar1a.SetActive(false);
             ArtChar1b.SetActive(false);
             ArtChar1c.SetActive(false);
             ArtChar1d.SetActive(false);
             ArtBG1.SetActive(true);
             Choice1a.SetActive(false);
             Choice1b.SetActive(false);
             NextScene1Button.SetActive(false);
             NextScene2Button.SetActive(false);
             NextScene3Button.SetActive(false);
             NextScene4Button.SetActive(false);
             NextScene5Button.SetActive(false);
             NextScene6Button.SetActive(false);
             nextButton.SetActive(true);
        }

// Use the spacebar as a faster "Next" button:
        void Update(){        
             if (allowSpace == true){
                 if (Input.GetKeyDown("space")){
                      Next();
                 }

                 // secret debug code: go back 1 Story Unit, if NEXT is visible
                 if (Input.GetKeyDown("p")) {
                      primeInt -= 2;
                      Next();
                 }
             }
        }

        //Story Units! The main story function.
        //Players hit [NEXT] to progress to the next primeInt:
        public void Next() {
                primeInt += 1;
                if (primeInt == 1)
                {
                        // audioSource1.Play();
                }
                else if (primeInt == 2)
                {
                        if (GameHandler.BeenToMall == true)
                        {
                                primeInt = 100;
                                DialogueDisplay.SetActive(true);
                                Char1name.text = "YOU";
                                Char1speech.text = "Well, that failed. Time to try again?";
                                Char2name.text = "";
                                Char2speech.text = "";
                        }
                        else if (GameHandler.BeenToMall == false)
                        {
                                GameHandler.BeenToMall = true;
                                ArtChar1b.SetActive(true);
                                DialogueDisplay.SetActive(true);
                                Char1name.text = "";
                                Char1speech.text = "";
                                Char2name.text = "George";
                                Char2speech.text = "Hay! Good too see you!";
                        }
                }
                else if (primeInt == 3)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "Hi George, so what did you get Alex for their birthday?";
                        Char2name.text = "";
                        Char2speech.text = "";

                }
                else if (primeInt == 4)
                {
                        ArtChar1b.SetActive(false);
                        ArtChar1d.SetActive(true);
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "George";
                        Char2speech.text = "Well, as you know...";
                }
                else if (primeInt == 5)
                {
                        ArtChar1d.SetActive(false);
                        ArtChar1a.SetActive(true);
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "George";
                        Char2speech.text = "(Very Serious) Alex is deathly allergic to candles.";
                }
                else if (primeInt == 6)
                {
                        ArtChar1d.SetActive(false);
                        ArtChar1c.SetActive(true);
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "George";
                        Char2speech.text = "So I got them a chair!";
                        nextButton.SetActive(false);
                        allowSpace = false;
                        Choice1a.SetActive(true); // function Choice1aFunct()
                        Choice1b.SetActive(true); // function Choice1bFunct()
                }



   //choice 1a 
                else if (primeInt == 7)
                {
                        ArtChar1c.SetActive(false);
                        ArtChar1a.SetActive(true);
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "George";
                        Char2speech.text = "Well, you're being really rude today.";
                        primeInt = 8;
                }

    //choice 1b                
                else if (primeInt == 8)
                {
                         ArtChar1c.SetActive(false);
                        ArtChar1b.SetActive(true);
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "George";
                        Char2speech.text = "Right?! I knew you would agree!";
                        // Turn off the "Next" button, turn on "Choice" buttons
                }
   //after both choices
                else if (primeInt == 9)
                {
                        //gameHandler.AddPlayerStat(1);
                         ArtChar1a.SetActive(false);
                        ArtChar1b.SetActive(false);
                         ArtChar1d.SetActive(true);
                        ArtChar1c.SetActive(false);
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "George";
                        Char2speech.text = "Do you need help choosing your gift?";
                }
                else if (primeInt == 10)
                {
                        Char1name.text = "You";
                        Char1speech.text = "Nah, dude, I'm fine.";
                        Char2name.text = "";
                        Char2speech.text = "";
                }
                else if (primeInt == 11)
                {
                         ArtChar1d.SetActive(false);
                        ArtChar1a.SetActive(true);
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "George";
                        Char2speech.text = "Well ok dude, if you need anything...";
                }
                else if (primeInt == 12)
                {
                         ArtChar1a.SetActive(false);
                        ArtChar1c.SetActive(true);
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "George";
                        Char2speech.text = "C A L L T H E S P I D E R S";
                }
                else if (primeInt == 13)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "...";
                        Char2name.text = "";
                        Char2speech.text = "";
                        // Turn off the "Next" button, turn on "Scene" button/s
                        nextButton.SetActive(false);
                        allowSpace = false;
                        NextScene2Button.SetActive(true);
                        NextScene1Button.SetActive(true);
                        NextScene3Button.SetActive(true);
                }
                else if (primeInt == 101)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "";
                        Char2name.text = "";
                        Char2speech.text = "";
                        // Turn off the "Next" button, turn on "Scene" button/s
                        nextButton.SetActive(false);
                        allowSpace = false;
                        if (GameHandler.BeenToArtStore == true)
                        {
                                NextScene1Button.SetActive(false);
                        }
                        else if (GameHandler.BeenToArtStore == false)
                        {
                                NextScene1Button.SetActive(true);
                        }
                        if (GameHandler.BeenToGeneralStore == true)
                        {
                                NextScene2Button.SetActive(false);
                        }
                        else if (GameHandler.BeenToGeneralStore == false)
                        {
                                NextScene2Button.SetActive(true);
                        }
                        if (GameHandler.BeenToFoodCourt == true)
                        {
                                NextScene3Button.SetActive(false);
                        }
                        else if (GameHandler.BeenToFoodCourt == false)
                        {
                                NextScene3Button.SetActive(true);
                        }
                        if (GameHandler.BeenToPlantStore == true)
                        {
                                NextScene4Button.SetActive(false);
                        }
                        else if (GameHandler.BeenToPlantStore == false)
                        {
                                NextScene4Button.SetActive(true);
                        }
                        if (GameHandler.BeenToCandleStore == true)
                        {
                                NextScene5Button.SetActive(false);
                        }
                        else if (GameHandler.BeenToCandleStore == false)
                        {
                                NextScene5Button.SetActive(true);
                        }
                        NextScene6Button.SetActive(true);
                }

      //Please do NOT delete this final bracket that ends the Next() function:
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
        public void Choice1aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "That's a HORRIBLE decision!!";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 6; // so hitting "NEXT" goes to primeInt==7!
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
                GameHandler.ChairCount = 0;
        }
        public void Choice1bFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "That's a Great decision!";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 7; // so hitting "NEXT" goes to primeInt==8!
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
                GameHandler.ChairCount += 1;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene3a");
        }
        public void SceneChange2()
        {
                SceneManager.LoadScene("Scene3b");
        }
        public void SceneChange3()
        {
                SceneManager.LoadScene("Scene3c");
        }
        public void SceneChange4()
        {
                SceneManager.LoadScene("Scene5a");
        }
        public void SceneChange5()
        {
                SceneManager.LoadScene("Scene5b");
        }
        public void SceneChange6()
        {
                SceneManager.LoadScene("Scene6");
        }
}