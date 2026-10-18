namespace EFT;

[IsReadOnly]
public struct PerkRuntimeStatDefinition
{
	public readonly EPerkRuntimeStatId Id; //Field offset: 0x0
	public readonly bool IsDefined; //Field offset: 0x1
	private readonly EPerkRuntimeValueKind _kind; //Field offset: 0x2
	private readonly float _defaultNumericValue; //Field offset: 0x4
	private readonly bool _defaultBoolValue; //Field offset: 0x8

	private PerkRuntimeStatDefinition(EPerkRuntimeStatId id, EPerkRuntimeValueKind kind, float defaultNumericValue, bool defaultBoolValue) { }

	public static PerkRuntimeStatDefinition Bool(EPerkRuntimeStatId id, bool defaultValue) { }

	public PerkRuntimeValue CreateValue() { }

	public static PerkRuntimeStatDefinition Numeric(EPerkRuntimeStatId id, float defaultValue) { }

}

