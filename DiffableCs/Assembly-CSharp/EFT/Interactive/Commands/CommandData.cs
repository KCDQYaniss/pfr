namespace EFT.Interactive.Commands;

public struct CommandData
{
	public string StringValue; //Field offset: 0x0
	public Vector3 Vector1Value; //Field offset: 0x8
	public Vector3 Vector2Value; //Field offset: 0x14
	public float FloatValue; //Field offset: 0x20
	public AudioClip AudioClipValue; //Field offset: 0x28

	public static CommandData Empty
	{
		 get { } //Length: 18
	}

	public static CommandData get_Empty() { }

}

