//Type is in global namespace

public class RecoilData
{
	private float _remainRecoilTime; //Field offset: 0x10
	private float _lastRecoilSetTime; //Field offset: 0x14
	private Vector3 _recoilOffset; //Field offset: 0x18
	private Vector3 _lastRecoilFullOffset; //Field offset: 0x24
	private readonly BotOwner _owner; //Field offset: 0x30
	private float _endRecoilTime; //Field offset: 0x38
	private readonly bool _endRecoilCheck; //Field offset: 0x3C

	public Vector3 RecoilOffset
	{
		 get { } //Length: 19
	}

	public RecoilData(BotOwner owner) { }

	public void CheckEndRecoil() { }

	public Vector3 get_RecoilOffset() { }

	public string Info() { }

	public void LosingRecoil() { }

	public void Recoil() { }

}

