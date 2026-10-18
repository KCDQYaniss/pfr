namespace Dissonance.Config;

public class ChatRoomSettings : ScriptableObject
{
	private const string SettingsFileResourceName = "ChatRoomSettings"; //Field offset: 0x0
	public static readonly string SettingsFilePath; //Field offset: 0x0
	private static readonly List DefaultRooms; //Field offset: 0x8
	private static ChatRoomSettings _instance; //Field offset: 0x10
	[SerializeField]
	internal List Names; //Field offset: 0x18
	private Dictionary _nameLookup; //Field offset: 0x20

	[NotNull]
	public static ChatRoomSettings Instance
	{
		 get { } //Length: 462
	}

	private static ChatRoomSettings() { }

	public ChatRoomSettings() { }

	[CanBeNull]
	public string FindRoomById(ushort id) { }

	public static ChatRoomSettings get_Instance() { }

	public static ChatRoomSettings Load() { }

	public static void Preload() { }

}

