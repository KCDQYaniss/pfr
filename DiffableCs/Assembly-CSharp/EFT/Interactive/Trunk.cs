namespace EFT.Interactive;

public class Trunk : WorldInteractiveObject
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public InteractionResult interactionResult; //Field offset: 0x10
		public Trunk <>4__this; //Field offset: 0x18

		public <>c__DisplayClass4_0() { }

		internal void <Interact>b__0() { }

	}

	[Header("Interactions")]
	[SerializeField]
	private EInteraction _openInteraction; //Field offset: 0x178
	[SerializeField]
	private EInteraction _closeInteraction; //Field offset: 0x179

	public virtual string TypeKey
	{
		 get { } //Length: 49
	}

	public Trunk() { }

	protected virtual int CalculateInteractionIndex(Vector3 playerPosition) { }

	public virtual string get_TypeKey() { }

	public virtual InteractionParameters GetInteractionParameters(Vector3 playerPosition) { }

	public virtual void Interact(InteractionResult interactionResult) { }

	protected virtual void ProcessOcclusion(BetterSource source, Vector3 position) { }

}

