namespace UnityEngine.Timeline;

[AttributeUsage(AttributeTargets::Class (4))]
public class TrackColorAttribute : Attribute
{
	private Color m_Color; //Field offset: 0x10

	public Color color
	{
		 get { } //Length: 11
	}

	public TrackColorAttribute(float r, float g, float b) { }

	public Color get_color() { }

}

