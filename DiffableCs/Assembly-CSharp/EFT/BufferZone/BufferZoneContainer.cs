namespace EFT.BufferZone;

public class BufferZoneContainer : MonoBehaviour
{
	[SerializeField]
	private BufferGates _gates; //Field offset: 0x20
	[SerializeField]
	private BufferInnerZone _innerZone; //Field offset: 0x28
	[SerializeField]
	private BufferOuterBattleZone _outerBattleZone; //Field offset: 0x30
	[SerializeField]
	private BufferGateSwitcher _innerSwitcher; //Field offset: 0x38
	[SerializeField]
	private BufferGateSwitcher _outerSwitcher; //Field offset: 0x40

	public BufferOuterBattleZone BattleOuterZone
	{
		 get { } //Length: 76
	}

	public BufferGates Gates
	{
		 get { } //Length: 5
	}

	public BufferGateSwitcher InnerSwitcher
	{
		 get { } //Length: 5
	}

	public BufferInnerZone InnerZone
	{
		 get { } //Length: 5
	}

	public BufferGateSwitcher OuterSwitcher
	{
		 get { } //Length: 5
	}

	public BufferZoneContainer() { }

	private void Awake() { }

	public BufferOuterBattleZone get_BattleOuterZone() { }

	public BufferGates get_Gates() { }

	public BufferGateSwitcher get_InnerSwitcher() { }

	public BufferInnerZone get_InnerZone() { }

	public BufferGateSwitcher get_OuterSwitcher() { }

	private void OnDestroy() { }

	private void RegisterThisContainer() { }

	private void Start() { }

}

