namespace EFT.Vehicle;

public class BTRTurretView : MonoBehaviour
{
	public Transform gunsBlockRoot; //Field offset: 0x20
	public Transform machineGunRoot; //Field offset: 0x28
	public Transform machineGunLaunchPoint; //Field offset: 0x30
	[SerializeField]
	private string[] _gunModsToDisable; //Field offset: 0x38
	public Transform GunRoot; //Field offset: 0x40
	public Transform BotRoot; //Field offset: 0x48
	private float _targetTurretRotate; //Field offset: 0x50
	private float _targetGunsBlockRotate; //Field offset: 0x54
	public float rotateLerpValue; //Field offset: 0x58
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"player", "initialized"})]
	private ValueTuple _bot; //Field offset: 0x60
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"player", "initialized"})]
	private ValueTuple _offlineBot; //Field offset: 0x70

	public BTRTurretView() { }

	public void AttachBot(int btrBotId) { }

	private void HideBotTacticalVest(ObservedPlayerView player) { }

	private void HideBotTacticalVest(Player player) { }

	private void LerpRotate() { }

	public void SetGunsBlockRotation(float eulerAngle) { }

	public void SetTurretRotation(float eulerAngle) { }

	private void Start() { }

	private void ToggleGunMods(ObservedPlayerView player, bool enable) { }

	private void ToggleGunMods(LocalPlayer player, bool enable) { }

	private bool TryBotInitialization(int btrBotId) { }

	private bool TryGetWeapon(ObservedPlayerView player, out WeaponPrefab weaponPrefab, out Transform weapon) { }

	private bool TryGetWeapon(LocalPlayer player, out WeaponPrefab weaponPrefab, out Transform weapon) { }

	private void Update() { }

}

