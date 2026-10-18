namespace EFT.UI.Gestures;

public sealed class GesturesCommandsStorage
{
	private const string PMC_BIND_COMMANDS_NAME = "BindCommands"; //Field offset: 0x0
	private const string SCAV_BIND_COMMANDS_NAME = "ScavBindCommands"; //Field offset: 0x0
	public readonly EPlayerSide Side; //Field offset: 0x10
	private readonly bool _autoSave; //Field offset: 0x14
	private GestureCommands _savedGesturesCommands; //Field offset: 0x18
	private GestureCommands _actualGesturesCommands; //Field offset: 0x20

	private string BindCommandsName
	{
		private get { } //Length: 84
	}

	public bool IsChanged
	{
		 get { } //Length: 64
	}

	public GesturesCommandsStorage(bool autoSave, EPlayerSide side) { }

	private string get_BindCommandsName() { }

	public bool get_IsChanged() { }

	public GestureCommands GetCommands() { }

	private static GestureCommands GetDefault() { }

	private GestureCommands GetSavedCommands() { }

	public void Reset() { }

	public void Rollback() { }

	public void Save() { }

	public void SetChanges(GestureCommands gesturesCommands) { }

}

