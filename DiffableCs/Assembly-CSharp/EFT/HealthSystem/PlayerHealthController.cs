namespace EFT.HealthSystem;

public class PlayerHealthController : ActiveHealthController
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

	protected bool _started; //Field offset: 0x190

	public virtual float StaminaCoeff
	{
		 get { } //Length: 50
		 set { } //Length: 82
	}

	public PlayerHealthController(HealthInfo healthInfo, Player player, InventoryController inventoryController, SkillManager skillManager, bool aiHealth) { }

	public virtual bool ApplyItem(Item item, OneAndList bodyParts, Nullable amount = null) { }

	public virtual bool ApplyItem(Item item, EBodyPart bodyPart, Nullable amount = null) { }

	public virtual void CancelApplyingItem() { }

	public virtual float get_StaminaCoeff() { }

	protected virtual void ManualEffectUpdate(Effect effect, float deltaTime) { }

	protected virtual void set_StaminaCoeff(float value) { }

	public void Start() { }

}

