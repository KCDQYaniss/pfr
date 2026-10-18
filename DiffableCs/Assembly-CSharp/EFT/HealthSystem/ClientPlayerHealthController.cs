namespace EFT.HealthSystem;

public sealed class ClientPlayerHealthController : NetworkHealthController
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Callback <>9__7_0; //Field offset: 0x8
		public static Callback <>9__7_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal void <ApplyItem>b__7_0(Result hands) { }

		internal void <ApplyItem>b__7_1(Result hands) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public List pausedEffects; //Field offset: 0x10
		public List pausedEffectsInfo; //Field offset: 0x18
		public ClientPlayerHealthController <>4__this; //Field offset: 0x20

		public <>c__DisplayClass10_0() { }

		internal void <PauseAllEffects>b__0() { }

	}

	private readonly ClientPlayer _player; //Field offset: 0x168

	protected virtual Player Player
	{
		 get { } //Length: 8
	}

	public virtual float StaminaCoeff
	{
		 get { } //Length: 50
		 set { } //Length: 82
	}

	public ClientPlayerHealthController(byte[] serializedState, ClientPlayer player, InventoryController inventoryController, SkillManager skillManager) { }

	public virtual bool ApplyItem(Item item, OneAndList bodyParts, Nullable amount = null) { }

	public virtual bool ApplyItem(Item item, EBodyPart bodyPart, Nullable amount = null) { }

	public virtual void CancelApplyingItem() { }

	protected virtual Player get_Player() { }

	public virtual float get_StaminaCoeff() { }

	public void PauseAllEffects() { }

	protected virtual void set_StaminaCoeff(float value) { }

}

