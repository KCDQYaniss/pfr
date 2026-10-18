namespace Sirenix.OdinInspector;

[AttributeUsage(384)]
public class TypeDrawerSettingsAttribute : Attribute
{
	public Type BaseType; //Field offset: 0x10
	public TypeInclusionFilter Filter; //Field offset: 0x18

	public TypeDrawerSettingsAttribute() { }

}

