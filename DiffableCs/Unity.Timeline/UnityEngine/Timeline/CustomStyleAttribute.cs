namespace UnityEngine.Timeline;

[AttributeUsage(AttributeTargets::Class (4))]
public class CustomStyleAttribute : Attribute
{
	public readonly string ussStyle; //Field offset: 0x10

	public CustomStyleAttribute(string ussStyle) { }

}

