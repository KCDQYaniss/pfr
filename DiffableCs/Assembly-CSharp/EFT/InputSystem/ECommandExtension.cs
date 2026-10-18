namespace EFT.InputSystem;

[Extension]
public static class ECommandExtension
{
	private static readonly HashSet _noPressTypeSelectionKeys; //Field offset: 0x0
	private static readonly Dictionary _specificPressTypeKeys; //Field offset: 0x8
	private static readonly Dictionary _associatedCommands; //Field offset: 0x10

	private static ECommandExtension() { }

	[Extension]
	public static EPressType GetSpecificPressType(EGameKey gameKey) { }

	[Extension]
	public static bool IsCommand(ECommand command, ECommand checkCommand) { }

	[Extension]
	public static bool IsCommand(ECommand command, ECommand[] checkCommands) { }

	[Extension]
	public static bool IsPressTypeSelectionAllowed(EGameKey gameKey) { }

	[Extension]
	public static bool IsPressTypeSpecific(EGameKey gameKey) { }

	[Extension]
	public static bool TryGetAssociatedCommand(ECommand command, out ECommand associatedCommand) { }

}

