using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene5bDialogue : MonoBehaviour {
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
        public GameObject ArtChar2a;
        public GameObject ArtChar2b;
        public GameObject ArtChar2c;
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
        public GameObject NextScene3Button;
        public GameObject nextButton;
       //public AudioSource audioSource1;
        private bool allowSpace = true;

// Set initial visibility. Added images or buttons need to also be SetActive(false);
        void Start(){  
             DialogueDisplay.SetActive(false);
             ArtChar2a.SetActive(false);
             ArtChar2b.SetActive(false);
             ArtChar2c.SetActive(false);
             ArtBG1.SetActive(true);
             Choice1a.SetActive(false);
             Choice1b.SetActive(false);
             NextScene1Button.SetActive(false);
             NextScene2Button.SetActive(false);
             NextScene3Button.SetActive(false);
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
public void Next(){
        primeInt += 1;
                if (primeInt == 1)
                {
                        // audioSource1.Play();
                }
                else if (primeInt == 2)
                {
                        GameHandler.BeenToCandleStore = true;
                        DialogueDisplay.SetActive(true);
                        Char1name.text = "YOU";
                        Char1speech.text = "Is anyone in there?";
                        Char2name.text = "";
                        Char2speech.text = "";
                }
                else if (primeInt == 3)
                {
                        ArtChar2b.SetActive(true);
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Clerk";
                        Char2speech.text = "Oh! A customer! Yeah!";
                        nextButton.SetActive(false);
                        allowSpace = false;
                        Choice1a.SetActive(true); // function Choice1aFunct()
                        Choice1b.SetActive(true); // function Choice1bFunct()
                        //gameHandler.AddPlayerStat(1);
                }


 //after choice1a               
                else if (primeInt == 4)
                { 
                        ArtChar2b.SetActive(false);
                        ArtChar2a.SetActive(true);
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Clerk";
                        Char2speech.text = "Anyone in particular it's for?";
                }
                else if (primeInt == 5)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "My buddy Alex! A friend of mine.";
                        Char2name.text = "";
                        Char2speech.text = "";
                }
                else if (primeInt == 6)
                {
                        ArtChar2a.SetActive(false);
                        ArtChar2b.SetActive(true);
                        //gameHandler.AddPlayerStat(1);
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Clerk";
                        Char2speech.text = "As long as they're not allergic, all our candles make great gifts!";
                }
                else if (primeInt == 7)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "Nice!";
                        Char2name.text = "";
                        Char2speech.text = "";
                        primeInt = 12;
                }

 //after choie 1b               
                else if (primeInt == 8)
                {
                        ArtChar2b.SetActive(false);
                        ArtChar2c.SetActive(true);
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Clerk";
                        Char2speech.text = "Uh...rude..?";
                }
                else if (primeInt == 9)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "But it does?";
                        Char2name.text = "";
                        Char2speech.text = "";
                }
                else if (primeInt == 10)
                {
                        ArtChar2c.SetActive(false);
                        ArtChar2a.SetActive(true);
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Clerk";
                        Char2speech.text = "Dude don't just go into a store and say that.";
                }
                else if (primeInt == 11)
                {
                        ArtChar2a.SetActive(false);
                        ArtChar2c.SetActive(true);
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Clerk";
                        Char2speech.text = "It smells like candles, because its a candle store.";
                        // Turn off the "Next" button, turn on "Choice" buttons
                }
                else if (primeInt == 12)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "Oh, sorry I guess.";
                        Char2name.text = "";
                        Char2speech.text = "";
                }


 //after both choices:               
                else if (primeInt == 13)
                {
                        ArtChar2c.SetActive(false);
                        ArtChar2b.SetActive(false);
                        ArtChar2a.SetActive(true);
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Clerk";
                        Char2speech.text = "Well it's the day after the main sale,";

                }
                else if (primeInt == 14)
                {
                        ArtChar2a.SetActive(false);
                        ArtChar2b.SetActive(true);
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Clerk";
                        Char2speech.text = "so we only have two main types. ";
                }
                else if (primeInt == 15)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "Only two?";
                        Char2name.text = "";
                        Char2speech.text = "";
                }
                else if (primeInt == 16)
                {
                        ArtChar2b.SetActive(false);
                        ArtChar2a.SetActive(true);
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Clerk";
                        Char2speech.text = "Yeah, want a purple candle or a green one?";
                }
                else if (primeInt == 17)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "Hmm..";
                        Char2name.text = "";
                        Char2speech.text = "";
                        nextButton.SetActive(false);
                        allowSpace = false;
                        NextScene2Button.SetActive(true);
                        NextScene1Button.SetActive(true);
                        NextScene3Button.SetActive(true);
                }



      //Please do NOT delete this final bracket that ends the Next() function:
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
        public void Choice1aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "I'm looking for a birthday gift?";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 3; // so hitting "NEXT" goes to primeInt==4!
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "Oh it smells...";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 7; // so hitting "NEXT" goes to primeInt==8!
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
                GameHandler.CandleGift = true;
                GameHandler.NoGift = false;
               SceneManager.LoadScene("Scene6");
        }
        public void SceneChange2()
        {
                GameHandler.CandleGift = true;
                GameHandler.NoGift = false;
                SceneManager.LoadScene("Scene6");
        }
        public void SceneChange3()
        {
                SceneManager.LoadScene("Scene2a");
        }
}