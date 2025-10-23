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
        public GameObject Choice2a;
        public GameObject Choice2b;
        public GameObject Choice2c;
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
             Choice2a.SetActive(false);
             Choice2b.SetActive(false);
             Choice2c.SetActive(false);
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
                        ArtChar2a.SetActive(true);
                        DialogueDisplay.SetActive(true);
                        Char1name.text = "YOU";
                        Char1speech.text = "Hello! Do you have any succulents I could buy?";
                        Char2name.text = "";
                        Char2speech.text = "";
                }
                else if (primeInt == 3)
                {
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Clerk";
                        Char2speech.text = "Succulents??";
                        //gameHandler.AddPlayerStat(1);
                }
                else if (primeInt == 4)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "Yeah, those small...like..cacti? Whatever they are.";
                        Char2name.text = "";
                        Char2speech.text = "";
                }
                else if (primeInt == 5)
                {
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Clerk";
                        Char2speech.text = "tsk.";
                }
                else if (primeInt == 6)
                {
                        //gameHandler.AddPlayerStat(1);
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Clerk";
                        Char2speech.text = "Ignorant one wants a succulent...";
                }
                else if (primeInt == 7)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "Listen, can I just get a succulent?";
                        Char2name.text = "";
                        Char2speech.text = "";
                }
                else if (primeInt == 8)
                {
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Clerk";
                        Char2speech.text = "Of course, Of course...";
                }
                else if (primeInt == 9)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "...";
                        Char2name.text = "";
                        Char2speech.text = "";
                }
                else if (primeInt == 10)
                {
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Clerk";
                        Char2speech.text = "Would you like the red tinged one? The blue one? Oo! Or the green one?";
                }
                else if (primeInt == 11)
                {
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Clerk";
                        Char2speech.text = "Maybe even purple?";
                        // Turn off the "Next" button, turn on "Choice" buttons
                        nextButton.SetActive(false);
                        allowSpace = false;
                        Choice1a.SetActive(true); // function Choice1aFunct()
                        Choice1b.SetActive(true); // function Choice1bFunct()
                }
                else if (primeInt == 12)
                {
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Clerk";
                        Char2speech.text = "AHAH NO! I lied! Only little red here.";
                }
                else if (primeInt == 13)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "I don't think I like you.";
                        Char2name.text = "";
                        Char2speech.text = "";
                        primeInt = 15;
                }
                else if (primeInt == 14)
                {
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Clerk";
                        Char2speech.text = "Colors, colors! Colors are great! Well. We actually only have the red one.";
                }
                else if (primeInt == 15)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "Uh...ok?";
                        Char2name.text = "";
                        Char2speech.text = "";
                }
                else if (primeInt == 16)
                {
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Clerk";
                        Char2speech.text = "ehehee";
                }
                else if (primeInt == 15)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "Can I please just buy the succulent?";
                        Char2name.text = "";
                        Char2speech.text = "";
                }
                else if (primeInt == 16)
                {
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Clerk";
                        Char2speech.text = "mm m mmmm!";
                }
                else if (primeInt == 17)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = " ";
                        Char2name.text = "";
                        Char2speech.text = "";
                        nextButton.SetActive(false);
                        allowSpace = false;
                        Choice2a.SetActive(true);
                        Choice2b.SetActive(true);
                        Choice2c.SetActive(true);
                }
                else if (primeInt == 18)
                {
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
                Char1speech.text = "Wait, you have purple succulents?";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 11; // so hitting "NEXT" goes to primeInt==12!
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "Why do you have so many colors?";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 13; // so hitting "NEXT" goes to primeInt==14!
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice2aFunct(){
                Char1name.text = "";
                Char1speech.text = "Succulent acquired";
                Char2name.text = "";
                Char2speech.text = "";
                GameHandler.SucculentGift = true;
                GameHandler.NoGift = false;
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
                Choice2c.SetActive(false);
                NextScene1Button.SetActive(true);
                allowSpace = true;
        }
        public void Choice2bFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "Guess I'll go back.";
                Char2name.text = "";
                Char2speech.text = "";
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
                Choice2c.SetActive(false);
                NextScene2Button.SetActive(true);
                allowSpace = true;
        }
        public void Choice2cFunct()
        {
                Char1name.text = "";
                Char1speech.text = "Gift Not Acquired!";
                Char2name.text = "";
                Char2speech.text = "";
                GameHandler.NoGift = true;
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
                Choice2c.SetActive(false);
                NextScene3Button.SetActive(true);
                allowSpace = true;

        }
        public void SceneChange1(){
               SceneManager.LoadScene("Scene6");
        }
        public void SceneChange2()
        {
                SceneManager.LoadScene("Scene2a");
        }
        public void SceneChange3()
        {
                SceneManager.LoadScene("Scene6");
        }
}