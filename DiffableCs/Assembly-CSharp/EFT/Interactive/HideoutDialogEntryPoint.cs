namespace EFT.Interactive;

public sealed class HideoutDialogEntryPoint : DialogEntryPointBase
{
	[SerializeField]
	private CinemachineVirtualCamera _camera; //Field offset: 0x90
	[SerializeField]
	private Vector3 _playerTeleportPosition; //Field offset: 0x98
	[SerializeField]
	private Vector3 _playerTeleportRotation; //Field offset: 0xA4
	private HideoutPlayerOwner _hideoutPlayerOwner; //Field offset: 0xB0

	public HideoutDialogEntryPoint() { }

	public bool HasInvitation(out string invitationOwner) { }

	public AvailableInteractionState InteractionStates(HideoutPlayerOwner owner) { }

	private void StartDialogue() { }

	public void StartDialogue(HideoutPlayerOwner hideoutPlayerOwner, bool teleportPlayer) { }

	protected virtual void UpdateAvailability() { }

}

