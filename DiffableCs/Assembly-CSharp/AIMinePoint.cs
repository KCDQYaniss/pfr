//Type is in global namespace

public class AIMinePoint : MonoBehaviour, IAICorePointLink
{
	public static Vector3 BaseLook; //Field offset: 0x0
	private static Color AUTO_POINT; //Field offset: 0xC
	private static Color PREWARM_POINT; //Field offset: 0x1C
	private static Color PREWARM_POINT_AUTO; //Field offset: 0x2C
	[SerializeField]
	private int _idCore; //Field offset: 0x20
	public int Id; //Field offset: 0x24
	public float Delta; //Field offset: 0x28
	public float LastTimePlanted; //Field offset: 0x2C
	public bool IsAuto; //Field offset: 0x30
	public bool IsForPrewarm; //Field offset: 0x31
	public float SafeRad; //Field offset: 0x34
	public float Priority; //Field offset: 0x38
	private AICorePoint _corePointInGame; //Field offset: 0x40
	[CompilerGenerated]
	private float <SSafeRad>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private bool <HaveSafeRadius>k__BackingField; //Field offset: 0x4C

	public override AICorePoint CorePointInGame
	{
		 get { } //Length: 5
	}

	public private bool HaveSafeRadius
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public override Vector3 Position
	{
		 get { } //Length: 204
	}

	public private float SSafeRad
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	private static AIMinePoint() { }

	public AIMinePoint() { }

	public void DrawGizmos() { }

	public override AICorePoint get_CorePointInGame() { }

	[CompilerGenerated]
	public bool get_HaveSafeRadius() { }

	public override Vector3 get_Position() { }

	[CompilerGenerated]
	public float get_SSafeRad() { }

	public Tuple GetSidePoints() { }

	private void OnDrawGizmos() { }

	private void OnDrawGizmosSelected() { }

	public void Restore(AICorePointHolder cores) { }

	[CompilerGenerated]
	private void set_HaveSafeRadius(bool value) { }

	[CompilerGenerated]
	private void set_SSafeRad(float value) { }

	public void SetCore(AICorePoint coreP) { }

}

