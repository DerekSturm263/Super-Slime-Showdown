using System.Collections.Generic;

public static class AllDialogue
{
    public static Dictionary<int, SpeechBubble> allDialogue = new Dictionary<int, SpeechBubble>();

    public static SpeechBubble introduction = new SpeechBubble(Characters.tutorialSlime, new List<string> {
        "Welcome to Super Slime Showdown!",
        "Thank you for being a beta tester! At the end of this special demo, you will recieve a special gift as a 'thank you'.",
        "Let's start with a basic explanation of how this game works.",
        "You will be able to raise and train your own slime to become stronger in different types.",
        "Each type has different levels and abilities that you learn over time.",
        "There are 10 different types, and each can be raised to level 50.",
        "Let's start by choosing the first type for your slime!"
    });

    public static SpeechBubble introduction2 = new SpeechBubble(Characters.tutorialSlime, new List<string> {
        "Great! Now, let's give your slime a name!"
    });

    public static SpeechBubble introduction3 = new SpeechBubble(Characters.tutorialSlime, new List<string>
    {
        "Great! Now we can begin! Good luck on your quest to become the world's strongest slime!"
    });
}
