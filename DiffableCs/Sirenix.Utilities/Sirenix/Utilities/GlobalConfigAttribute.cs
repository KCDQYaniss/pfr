namespace Sirenix.Utilities;

[AttributeUsage(AttributeTargets::Class (4))]
public class GlobalConfigAttribute : Attribute
{
	private string assetPath; //Field offset: 0x10
	[CompilerGenerated]
	private bool <UseAsset>k__BackingField; //Field offset: 0x18

	public string AssetPath
	{
		 get { } //Length: 5
	}

	internal string AssetPathWithAssetsPrefix
	{
		internal get { } //Length: 110
	}

	internal string AssetPathWithoutAssetsPrefix
	{
		internal get { } //Length: 125
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("It's a bit more complicated than that as it's not always possible to know the full path, so try and make due without it if you can, only using the AssetDatabase.")]
	public string FullPath
	{
		 get { } //Length: 167
	}

	public bool IsInResourcesFolder
	{
		 get { } //Length: 512
	}

	public string ResourcesPath
	{
		 get { } //Length: 187
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("This option is obsolete and will have no effect - a GlobalConfig will always have an asset generated now; use a POCO singleton or a ScriptableSingleton<T> instead. Asset-less config objects that are recreated every reload cause UnityEngine.Object leaks.", True)]
	public bool UseAsset
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public GlobalConfigAttribute() { }

	public GlobalConfigAttribute(string assetPath) { }

	public string get_AssetPath() { }

	internal string get_AssetPathWithAssetsPrefix() { }

	internal string get_AssetPathWithoutAssetsPrefix() { }

	public string get_FullPath() { }

	public bool get_IsInResourcesFolder() { }

	public string get_ResourcesPath() { }

	[CompilerGenerated]
	public bool get_UseAsset() { }

	[CompilerGenerated]
	public void set_UseAsset(bool value) { }

}

