namespace Sirenix.OdinInspector;

[AttributeUsage(AttributeTargets::All (32767), AllowMultiple = False, Inherited = True)]
[Conditional("UNITY_EDITOR")]
public class ValueDropdownAttribute : Attribute
{
	public string ValuesGetter; //Field offset: 0x10
	public int NumberOfItemsBeforeEnablingSearch; //Field offset: 0x18
	public bool IsUniqueList; //Field offset: 0x1C
	public bool DrawDropdownForListElements; //Field offset: 0x1D
	public bool DisableListAddButtonBehaviour; //Field offset: 0x1E
	public bool ExcludeExistingValuesInList; //Field offset: 0x1F
	public bool ExpandAllMenuItems; //Field offset: 0x20
	public bool AppendNextDrawer; //Field offset: 0x21
	public bool DisableGUIInAppendedDrawer; //Field offset: 0x22
	public bool DoubleClickToConfirm; //Field offset: 0x23
	public bool FlattenTreeView; //Field offset: 0x24
	public int DropdownWidth; //Field offset: 0x28
	public int DropdownHeight; //Field offset: 0x2C
	public string DropdownTitle; //Field offset: 0x30
	public bool SortDropdownItems; //Field offset: 0x38
	public bool HideChildProperties; //Field offset: 0x39
	public bool CopyValues; //Field offset: 0x3A
	public bool OnlyChangeValueOnConfirm; //Field offset: 0x3B

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Use the ValuesGetter member instead.", False)]
	public string MemberName
	{
		 get { } //Length: 5
		 set { } //Length: 82
	}

	public ValueDropdownAttribute(string valuesGetter) { }

	public string get_MemberName() { }

	public void set_MemberName(string value) { }

}

