using System.Collections.Generic;

public class SpeechBubble
{
	public Character Speaker;
	public List<string> Dialogue = new List<string>();

	public SpeechBubble(Character speaker, List<string> dialogue)
	{
		Speaker = speaker;
		Dialogue = dialogue;

		AllDialogue.allDialogue.Add(AllDialogue.allDialogue.Count, this);
	}
}
