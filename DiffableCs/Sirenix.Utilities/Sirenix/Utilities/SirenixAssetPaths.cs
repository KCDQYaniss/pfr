namespace Sirenix.Utilities;

public static class SirenixAssetPaths
{
	public const string DefaultSirenixPluginPath = "Assets/Plugins/Sirenix/"; //Field offset: 0x0
	public const string SirenixAssetPathsSOGuid = "08379ccefc05200459f90a1c0711a340"; //Field offset: 0x0
	public const string LookupAssetName = "OdinPathLookup.asset"; //Field offset: 0x0
	public static readonly string OdinPath; //Field offset: 0x0
	public static readonly string SirenixAssetsPath; //Field offset: 0x8
	public static readonly string SirenixPluginPath; //Field offset: 0x10
	public static readonly string SirenixAssembliesPath; //Field offset: 0x18
	public static readonly string OdinResourcesPath; //Field offset: 0x20
	public static readonly string OdinEditorConfigsPath; //Field offset: 0x28
	public static readonly string OdinResourcesConfigsPath; //Field offset: 0x30
	public static readonly string OdinTempPath; //Field offset: 0x38
	private static readonly HashSet IllegalChars; //Field offset: 0x40

	private static SirenixAssetPaths() { }

	private static string ReplaceIllegalCharacters(string source, char replacement) { }

}

