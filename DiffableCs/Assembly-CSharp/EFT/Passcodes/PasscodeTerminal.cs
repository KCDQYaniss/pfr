namespace EFT.Passcodes;

public sealed class PasscodeTerminal : InteractableObject
{
	[SerializeField]
	private string _passcodeId; //Field offset: 0x48
	[SerializeField]
	private WorldInteractiveObject _objectToUnlock; //Field offset: 0x50
	[SerializeField]
	private WorldInteractiveObject[] _additionalObjectsToUnlock; //Field offset: 0x58
	[Header("Audio")]
	[SerializeField]
	private AudioClip _successClip; //Field offset: 0x60
	[SerializeField]
	private AudioClip _failureClip; //Field offset: 0x68
	[SerializeField]
	private int _maxDistance; //Field offset: 0x70
	[SerializeField]
	private float _volume; //Field offset: 0x74
	[SerializeField]
	private EOcclusionTest _occlusionTest; //Field offset: 0x78
	[SerializeField]
	private Transform _soundOverrideTransfrom; //Field offset: 0x80
	private int _netId; //Field offset: 0x88

	public WorldInteractiveObject[] AdditionalObjectsToUnlock
	{
		 get { } //Length: 5
	}

	public bool IsInteractable
	{
		 get { } //Length: 44
	}

	public int NetId
	{
		 get { } //Length: 157
	}

	public WorldInteractiveObject ObjectToUnlock
	{
		 get { } //Length: 5
	}

	public string PasscodeId
	{
		 get { } //Length: 5
	}

	public PasscodeTerminal() { }

	public WorldInteractiveObject[] get_AdditionalObjectsToUnlock() { }

	public bool get_IsInteractable() { }

	public int get_NetId() { }

	public WorldInteractiveObject get_ObjectToUnlock() { }

	public string get_PasscodeId() { }

	public void PlayResultSound(bool successful, bool playAsLocal) { }

}

