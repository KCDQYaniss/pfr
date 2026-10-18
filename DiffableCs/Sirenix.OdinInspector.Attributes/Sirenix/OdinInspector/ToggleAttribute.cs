namespace Sirenix.OdinInspector;

[AttributeUsage(AttributeTargets::All (32767), AllowMultiple = False, Inherited = True)]
[Conditional("UNITY_EDITOR")]
public sealed class ToggleAttribute : Attribute
{
	public string ToggleMemberName; //Field offset: 0x10
	public bool CollapseOthersOnExpand; //Field offset: 0x18

	public ToggleAttribute(string toggleMemberName) { }

}

