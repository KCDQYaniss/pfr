namespace EFT.Hideout;

public class HideoutSkillManager
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__9_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <CheckBuffsOfSkill>b__9_0(ItemsProducerBase x) { }

	}

	private readonly Dictionary _producerToDataLinks; //Field offset: 0x10
	private readonly Dictionary _resourceConsumers; //Field offset: 0x18
	private SkillManager _skillManager; //Field offset: 0x20
	private ProductionController _productionController; //Field offset: 0x28
	private HideoutRepresentation _hideout; //Field offset: 0x30
	private bool _eliteCrafting; //Field offset: 0x38

	public HideoutSkillManager() { }

	private void CheckBuffsOfSkill(Skill skill) { }

	public void DeInit() { }

	public void Init(Profile profile, HideoutRepresentation hideout) { }

	private void OnSkillLevelChangedHandler(BaseSkill baseSkill) { }

}

