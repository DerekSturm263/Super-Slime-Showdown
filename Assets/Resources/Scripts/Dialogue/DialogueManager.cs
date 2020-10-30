using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;
using UnityEngine.InputSystem.EnhancedTouch;

public class DialogueManager : MonoBehaviour
{
	private Controls controls;

	public GameObject dialogue;
	public TMPro.TMP_Text dialogueText;
	public Image dialogueBG;
	public TMPro.TMP_Text speakerName;
	public Image speakerIcon;

	private Character thisSpeaker;
	private SpeechBubble thisDialogue;
	
	private bool canSkip = false;
	private bool finishedWriting = false;
	private float waitTime = 0.05f;

	private Action action = null;
	private int posInSpeechBubble;

	public static bool isDialoguing;

	private void Awake()
	{
		controls = new Controls();
		dialogue.SetActive(false);

		TouchSimulation.Enable();

		controls.UI.Tap.performed += _ => TrySkipDialogue();
	}

	public void WriteDialogue(SpeechBubble line, Action a = null)
	{
		isDialoguing = true;
		action = a;
		posInSpeechBubble = 0;

		thisSpeaker = line.Speaker;
		thisDialogue = line;

		if (speakerIcon != null) speakerIcon.sprite = thisSpeaker.Icon;
		speakerName.text = thisSpeaker.Name;

		dialogue.SetActive(true);
		StartCoroutine(Write(line.Dialogue[posInSpeechBubble]));
	}

	public void AdvanceDialogue()
	{
		try
		{
			if (posInSpeechBubble++ != thisDialogue.Dialogue.Count - 1)
				StartCoroutine(Write(thisDialogue.Dialogue[posInSpeechBubble]));
			else
				StopDialogue();
		} catch { }
	}

	public void StopDialogue()
	{
		thisSpeaker = null;
		thisDialogue = null;

		dialogue.GetComponent<Animator>().SetBool("Exit", true);

		if (action != null) action.Invoke();
		StartCoroutine(Stop());
	}
	
	private IEnumerator Stop()
	{
		yield return new WaitForSeconds(1f);
		isDialoguing = false;
	}

	private IEnumerator Write(string text)
	{
		TMPro.TMP_Text output = dialogueText;

		finishedWriting = false;
		canSkip = false;
		waitTime = 0.05f;
		output.text = "";

		for (int i = 0; i < text.Length; i++)
		{
			output.text += text[i];

			yield return new WaitForSeconds(waitTime);
		}

		canSkip = true;
		finishedWriting = true;
	}

	private void TrySkipDialogue()
	{
		if (!isDialoguing)
			return;



		if (!canSkip)
		{
			waitTime = 0f;
			canSkip = true;
		}
		else if (finishedWriting)
		{
			AdvanceDialogue();
		}
	}

	private void OnEnable()
	{
		controls.Enable();
	}

	private void OnDisable()
	{
		controls.Disable();
	}
}
