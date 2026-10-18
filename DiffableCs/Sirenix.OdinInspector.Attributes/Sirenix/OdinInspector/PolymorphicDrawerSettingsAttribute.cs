namespace Sirenix.OdinInspector;

[AttributeUsage(384)]
public class PolymorphicDrawerSettingsAttribute : Attribute
{
	public bool ReadOnlyIfNotNullReference; //Field offset: 0x10
	public string CreateInstanceFunction; //Field offset: 0x18
	[Obsolete("Use OnValueChangedAttribute instead.", False)]
	public string OnInstanceAssigned; //Field offset: 0x20
	private Nullable showBaseType; //Field offset: 0x28
	private Nullable nonDefaultConstructorPreference; //Field offset: 0x2C

	public NonDefaultConstructorPreference NonDefaultConstructorPreference
	{
		 get { } //Length: 88
		 set { } //Length: 86
	}

	public bool NonDefaultConstructorPreferenceIsSet
	{
		 get { } //Length: 62
	}

	public bool ShowBaseType
	{
		 get { } //Length: 62
		 set { } //Length: 78
	}

	public bool ShowBaseTypeIsSet
	{
		 get { } //Length: 62
	}

	public PolymorphicDrawerSettingsAttribute() { }

	public NonDefaultConstructorPreference get_NonDefaultConstructorPreference() { }

	public bool get_NonDefaultConstructorPreferenceIsSet() { }

	public bool get_ShowBaseType() { }

	public bool get_ShowBaseTypeIsSet() { }

	public void set_NonDefaultConstructorPreference(NonDefaultConstructorPreference value) { }

	public void set_ShowBaseType(bool value) { }

}

