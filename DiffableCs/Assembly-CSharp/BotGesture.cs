//Type is in global namespace

public class BotGesture : BotData
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public AIGestusRequest request; //Field offset: 0x10

		public <>c__DisplayClass10_0() { }

		internal bool <TryAddRequest>b__0(EInteraction x) { }

	}

	public AIGestusRequest CurRequest; //Field offset: 0x18
	private float _nextPosibleGestus; //Field offset: 0x20
	private readonly List executedTypes; //Field offset: 0x28
	private readonly Dictionary history; //Field offset: 0x30

	public BotGesture(BotOwner owner) { }

	private void ApplyRequest(AIGestusRequest request) { }

	private int CalcGetOffGestures(List list) { }

	public bool CurRequestExecuting() { }

	public bool HaveRequest() { }

	public void StartExecuteCur() { }

	public void StartSecondPart() { }

	public void TryAddRequest(AIGestusRequest request, bool force, bool withCheckDist) { }

	public void TryGestus(EInteraction gesture, bool withAimingDelay) { }

}

