namespace Sirenix.OdinInspector;

[AttributeUsage(AttributeTargets::All (32767), AllowMultiple = False, Inherited = True)]
[Conditional("UNITY_EDITOR")]
public sealed class MinMaxSliderAttribute : Attribute
{
	public float MinValue; //Field offset: 0x10
	public float MaxValue; //Field offset: 0x14
	public string MinValueGetter; //Field offset: 0x18
	public string MaxValueGetter; //Field offset: 0x20
	public string MinMaxValueGetter; //Field offset: 0x28
	public bool ShowFields; //Field offset: 0x30

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Use the MaxValueGetter member instead.", False)]
	public string MaxMember
	{
		 get { } //Length: 5
		 set { } //Length: 82
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Use the MinMaxValueGetter member instead.", False)]
	public string MinMaxMember
	{
		 get { } //Length: 5
		 set { } //Length: 82
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Use the MinValueGetter member instead.", False)]
	public string MinMember
	{
		 get { } //Length: 5
		 set { } //Length: 82
	}

	public MinMaxSliderAttribute(float minValue, float maxValue, bool showFields = false) { }

	public MinMaxSliderAttribute(string minValueGetter, float maxValue, bool showFields = false) { }

	public MinMaxSliderAttribute(float minValue, string maxValueGetter, bool showFields = false) { }

	public MinMaxSliderAttribute(string minValueGetter, string maxValueGetter, bool showFields = false) { }

	public MinMaxSliderAttribute(string minMaxValueGetter, bool showFields = false) { }

	public string get_MaxMember() { }

	public string get_MinMaxMember() { }

	public string get_MinMember() { }

	public void set_MaxMember(string value) { }

	public void set_MinMaxMember(string value) { }

	public void set_MinMember(string value) { }

}

