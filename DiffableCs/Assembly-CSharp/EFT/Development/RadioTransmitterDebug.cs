namespace EFT.Development;

public class RadioTransmitterDebug : MonoBehaviour
{
	private const string RED_STATE = "<color=red>RED</color>"; //Field offset: 0x0
	private const string GREEN_STATE = "<color=green>GREEN</color>"; //Field offset: 0x0
	private const string YELLOW_STATE = "<color=yellow>YELLOW</color>"; //Field offset: 0x0
	private const string NOT_INIT_STATE = "NOT INITIALIZED"; //Field offset: 0x0
	private const string NO_RT_STATE = "NO RADIO TRANSMITTER"; //Field offset: 0x0
	private const string AGRESSOR = "<color=red>AGRESSOR!</color>"; //Field offset: 0x0
	private bool _isLocalGame; //Field offset: 0x20
	private bool _isEnableZoneDebug; //Field offset: 0x21
	private Player _player; //Field offset: 0x28
	private RadioTransmitterRecodableComponent _recodableComponent; //Field offset: 0x30
	private List allowedPlayerNicks; //Field offset: 0x38
	private List unallowedPlayerNicks; //Field offset: 0x40
	private readonly EquipmentSlot[] _pocketSlots; //Field offset: 0x48

	public RadioTransmitterDebug() { }

	private void FindRecodableComponent() { }

	public void Initialize(PlayerOwner playerOwner) { }

	private void OnAddItem(AddItemEventArgs args) { }

	private void OnDisable() { }

	private void OnGUI() { }

	private void OnRemoveItem(RemoveItemEventArgs args) { }

	private void SetActiveZoneStateOnClient(bool value) { }

	private void SetActiveZoneStateOnServer(bool value) { }

	private void SetStatusForLocalGame() { }

	private void UpdatePlayersInZone(LighthouseTraderZoneData data) { }

	private void UpdateState(bool IsEncoded) { }

}

