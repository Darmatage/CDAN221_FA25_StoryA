using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene6Dialogue : MonoBehaviour {
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
        public GameObject nextButton;
        //public AudioSource audioSource1;
        private bool allowSpace = true;

        // Set initial visibility. Added images or buttons need to also be SetActive(false);
        void Start() {
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
                nextButton.SetActive(true);
        }

        // Use the spacebar as a faster "Next" button:
        void Update() {
                if (allowSpace == true) {
                        if (Input.GetKeyDown("space")) {
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
                        ArtChar2a.SetActive(true);
                        DialogueDisplay.SetActive(true);
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Alex";
                        Char2speech.text = "Hey! You've arrived!";
                }

                else if (primeInt == 3)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "";
                        Char2name.text = "";
                        Char2speech.text = "";
                        // Turn off the "Next" button, turn on "Choice" buttons
                        nextButton.SetActive(false);
                        allowSpace = false;
                        Choice1a.SetActive(true); // function Choice1aFunct() Party?
                        Choice1b.SetActive(true); // function Choice1bFunct() Nice Day?
                }
                else if (primeInt == 4)
                {
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Alex";
                        Char2speech.text = "Great! I think? Have fun on your way here?";
                }
                else if (primeInt == 5)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "Yeah!";
                        Char2name.text = "";
                        Char2speech.text = "";
                        primeInt = 7;
                }
                else if (primeInt == 6)
                {
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Alex";
                        Char2speech.text = "Yeah, of course! I'm glad you came, bud.";
                }
                else if (primeInt == 7)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "Glad to be here.";
                        Char2name.text = "";
                        Char2speech.text = "";
                }
                else if (primeInt == 8)
                {
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Alex";
                        Char2speech.text = "Haha, Nice.";
                        primeInt = 100; //NULL; There MUST be a scenario after.
                        if (GameHandler.SucculentGift == true)
                        {
                                primeInt = 8;
                        }
                        else if (GameHandler.CandleGift == true)
                        {
                                primeInt = 18;
                        }
                        else if (GameHandler.NoGift == true)
                        {
                                primeInt = 28;
                        }
                        else if (GameHandler.PurpleNotebookGift == true)
                        {
                                primeInt = 38;
                        }
                        else if (GameHandler.BurgerGift == true)
                        {
                                primeInt = 48;
                        }
                        else if (GameHandler.ChairCount == 2)
                        {
                                // die
                                primeInt = 58;
                        }
                        else if (GameHandler.ChairGift == true && GameHandler.ChairCount == 1)
                        {
                                //die
                                primeInt = 68;
                        }
                }
                else if (primeInt == 9)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "Anywhoooo, thought I'd give the birthday guest a little present!";
                        Char2name.text = "";
                        Char2speech.text = "";
                }
                else if (primeInt == 10)
                {
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Alex";
                        Char2speech.text = "A present! Just for lil ol' me?";
                }
                else if (primeInt == 11)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "Of course! Here, behold, the succulent.";
                        Char2name.text = "";
                        Char2speech.text = "";
                }
                else if (primeInt == 12)
                {
                        ArtChar2a.SetActive(false);
                        ArtChar2c.SetActive(true);
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Alex";
                        Char2speech.text = "The succulent!! I've waited so long for another one...poor leafy..";
                }
                else if (primeInt == 13)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "Says the person who stole him.";
                        Char2name.text = "";
                        Char2speech.text = "";
                }
                else if (primeInt == 14)
                {
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Alex";
                        Char2speech.text = "You really know me so well..";
                        primeInt = 100; //REDUNDANT, ENDING
                }
                else if (primeInt == 19)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "I deliver to you, a present most profound!";
                        Char2name.text = "";
                        Char2speech.text = "";
                }
                else if (primeInt == 20)
                {
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Alex";
                        Char2speech.text = "A present! Oh boy!!!";
                }
                else if (primeInt == 21)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "Of course! How could I not!";
                        Char2name.text = "";
                        Char2speech.text = "";
                }
                else if (primeInt == 22)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "Here you go!";
                        Char2name.text = "";
                        Char2speech.text = "";
                }
                else if (primeInt == 23)
                {
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Alex";
                        Char2speech.text = ". . .";
                }
                else if (primeInt == 24)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "oh.";
                        Char2name.text = "";
                        Char2speech.text = "";
                }
                else if (primeInt == 29)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "Haha yeah.";
                        Char2name.text = "";
                        Char2speech.text = "";
                }
                else if (primeInt == 30)
                {
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Alex";
                        Char2speech.text = "...";
                }
                else if (primeInt == 31)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "...";
                        Char2name.text = "";
                        Char2speech.text = "";
                }
                else if (primeInt == 32)
                {
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Alex";
                        Char2speech.text = "Well...do you have any gifts?";
                }
                else if (primeInt == 33)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "Huh?";
                        Char2name.text = "";
                        Char2speech.text = "";
                }
                else if (primeInt == 34)
                {
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Alex";
                        Char2speech.text = "Did you...not get me any gifts? :(";
                }
                else if (primeInt == 35)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "Uh....";
                        Char2name.text = "";
                        Char2speech.text = "";
                }
                else if (primeInt == 36)
                {
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Alex";
                        Char2speech.text = "...";
                }
                else if (primeInt == 37)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "...Sorry?";
                        Char2name.text = "";
                        Char2speech.text = "";
                        primeInt = 100; //REDUNDANT, ENDING
                }
                else if (primeInt == 39)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "I come bearing a gift!";
                        Char2name.text = "";
                        Char2speech.text = "";
                }
                else if (primeInt == 40)
                {
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Alex";
                        Char2speech.text = "Oh! Why thank you!";
                }
                else if (primeInt == 41)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "I know you love your colors...";
                        Char2name.text = "";
                        Char2speech.text = "";
                }
                else if (primeInt == 42)
                {
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Alex";
                        Char2speech.text = "Is it=";
                }
                else if (primeInt == 43)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "A PURPLE NOTEBOOK!!!";
                        Char2name.text = "";
                        Char2speech.text = "";
                }
                else if (primeInt == 44)
                {
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Alex";
                        Char2speech.text = "WOOOOOOOOOOOO";
                        primeInt = 100; //REDUNDANT, ENDING
                }
                else if (primeInt == 49)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "I uh, brought you a gift?";
                        Char2name.text = "";
                        Char2speech.text = "";
                }
                else if (primeInt == 50)
                {
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Alex";
                        Char2speech.text = "Haha, why's that a question?";
                }
                else if (primeInt == 51)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "uhhhh...";
                        Char2name.text = "";
                        Char2speech.text = "";
                }
                else if (primeInt == 52)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "I hope you like McDanold's...";
                        Char2name.text = "";
                        Char2speech.text = "";
                }
                else if (primeInt == 53)
                {
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Alex";
                        Char2speech.text = "...";
                }
                else if (primeInt == 54)
                {
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Alex";
                        Char2speech.text = "It's cold and hard as a rock..";
                        primeInt = 100; // REDUNDANT, ENDING
                }
                else if (primeInt == 59)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "Me and George got you some presents, I saw him yesterday!";
                        Char2name.text = "";
                        Char2speech.text = "";
                }
                else if (primeInt == 60)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "We actually got similar gifts!";
                        Char2name.text = "";
                        Char2speech.text = "";
                }
                else if (primeInt == 61)
                {
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Alex";
                        Char2speech.text = "Are you kidding me?";
                }
                else if (primeInt == 62)
                {
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Alex";
                        Char2speech.text = "Not one,";
                }
                else if (primeInt == 63)
                {
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Alex";
                        Char2speech.text = "But TWO CHAIRS??";
                }
                else if (primeInt == 64)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "Surprise?";
                        Char2name.text = "";
                        Char2speech.text = "";
                }
                else if (primeInt == 65)
                {
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Alex";
                        Char2speech.text = "Perish.";
                        primeInt = 100;
                }
                else if (primeInt == 69)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "George and I come bearing gifts!";
                        Char2name.text = "";
                        Char2speech.text = "";
                }
                else if (primeInt == 70)
                {
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Alex";
                        Char2speech.text = "....Is that what I think it is.";
                }
                else if (primeInt == 71)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "Uhhh....";
                        Char2name.text = "";
                        Char2speech.text = "";
                }
                else if (primeInt == 72)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "There's another gift...too?";
                        Char2name.text = "";
                        Char2speech.text = "";
                }
                else if (primeInt == 73)
                {
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Alex";
                        Char2speech.text = "I can't believe you.";
                        primeInt = 100;
                }
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
        public void Choice1aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "How's the party going?";
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
                Char1speech.text = "Nice weather we're having?";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 5; // so hitting "NEXT" goes to primeInt==6!
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene2a");
       }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene2b");
        }
}

