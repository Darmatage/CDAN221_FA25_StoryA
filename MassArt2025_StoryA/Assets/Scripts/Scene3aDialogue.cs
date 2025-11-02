using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene3aDialogue : MonoBehaviour {
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
        public GameObject ArtChar2d;
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
             ArtChar2d.SetActive(false);
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
                        GameHandler.BeenToArtStore = true;
                        DialogueDisplay.SetActive(true);
                        Char1name.text = "YOU";
                        Char1speech.text = "Oh hey, is that Mrs. Art Teacher?";
                        Char2name.text = "";
                        Char2speech.text = "";
                }
                else if (primeInt == 3)
                {
                        ArtChar2a.SetActive(true);
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Teacher";
                        Char2speech.text = "Oh, good morning...";
                }
                else if (primeInt == 4)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "How's life going for you, Mrs. Art Teacher?";
                        Char2name.text = "";
                        Char2speech.text = "";
                }
                else if (primeInt == 5)
                {
                        ArtChar2a.SetActive(false);
                        ArtChar2b.SetActive(true);
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Teacher";
                        Char2speech.text = "It's...great..I guess.";
                        nextButton.SetActive(false);
                        allowSpace = false;
                        Choice1a.SetActive(true); // function Choice1aFunct()
                        Choice1b.SetActive(true); // function Choice1bFunct()
                }

//AFTER CHOICE 1a
                else if (primeInt == 20)
                {
                        ArtChar2b.SetActive(false);
                        ArtChar2d.SetActive(true);
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Teacher";
                        Char2speech.text = "Your class is a nightmare";
                }
                else if (primeInt == 21)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "Oh. Well, Alex is alright, right?";
                        Char2name.text = "";
                        Char2speech.text = "";
                }
                else if (primeInt == 22)
                {
                        ArtChar2d.SetActive(false);
                        ArtChar2c.SetActive(true);
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Teacher";
                        Char2speech.text = "Alex? You mean the person that ATE our class pet, Leafy? My beloved plant?";
                }
                else if (primeInt == 23)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "Oh yeah.";
                        Char2name.text = "";
                        Char2speech.text = "";
                }
                else if (primeInt == 24)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "I forgot they ate the succulent.";
                        Char2name.text = "";
                        Char2speech.text = "";
                }
                else if (primeInt == 25)
                {
                        ArtChar2c.SetActive(false);
                        ArtChar2b.SetActive(true);
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Teacher";
                        Char2speech.text = "The succulent, had a name.";
                }
                else if (primeInt == 26)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "Right, right, my bad. Sorry Mrs. Art Teacher.";
                        Char2name.text = "";
                        Char2speech.text = "";
                        primeInt = 31;
                }

//AFTER CHOICE 1b       
                else if (primeInt == 30)
                {
                        ArtChar2b.SetActive(false);
                        ArtChar2d.SetActive(true);
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Teacher";
                        Char2speech.text = "*sigh*";
                }
                else if (primeInt == 31)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "Life's goin' great for me at least! :)";
                        Char2name.text = "";
                        Char2speech.text = "";
                }

 //AFTER BOTH CHOICES:               
                else if (primeInt == 32)
                {
                        ArtChar2a.SetActive(false);
                        ArtChar2b.SetActive(true);
                        ArtChar2c.SetActive(false);
                        ArtChar2d.SetActive(false);

                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Teacher";
                        Char2speech.text = "Well...what did you want?";
                }
                else if (primeInt == 33)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "I wanted to ask, do you know what kind of gift Alex would want? It's their birthday tomorrow.";
                        Char2name.text = "";
                        Char2speech.text = "";
                }
                else if (primeInt == 34)
                {
                        ArtChar2b.SetActive(false);
                        ArtChar2c.SetActive(true);
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Teacher";
                        Char2speech.text = "…you should know already! Just get Alex another class pet, they already ate the last one!";
                }
                else if (primeInt == 35)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "Oh, uh,.. thanks!";
                        Char2name.text = "";
                        Char2speech.text = "";
                }
                else if (primeInt == 36)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "I've got to finish shopping, so I guess that means I'll see you next class!";
                        Char2name.text = "";
                        Char2speech.text = "";
                }
                else if (primeInt == 37)
                {
                        ArtChar2c.SetActive(false);
                        ArtChar2a.SetActive(true);
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Teacher";
                        Char2speech.text = "*muttering*";
                }
                else if (primeInt == 38)
                {
                        Char1name.text = "";
                        Char1speech.text = " ";
                        Char2name.text = "";
                        Char2speech.text = "";
                        nextButton.SetActive(false);
                        allowSpace = false;
                        if (GameHandler.BeenToPlantStore == false)
                        {
                                NextScene1Button.SetActive(true);    
                        }
                        NextScene2Button.SetActive(true);
                        NextScene3Button.SetActive(true);
                }

      //Please do NOT delete this final bracket that ends the Next() function:
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
        public void Choice1aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "You don't sound too sure?";
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
                Char1speech.text = "Haha yeah.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 29; // so hitting "NEXT" goes to primeInt==13!
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene5a");
        }
        public void SceneChange2()
        {
                SceneManager.LoadScene("Scene2a");
        }
        public void SceneChange3()
        {
                GameHandler.PurpleNotebookGift = true;
                GameHandler.NoGift = false;
                SceneManager.LoadScene("Scene6");
        }
}