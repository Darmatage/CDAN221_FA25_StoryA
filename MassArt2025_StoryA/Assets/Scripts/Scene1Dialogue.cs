using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene1Dialogue : MonoBehaviour {
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
       //public GameObject ArtChar2;
        public GameObject ArtBG1;
        public GameObject Choice1a;
		public GameObject Choice1b;
		public GameObject Choice2a;
        public GameObject Choice2b;
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
	public void Next()
	{
		primeInt += 1;
		if (primeInt == 1)
		{
			// audioSource1.Play();
		}
		else if (primeInt == 2)
		{
			DialogueDisplay.SetActive(true);
			Char1name.text = "YOU";
			Char1speech.text = "Good morning George.";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 3)
		{
			ArtChar2a.SetActive(true);
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "George";
			Char2speech.text = "Mornin'!";
			//gameHandler.AddPlayerStat(1);
		}
		else if (primeInt == 4)
		{
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "George";
			Char2speech.text = "Mornin'! Did you know...";
		}
		else if (primeInt == 5)
		{
			ArtChar2a.SetActive(false);
            ArtChar2c.SetActive(true);
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "George";
			Char2speech.text = "...that the average person eats 16 spiders per year?";
		}
		else if (primeInt == 6)
		{
			Char1name.text = "YOU";
			Char1speech.text = "um...";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 7)
		{
			Char1name.text = "YOU";
			Char1speech.text = "";
			Char2name.text = "";
			Char2speech.text = "";
			// Turn off the "Next" button, turn on "Choice" buttons
			nextButton.SetActive(false);
			allowSpace = false;
			Choice1a.SetActive(true); // function Choice1aFunct() wth…
			Choice1b.SetActive(true); // function Choice1bFunct() Oh, I didn’t know! What a lovely fact!
		}



		// after choice 1a
		else if (primeInt == 20)
		{
			ArtChar2c.SetActive(false);
            ArtChar2b.SetActive(true);

			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "George";
			Char2speech.text = "Well...";
		}

		else if (primeInt == 21)
		{
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "George";
			Char2speech.text = "Well, I thought it was interesting...";
		}
		else if (primeInt == 22)
		{
			//gameHandler.AddPlayerStat(1);
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "George";
			Char2speech.text = "(sulking)";
		}

		else if (primeInt == 23)
		{
			Char1name.text = "YOU";
			Char1speech.text = "Not first thing in the morning! I haven't even had breakfast!";
			Char2name.text = "";
			Char2speech.text = "";
			primeInt = 39;
		}

		// after choice 1b
		else if (primeInt == 30)
		{
			ArtChar2c.SetActive(false);
            ArtChar2a.SetActive(true);
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "GEORGE";
			Char2speech.text = "I KNOW!!";
		}
		else if (primeInt == 31)
		{
			Char1name.text = "YOU";
			Char1speech.text = "GNARLY! ";
			Char2name.text = "";
			Char2speech.text = "";
			primeInt = 39;

		}

		//After both hoices:
		else if (primeInt == 40)
		{
			ArtChar2c.SetActive(true);
            ArtChar2b.SetActive(false);
            ArtChar2a.SetActive(false);
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "George";
			Char2speech.text = "Anyways, did you get Alex their gift?";
		}
		else if (primeInt == 41)
		{
			Char1name.text = "YOU";
			Char1speech.text = "...";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 42)
		{
			Char1name.text = "YOU";
			Char1speech.text = "...no.";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 43)
		{
			ArtChar2a.SetActive(false);
            ArtChar2b.SetActive(true);
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "George";
			Char2speech.text = "BRO I already got their gift! Do you need help?";
			// Turn off the "Next" button, turn on "Choice" buttons
			nextButton.SetActive(false);
			allowSpace = false;
			Choice2a.SetActive(true); // function Choice1aFunct() Yes
			Choice2b.SetActive(true); // function Choice1bFunct() PLSPLSPLSPLS!

		}

		else if (primeInt == 50)
		{
			
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "George";
			Char2speech.text = "Ok, chill.";
		}

		else if (primeInt == 51)
		{
			ArtChar2b.SetActive(false);
            ArtChar2a.SetActive(true);
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "George";
			Char2speech.text = "Why don't we meet at the mall then?";
		}

		else if (primeInt == 52)
		{
			Char1name.text = "YOU";
			Char1speech.text = "Sure, see you soon.";
			Char2name.text = "";
			Char2speech.text = "";
			// Turn off the "Next" button, turn on "Scene" button/s
					nextButton.SetActive(false);
					allowSpace = false;
					NextScene1Button.SetActive(true); //meet george at the mall
					NextScene2Button.SetActive(true); //you’ll meet him later (snooze)
					NextScene3Button.SetActive(true); //Kitchen time, hungry
		}

		//Please do NOT delete this final bracket that ends the Next() function:
	}

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)

        public void Choice1aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "WTH...";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 19; // so hitting "NEXT" goes to primeInt==20!
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "Oh, I didn’t know! What a lovely fact!";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 29; // so hitting "NEXT" goes to primeInt==30!
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void Choice2aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "Yes, I would appreciate that.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 50; // so hitting "NEXT" goes to primeInt==20!
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice2bFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "OH GOD YES PLEASE I DON'T KNOW WHAT TO DOOOOOOOOOOO..... :(";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 49; // so hitting "NEXT" goes to primeInt==30!
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

	public void SceneChange1()
	{
		SceneManager.LoadScene("Scene2a"); //mall hall
	}
	public void SceneChange2()
	{
		SceneManager.LoadScene("Scene2d"); //back to sleep
	}
		
        public void SceneChange3(){
                SceneManager.LoadScene("Scene2c"); // kitchen
        }

}