using System.Collections.Generic;

public static class AllDialogue
{
    public static Dictionary<int, SpeechBubble> allDialogue = new Dictionary<int, SpeechBubble>();

    public static SpeechBubble introduction = new SpeechBubble(Characters.tutorialSlime, new List<string> {
        "Welcome to Super Slime Showdown!",
        "In this game, you get to train a slime to become the very best!",
        "Let's start by picking a starting type. This won't affect your stat boosts or moves learned later on."
    });

    public static SpeechBubble introduction2 = new SpeechBubble(Characters.tutorialSlime, new List<string> {
        "Great! Now, let's pick out a name for you new slime!"
    });
}
