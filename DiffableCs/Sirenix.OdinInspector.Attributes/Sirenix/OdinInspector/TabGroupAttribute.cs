namespace Sirenix.OdinInspector;

[AttributeUsage(AttributeTargets::All (32767), AllowMultiple = True, Inherited = True)]
[Conditional("UNITY_EDITOR")]
public class TabGroupAttribute : PropertyGroupAttribute, ISubGroupProviderAttribute
{
	[Conditional("UNITY_EDITOR")]
	internal class TabSubGroupAttribute : PropertyGroupAttribute
	{
		public TabGroupAttribute Tab; //Field offset: 0x38

		public TabSubGroupAttribute(TabGroupAttribute tab, string groupId, float order) { }

		protected virtual void CombineValuesWith(PropertyGroupAttribute other) { }

	}

	public const string DEFAULT_NAME = "_DefaultTabGroup"; //Field offset: 0x0
	public string TabName; //Field offset: 0x38
	public string TabId; //Field offset: 0x40
	public bool UseFixedHeight; //Field offset: 0x48
	public bool Paddingless; //Field offset: 0x49
	public bool HideTabGroupIfTabGroupOnlyHasOneTab; //Field offset: 0x4A
	public string TextColor; //Field offset: 0x50
	public SdfIconType Icon; //Field offset: 0x58
	public TabLayouting TabLayouting; //Field offset: 0x5C
	public List Tabs; //Field offset: 0x60

	public TabGroupAttribute(string tab, bool useFixedHeight = false, float order = 0) { }

	public TabGroupAttribute(string group, string tab, bool useFixedHeight = false, float order = 0) { }

	public TabGroupAttribute(string group, string tab, SdfIconType icon, bool useFixedHeight = false, float order = 0) { }

	protected virtual void CombineValuesWith(PropertyGroupAttribute other) { }

	private override IList Sirenix.OdinInspector.Internal.ISubGroupProviderAttribute.GetSubGroupAttributes() { }

	private override string Sirenix.OdinInspector.Internal.ISubGroupProviderAttribute.RepathMemberAttribute(PropertyGroupAttribute attr) { }

}

