namespace CommonAssets.Scripts.Cutscenes;

public class CutsceneActionChangeStateBehaviours : CutsceneBaseAction
{
	private class BehaviourData
	{
		public Behaviour behaviour; //Field offset: 0x10
		public bool targetState; //Field offset: 0x18

		public BehaviourData() { }

	}

	[SerializeField]
	private BehaviourData[] _behavioursData; //Field offset: 0x40

	public CutsceneActionChangeStateBehaviours() { }

	public virtual void Init() { }

}

