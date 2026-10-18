//Type is in global namespace

public sealed class DriveStateIconController : MonoBehaviour
{
	private enum STATE
	{
		OFF = 0,
		NOINFO = 1,
		GREEN = 2,
		ORANGE = 3,
		RED = 4,
		BLOODY = 5,
	}

	public static bool ShowIcon; //Field offset: 0x0
	private static int NoInfoBusyLevel; //Field offset: 0x4
	private static int HideIconBusyLevel; //Field offset: 0x8
	public Texture2D StorageGreen; //Field offset: 0x20
	public Texture2D StorageOrange; //Field offset: 0x28
	public Texture2D StorageRed; //Field offset: 0x30
	public Texture2D StorageBloody; //Field offset: 0x38
	public Texture2D StorageNoInfo; //Field offset: 0x40
	private RawImage _image; //Field offset: 0x48
	private STATE _state; //Field offset: 0x50

	private static DriveStateIconController() { }

	public DriveStateIconController() { }

	private void Awake() { }

	private STATE PercentToState(int percent) { }

	public void SetDriveLoadState(int busyPercent) { }

	private Texture2D StateToImage(STATE state) { }

	private void Update() { }

}

