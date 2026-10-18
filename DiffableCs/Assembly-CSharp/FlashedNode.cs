//Type is in global namespace

public class FlashedNode : Aiming
{
	private float t; //Field offset: 0x38
	private Vector3 angLerpFrom; //Field offset: 0x3C
	private Vector3 angLerpTo; //Field offset: 0x48
	private Vector3 curTrg; //Field offset: 0x54
	private float endTime; //Field offset: 0x60
	private float deltaTime; //Field offset: 0x64
	private readonly float RndOffset; //Field offset: 0x68
	private int SingX; //Field offset: 0x6C
	private int SingZ; //Field offset: 0x70

	public FlashedNode(BotOwner bot) { }

	public static void DrawCross(Vector3 v, Color c) { }

	private Vector3 GetRndDelta() { }

	protected virtual Nullable GetTarget() { }

	private void SetVals() { }

	public virtual void UpdateNodeByBrain(AimingResultParams data) { }

}

