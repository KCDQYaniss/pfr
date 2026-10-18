namespace EFT;

public sealed class RpcSendSyncWeaponDataMessage : ISerializableMessage
{
	[CompilerGenerated]
	private ItemDescriptor <WeaponDescriptor>k__BackingField; //Field offset: 0x10

	public private ItemDescriptor WeaponDescriptor
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public RpcSendSyncWeaponDataMessage() { }

	public RpcSendSyncWeaponDataMessage(ItemDescriptor weaponDescriptor) { }

	public override void Deserialize(NetworkReader reader) { }

	[CompilerGenerated]
	public ItemDescriptor get_WeaponDescriptor() { }

	public override void Serialize(NetworkWriter writer) { }

	[CompilerGenerated]
	private void set_WeaponDescriptor(ItemDescriptor value) { }

}

