namespace EFT.NextObservedPlayer.Operations;

public class ReloadInternalMagWithOpenBoltHandsOperation : BaseHandsOperation
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public Firearms firearms; //Field offset: 0x10
		public Ammo ammoToLoad; //Field offset: 0x18
		public ReloadInternalMagWithOpenBoltHandsOperation <>4__this; //Field offset: 0x20
		public ReloadInternalMagWithOpenBoltMessage commandMessage; //Field offset: 0x28
		public SafeTaskCompleteSource complete; //Field offset: 0x30

		public <>c__DisplayClass4_0() { }

		internal void <Start>b__0() { }

		internal void <Start>b__1() { }

		internal void <Start>b__2() { }

		internal void <Start>b__3() { }

	}

	private int _magFreeSpace; //Field offset: 0x20
	private int _availableAmmo; //Field offset: 0x24
	private bool _reloadAborted; //Field offset: 0x28

	public ReloadInternalMagWithOpenBoltHandsOperation() { }

	public virtual void CheckAbort(CommandMessageType messageType) { }

	public static ReloadInternalMagWithOpenBoltHandsOperation CreateInstance() { }

	public virtual void FastForward() { }

	public virtual IHandsOperationResult Start(ValueTuple input) { }

}

