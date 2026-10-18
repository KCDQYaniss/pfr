namespace EFT.NextObservedPlayer;

public class ReloadCylinderMagazineHandsOperation : BaseHandsOperation
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public ReloadCylinderMagazineHandsOperation <>4__this; //Field offset: 0x10
		public ReloadCylinderMagazineCommandMessage commandMessage; //Field offset: 0x18
		public Firearms firearms; //Field offset: 0x20
		public Ammo ammoForLoad; //Field offset: 0x28
		public ObservedPlayerHandsController handsController; //Field offset: 0x30
		public SafeTaskCompleteSource complete; //Field offset: 0x38

		public <>c__DisplayClass6_0() { }

		internal void <Start>b__0() { }

		internal void <Start>b__1() { }

		internal void <Start>b__2() { }

		internal void <Start>b__3() { }

		internal void <Start>b__4() { }

	}

	private int _indexOfShellForRemove; //Field offset: 0x20
	private int _indexOfFreeCamora; //Field offset: 0x24
	private bool _reloadAborted; //Field offset: 0x28

	public virtual bool CanFastForward
	{
		 get { } //Length: 3
	}

	public ReloadCylinderMagazineHandsOperation() { }

	public virtual void CheckAbort(CommandMessageType messageType) { }

	public static ReloadCylinderMagazineHandsOperation CreateInstance() { }

	public virtual void FastForward() { }

	public virtual bool get_CanFastForward() { }

	private void RemoveAllAmmo(Firearms firearms) { }

	private void RemoveAllShells(Firearms firearms) { }

	public virtual IHandsOperationResult Start(ValueTuple input) { }

}

