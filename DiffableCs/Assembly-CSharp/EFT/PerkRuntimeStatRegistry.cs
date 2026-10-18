namespace EFT;

public static class PerkRuntimeStatRegistry
{
	private static readonly PerkRuntimeStatDefinition[] _definitions; //Field offset: 0x0

	private static PerkRuntimeStatRegistry() { }

	private static void Add(PerkRuntimeStatDefinition[] definitions, PerkRuntimeStatDefinition definition) { }

	private static PerkRuntimeStatDefinition[] CreateDefinitions() { }

	public static PerkRuntimeStatDefinition Get(EPerkRuntimeStatId id) { }

	public static PerkRuntimeStatDefinition Get(int index) { }

	private static void ValidateDefinitions(PerkRuntimeStatDefinition[] definitions) { }

}

