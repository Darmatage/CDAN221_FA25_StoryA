using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene2cDialogue : MonoBehaviour {
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
                        Char2name.text = "Cat";
                        Char2speech.text = "Mrow.";
                }
                else if (primeInt == 3)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "Oh, kitty...what a predicament I'm in";
                        Char2name.text = "";
                        Char2speech.text = "";
                        //gameHandler.AddPlayerStat(1);
                }
                else if (primeInt == 4)
                {
                        ArtChar2c.SetActive(true);
                        ArtChar2a.SetActive(false);
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Cat";
                        Char2speech.text = "Cool. You forgot to fill the food last night. It was half empty!";
                }
                else if (primeInt == 5)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "...";
                        Char2name.text = "";
                        Char2speech.text = "";
                        // Turn off the "Next" button, turn on "Choice" buttons
                        nextButton.SetActive(false);
                        allowSpace = false;
                        Choice1a.SetActive(true); // function Choice1aFunct()
                        Choice1b.SetActive(true); // function Choice1bFunct()
                }
                else if (primeInt == 6)
                {
                        //gameHandler.AddPlayerStat(1);
                        ArtChar2b.SetActive(true);
                        ArtChar2c.SetActive(false);
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Cat";
                        Char2speech.text = "At least you know you've wronged me.";
                }
                else if (primeInt == 7)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "My dearest apologies.";
                        Char2name.text = "";
                        Char2speech.text = "";
                }
                else if (primeInt == 8)
                {
                        ArtChar2a.SetActive(true);
                        ArtChar2b.SetActive(false);
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Cat";
                        Char2speech.text = "Well...maybe you can make it up..with a bit of those eggs you're eating?";
                }
                else if (primeInt == 9)
                {
                        ArtChar2a.SetActive(false);
                        ArtChar2c.SetActive(true);
                        Char1name.text = "YOU";
                        Char1speech.text = "Haha, no.";
                        Char2name.text = "";
                        Char2speech.text = "";
                        primeInt = 13;
                }
                else if (primeInt == 10)
                {
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Cat";
                        Char2speech.text = "Of course I can talk?";
                }
                else if (primeInt == 11)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "Oh";
                        Char2name.text = "";
                        Char2speech.text = "";
                }
                else if (primeInt == 12)
                {
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Cat";
                        Char2speech.text = "I thought we knew this already..";
                }
                else if (primeInt == 13)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "sorry";
                        Char2name.text = "";
                        Char2speech.text = "";
                }
                else if (primeInt == 14)
                {
                        ArtChar2b.SetActive(true);
                        ArtChar2a.SetActive(false);
                        ArtChar2c.SetActive(false);
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Cat";
                        Char2speech.text = "Hmpf.";
                }
                else if (primeInt == 15)
                {
                        ArtChar2a.SetActive(true);
                        ArtChar2b.SetActive(false);
                        Char1name.text = "YOU";
                        Char1speech.text = "...Do you know anything I could get for Alex? It's their birthday.";
                        Char2name.text = "";
                        Char2speech.text = "";
                }
                else if (primeInt == 16)
                {
                        ArtChar2b.SetActive(false);
                        ArtChar2c.SetActive(true);
                        ArtChar2a.SetActive(false);
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Cat";
                        Char2speech.text = "What, that creepy friend?";
                }
                else if (primeInt == 15)
                {
                        ArtChar2c.SetActive(false);
                        ArtChar2a.SetActive(true);
                        Char1name.text = "YOU";
                        Char1speech.text = "Hey! They're not bad!";
                        Char2name.text = "";
                        Char2speech.text = "";
                }
                else if (primeInt == 16)
                {
                        ArtChar2c.SetActive(true);
                        ArtChar2a.SetActive(false);
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Cat";
                        Char2speech.text = "riiiiiiight...";
                }
                else if (primeInt == 17)
                {
                        ArtChar2c.SetActive(false);
                        ArtChar2a.SetActive(true);
                        Char1name.text = "YOU";
                        Char1speech.text = "Well? Any Ideas?";
                        Char2name.text = "";
                        Char2speech.text = "";
                }
                else if (primeInt == 18)
                {
                        ArtChar2b.SetActive(true);
                        ArtChar2a.SetActive(false);
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Cat";
                        Char2speech.text = "Ugh. Well, they kept talking about this color 'purple' when they were looking at something. ";
                }
                else if (primeInt == 19)
                {
                        ArtChar2a.SetActive(true);
                        ArtChar2b.SetActive(false);
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Cat";
                        Char2speech.text = "Maybe you can get them something in their 'imaginary' color.";
                }
                else if (primeInt == 20)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "...Purple is a real color though?";
                        Char2name.text = "";
                        Char2speech.text = "";
                }
                else if (primeInt == 21)
                {
                        ArtChar2b.SetActive(true);
                        ArtChar2a.SetActive(false);
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Cat";
                        Char2speech.text = "Looked blue to me!!";
                }
                else if (primeInt == 22)
                {
                        ArtChar2b.SetActive(false);
                        Char1name.text = "YOU";
                        Char1speech.text = "Alrighty then.";
                        Char2name.text = "";
                        Char2speech.text = "";
                        nextButton.SetActive(false);
                        allowSpace = false;
                        NextScene2Button.SetActive(true);
                        NextScene1Button.SetActive(true);
                }


      //Please do NOT delete this final bracket that ends the Next() function:
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
        public void Choice1aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "Oh! I'm sorry!";
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
                Char1speech.text = "Wait, you can talk?";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 9; // so hitting "NEXT" goes to primeInt==10!
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