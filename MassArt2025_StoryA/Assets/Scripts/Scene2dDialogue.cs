using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene2dDialogue : MonoBehaviour {
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
                        ArtChar2a.SetActive(true);
                        DialogueDisplay.SetActive(true);
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "George";
                        Char2speech.text = "*Call incoming*";
                }
                else if (primeInt == 3)
                {
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "George";
                        Char2speech.text = "DUDEWHATTHEHECKHAPPENEDYOUWERESUPPOSEDTOBE-";
                }
                else if (primeInt == 4)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "...Hello to you too George?";
                        Char2name.text = "";
                        Char2speech.text = "";
                }
                else if (primeInt == 5)
                {
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "George";
                        Char2speech.text = "WHY ARE YOU SO CALM???";
                        nextButton.SetActive(false);
                        allowSpace = false;
                        Choice1a.SetActive(true); // function Choice1aFunct()
                        Choice1b.SetActive(true); // function Choice1bFunct()
                }
                else if (primeInt == 6)
                {

                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "George";
                        Char2speech.text = "THIS ISN'T THE TIME TO BE CALM?!";
                }
                else if (primeInt == 7)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "Why??";
                        Char2name.text = "";
                        Char2speech.text = "";
                        primeInt = 9;
                }
                else if (primeInt == 8)
                {
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "George";
                        Char2speech.text = "WHY HAVEN'T YOU REALIZED?!";
                }
                else if (primeInt == 9)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "REALIZED WHAT?!";
                        Char2name.text = "";
                        Char2speech.text = "";
                }
                else if (primeInt == 10)
                {
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "George";
                        Char2speech.text = "LOOK AT THE TIME DUDE, YOU MISSED THE PARTY!!";
                }
                else if (primeInt == 11)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "Oh no!";
                        Char2name.text = "";
                        Char2speech.text = "";
                }
                else if (primeInt == 12)
                {
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "George";
                        Char2speech.text = "ALEX IS LOOKING FOR YOU DUDE,";
                }
                else if (primeInt == 13)
                {
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "George";
                        Char2speech.text = "YOU MISSED THEIR PARTY!!!";
                }
                else if (primeInt == 14)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "Oh, hold on, I think I see something outside the window..";
                        Char2name.text = "";
                        Char2speech.text = "";
                }
                else if (primeInt == 15)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "Oh sugar hoNEY ICED TE-";
                        Char2name.text = "";
                        Char2speech.text = "";
                        //Bad end haha
                }

      //Please do NOT delete this final bracket that ends the Next() function:
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
        public void Choice1aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "Because I was asleep, duh.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 5; // so hitting "NEXT" goes to primeInt==6!
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "WHY ARE YOU SCREAMING?";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 7; // so hitting "NEXT" goes to primeInt==8!
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene2a");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene2d");
        }
}