namespace EFT.Interactive;

[ScriptOrder(20500)]
public class LampSystem : ComponentSystem
{
	private const int InterLoopBatchCount = 64; //Field offset: 0x0
	public const int FramesPerFullUpdate = 30; //Field offset: 0x0
	private LampVisualScheduler _visualScheduler; //Field offset: 0x30
	private Camera _mainCamera; //Field offset: 0x38

	protected virtual bool HasLateUpdate
	{
		 get { } //Length: 3
	}

	protected virtual bool HasUpdate
	{
		 get { } //Length: 3
	}

	public LampSystem() { }

	protected virtual void Awake() { }

	protected virtual bool get_HasLateUpdate() { }

	protected virtual bool get_HasUpdate() { }

	private Camera GetCamera() { }

	protected virtual void LateUpdate() { }

	protected virtual void LateUpdateComponent(LampController component) { }

	protected virtual void OnDestroy() { }

	public virtual void Register(LampController component) { }

	public virtual void Unregister(LampController component) { }

	protected virtual void Update() { }

	protected virtual void UpdateComponent(LampController component) { }

}

