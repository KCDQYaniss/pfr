namespace EFT.UI.Gestures;

public class GestureCommands : Dictionary
{
	private static readonly HashSet _availablePlayerGestures; //Field offset: 0x0
	private readonly Dictionary _names; //Field offset: 0x50

	private static GestureCommands() { }

	public GestureCommands() { }

	public GestureCommands Clone() { }

	public bool Equals(GestureCommands another) { }

	public static string GetCommandName(int index) { }

	public IReadOnlyDictionary GetCommandNames() { }

	public static bool IsPlayerGesture(int index) { }

	public static bool IsPlayerGesture(EInteraction gesture) { }

}

