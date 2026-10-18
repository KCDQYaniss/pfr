namespace EFT.Hideout;

public sealed class MultiObjectAmbiance : InteractiveAmbianceObject
{
	[CompilerGenerated]
	private struct <PerformInteraction>d__10 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MultiObjectAmbiance <>4__this; //Field offset: 0x20
		public ELightStatus status; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal class AffectedMultiShaders : AmbianceAffectedShader
	{
		public List ExtraShaders; //Field offset: 0x88
		private IEnumerable _extraMaterials; //Field offset: 0x90

		public AffectedMultiShaders() { }

		[CompilerGenerated]
		private Material <InitTween>b__3_0(GameObject x) { }

		[CompilerGenerated]
		private void <InitTween>g__OnUpdate|3_1() { }

		protected virtual void InitLoopEffect() { }

		protected virtual void InitTween(Tween tween) { }

	}

	internal sealed class AmbianceAffectedComponent : ControlledObject
	{
		public MonoBehaviour AffectedComponent; //Field offset: 0x20
		public string MethodName; //Field offset: 0x28

		public AmbianceAffectedComponent() { }

		public virtual void Destroy() { }

		public virtual void Disable() { }

		public virtual void PerformTransition() { }

	}

	internal sealed class AmbianceAffectedFlicker : ControlledObject
	{
		public LightFlicker AffectedFlicker; //Field offset: 0x20
		public bool IsActive; //Field offset: 0x28

		public AmbianceAffectedFlicker() { }

		public virtual void Destroy() { }

		public virtual void Disable() { }

		public virtual void PerformTransition() { }

	}

	internal sealed class AmbianceAffectedGameObject : ControlledObject
	{
		public GameObject AffectedObject; //Field offset: 0x20
		public bool IsActive; //Field offset: 0x28

		public AmbianceAffectedGameObject() { }

		public virtual void Destroy() { }

		public virtual void Disable() { }

		public virtual void PerformTransition() { }

	}

	internal sealed class AmbianceAffectedLamp : ControlledObject
	{
		public LampController AffectedObject; //Field offset: 0x20
		public bool Active; //Field offset: 0x28
		public RandomBetweenFloats Flickering; //Field offset: 0x30
		[Range(0, 100)]
		public float FlickeringChance; //Field offset: 0x38

		public AmbianceAffectedLamp() { }

		public virtual void Destroy() { }

		public virtual void Disable() { }

		public virtual void PerformTransition() { }

	}

	internal sealed class AmbianceAffectedLight : LoopedAmbianceAffectedObject
	{
		public float Intensity; //Field offset: 0x50
		public bool ChangeColor; //Field offset: 0x54
		public Color Color; //Field offset: 0x58

		public AmbianceAffectedLight() { }

		public virtual void PerformTransition() { }

	}

	internal sealed class AmbianceAffectedObjects
	{
		public List ControlledObjects; //Field offset: 0x10
		public float TransitionTime; //Field offset: 0x18
		public float RandomRange; //Field offset: 0x1C
		public Ease TransitionType; //Field offset: 0x20
		private float _currentTransitionTime; //Field offset: 0x24

		public AmbianceAffectedObjects() { }

		public void Destroy() { }

		public void Disable() { }

		public float GetTime(bool update) { }

		public void PerformTransition() { }

	}

	internal class AmbianceAffectedShader : LoopedAmbianceAffectedObject
	{
		public string PropertyName; //Field offset: 0x50
		public int MaterialNumber; //Field offset: 0x58
		public bool Float; //Field offset: 0x5C
		public bool Color; //Field offset: 0x5D
		public bool Random; //Field offset: 0x5E
		public float PropertyValue; //Field offset: 0x60
		public Color PropertyColor; //Field offset: 0x64
		public RandomBetweenFloats PropertyRandom; //Field offset: 0x78
		protected Material Material; //Field offset: 0x80

		public AmbianceAffectedShader() { }

		private void Clear() { }

		protected virtual void InitLoopEffect() { }

		public virtual void PerformTransition() { }

		public void SetColor() { }

		public void SetFloat() { }

		public void SetRandom() { }

	}

	internal abstract class AnimatedAmbianceAffectedObject : ControlledObject
	{
		protected string TweenId; //Field offset: 0x20
		private string _propertyId; //Field offset: 0x28

		protected string PropertyId
		{
			 get { } //Length: 144
			 set { } //Length: 82
		}

		protected AnimatedAmbianceAffectedObject() { }

		protected string get_PropertyId() { }

		protected string GetObjectId(Object obj, string propertyId = null) { }

		protected void set_PropertyId(string value) { }

	}

	internal abstract class LoopedAmbianceAffectedObject`2 : AnimatedAmbianceAffectedObject
	{
		public bool Loop; //Field offset: 0x0
		public TLoopedAmbiance LoopEffect; //Field offset: 0x0
		public TUnityObject AffectedObject; //Field offset: 0x0
		[HideInInspector]
		[SerializeField]
		private bool _secondaryAction; //Field offset: 0x0

		protected LoopedAmbianceAffectedObject`2() { }

		[CompilerGenerated]
		private void <LoopTween>b__4_0() { }

		public virtual void Destroy() { }

		public virtual void Disable() { }

		protected override void InitLoopEffect() { }

		protected override void InitTween(Tween tween) { }

		private void LoopEffectChanged() { }

		public void LoopTween(Tween tween, TUnityObject target, string propertyName = null, Tween[] extraTweens) { }

		protected bool SecondaryAction() { }

	}


	public MultiObjectAmbiance() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private Task <>n__0(ELightStatus status) { }

	private void OnDestroy() { }

	protected virtual void OnDisable() { }

	[AsyncStateMachine(typeof(<PerformInteraction>d__10))]
	public virtual Task PerformInteraction(ELightStatus status) { }

}

