using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene3bDialogue : MonoBehaviour {
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
        //public GameObject ArtChar2d;
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
             //ArtChar2d.SetActive(false);
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
                        GameHandler.BeenToGeneralStore = true;
                        DialogueDisplay.SetActive(true);
                        Char1name.text = "YOU";
                        Char1speech.text = "OK. Let's try the General store.";
                        Char2name.text = "";
                        Char2speech.text = "";
                }
                else if (primeInt == 3)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "They're generally good, right?";
                        Char2name.text = "";
                        Char2speech.text = "";
                }
               else if (primeInt == 4)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "Hello, I’m looking for something to buy for my friend.";
                        Char2name.text = "";
                        Char2speech.text = "";
                }
                else if (primeInt == 5)
                {
                        ArtChar2a.SetActive(true);
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Emoji Gohn";
                        Char2speech.text = "please dont buy a chair...";
                }
                else if (primeInt == 6)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "HUh?";
                        Char2name.text = "";
                        Char2speech.text = "";
                }

                else if (primeInt == 7)
                {
                        ArtChar2a.SetActive(false);
                        ArtChar2b.SetActive(true);
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Emoji Gohn";
                        Char2speech.text = "chairs will only bring misfortune upon you...";
                }
                else if (primeInt == 8)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "";
                        Char2name.text = "";
                        Char2speech.text = "";
                        nextButton.SetActive(false);
                        allowSpace = false;
                        Choice1a.SetActive(true); // function Choice1aFunct()
                        Choice1b.SetActive(true); // function Choice1bFunct()
                }


//AFTER CHOICE 1a

                else if (primeInt == 20)
                {
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Emoji Gohn";
                        Char2speech.text = "chairs killed my grandma";
                        primeInt =39;
                }

//AFTER CHOICE 1b:
                else if (primeInt == 30)
                {
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Emoji Gohn";
                        Char2speech.text = "glad to see you understand the danger of chairs..";
                        primeInt = 39;
                }

//AFTER BOTH CHOICES:
                else if (primeInt == 40)
                {
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Emoji Gohn";
                        Char2speech.text = "Seriously, buying a chair is a slippery slope down a dark path...";
                }
                else if (primeInt == 41)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "they're bad, but maybe Alex might like one?";
                        Char2name.text = "";
                        Char2speech.text = "";
                }
                else if (primeInt == 42)
                {
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Emoji Gohn";
                        Char2speech.text = "NO...";
                }
                else if (primeInt == 43)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "oh okay...";
                        Char2name.text = "";
                        Char2speech.text = "";
                }
                else if (primeInt == 44)
                {
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Emoji Gohn";
                        Char2speech.text = "I'm warning you...";
                        
                }
                else if (primeInt == 45)
                {
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Emoji Gohn";
                        Char2speech.text = "you should get something less sinister. Maybe a candle or something?";
                }

                else if (primeInt == 46)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = " ";
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
                Char1speech.text = "What did the chairs do to you?";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 19; // so hitting "NEXT" goes to primeInt==6!
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "yeah, chairs suck..";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 29; // so hitting "NEXT" goes to primeInt==13!
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
                GameHandler.ChairCount += 1;
                GameHandler.ChairGift = true;
                GameHandler.NoGift = false;
               SceneManager.LoadScene("Scene6");
        }
        public void SceneChange2()
        {
                SceneManager.LoadScene("Scene5b");
        }
        public void SceneChange3()
        {
                GameHandler.BeenToGeneralStore = true;
                SceneManager.LoadScene("Scene2a");
        }
}