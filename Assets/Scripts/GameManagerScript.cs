using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic; 

public class GameManagerScript : MonoBehaviour {

	// Use this for initialization
	[Header("Components")] 
	[Space(10)]
	public TextMesh StoryTextMesh;
	public SpriteRenderer BackgroundSpriteRender;

	public Sprite Storyone; 
	public Sprite Storytwo; 
	public Sprite Storythree; 
	public Sprite Storyfour; 
	public Sprite Storyfive;
	public Sprite Storysix;
	public Sprite Storyseven;
	public Sprite Storyeight;
	public Sprite Storynine;
	public Sprite Storyten;

	[Header("Stories")]  //add a header to this section
	[TextArea(2, 10)]  //display the list of strings that follows as text areas, with a min or 2 lines & a max of 10 lines for the text
	public List<string> Stories;

	private int currentstory;

	void Start () {

		currentstory = 0;
		currentstory = Random.Range (0,10);

		if (currentstory == 0) {
			BackgroundSpriteRender.sprite = Storyone;
			StoryTextMesh.text = Stories [currentstory];
		} else if (currentstory == 1) {
			BackgroundSpriteRender.sprite = Storytwo;
			StoryTextMesh.text = Stories [currentstory];
		} else if (currentstory == 2) {
			BackgroundSpriteRender.sprite = Storythree;
			StoryTextMesh.text = Stories [currentstory];
		} else if (currentstory == 3) {
			BackgroundSpriteRender.sprite = Storyfour;
			StoryTextMesh.text = Stories [currentstory];
		} else if (currentstory == 4) {
			BackgroundSpriteRender.sprite = Storyfive;
			StoryTextMesh.text = Stories [currentstory];
		} else if (currentstory == 5) {
			BackgroundSpriteRender.sprite = Storysix;
			StoryTextMesh.text = Stories [currentstory];
		} else if (currentstory == 6) {
			BackgroundSpriteRender.sprite = Storyseven;
			StoryTextMesh.text = Stories [currentstory];
		} else if (currentstory == 7) {
			BackgroundSpriteRender.sprite = Storyeight;
			StoryTextMesh.text = Stories [currentstory];
		} else if (currentstory == 8) {
			BackgroundSpriteRender.sprite = Storynine;
			StoryTextMesh.text = Stories [currentstory];
		} else if (currentstory == 9) {
			BackgroundSpriteRender.sprite = Storyten;
			StoryTextMesh.text = Stories [currentstory];
		}
	
	}
	
	// Update is called once per frame
	void Update () {


	}

//
//	public void insecondsituation() {
//		timerdecrement = 0.0003f;
//	}
}
