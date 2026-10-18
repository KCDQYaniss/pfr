namespace EFT.Hideout.ShootingRange;

public class PaperTargetControl : InteractiveShootingRange
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__4_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <FindTargetsButton>b__4_0(PaperTarget v) { }

	}

	[SerializeField]
	[Space]
	private PaperTarget[] _paperTargets; //Field offset: 0x50
	[SerializeField]
	[Space]
	private AudioSource _replaceTargetsAudio; //Field offset: 0x58

	public PaperTargetControl() { }

	private void FindTargetsButton() { }

	public virtual AvailableInteractionState InteractionStates(HideoutPlayerOwner owner) { }

	private void ReplaceTargets() { }

}

