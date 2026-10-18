namespace EFT;

public class TutorialHintLine
{
	public static Dictionary LineStyles; //Field offset: 0x0
	public string Text; //Field offset: 0x10
	public ETutorialHintLineStyle Style; //Field offset: 0x18
	public KeyCombination KeyCombination; //Field offset: 0x20

	public bool ShowKeyCombination
	{
		 get { } //Length: 257
	}

	private static TutorialHintLine() { }

	public TutorialHintLine() { }

	public bool get_ShowKeyCombination() { }

	public void SetStyle(TMP_Text label) { }

}

