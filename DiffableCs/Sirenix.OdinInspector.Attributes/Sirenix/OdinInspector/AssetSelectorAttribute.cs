namespace Sirenix.OdinInspector;

[Conditional("UNITY_EDITOR")]
public class AssetSelectorAttribute : Attribute
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__12_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <set_Paths>b__12_0(string x) { }

	}

	public bool IsUniqueList; //Field offset: 0x10
	public bool DrawDropdownForListElements; //Field offset: 0x11
	public bool DisableListAddButtonBehaviour; //Field offset: 0x12
	public bool ExcludeExistingValuesInList; //Field offset: 0x13
	public bool ExpandAllMenuItems; //Field offset: 0x14
	public bool FlattenTreeView; //Field offset: 0x15
	public int DropdownWidth; //Field offset: 0x18
	public int DropdownHeight; //Field offset: 0x1C
	public string DropdownTitle; //Field offset: 0x20
	public string[] SearchInFolders; //Field offset: 0x28
	public string Filter; //Field offset: 0x30

	public string Paths
	{
		 get { } //Length: 193
		 set { } //Length: 827
	}

	public AssetSelectorAttribute() { }

	public string get_Paths() { }

	public void set_Paths(string value) { }

}

