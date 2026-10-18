//Type is in global namespace

public abstract class ComponentSystem`2 : MonoBehaviour, IComponentSystem
{
	protected List Components; //Field offset: 0x0
	protected int registeredComponentsCount; //Field offset: 0x0

	protected abstract bool HasLateUpdate
	{
		 get { } //Length: 0
	}

	protected abstract bool HasUpdate
	{
		 get { } //Length: 0
	}

	protected ComponentSystem`2() { }

	protected override void Awake() { }

	protected abstract bool get_HasLateUpdate() { }

	protected abstract bool get_HasUpdate() { }

	protected override void LateUpdate() { }

	protected abstract void LateUpdateComponent(T component) { }

	protected override void OnDestroy() { }

	public static void Register(GameObject globalDotNotDestroy) { }

	public override void Register(T component) { }

	public override void Unregister(T component) { }

	protected override void Update() { }

	protected abstract void UpdateComponent(T component) { }

}

