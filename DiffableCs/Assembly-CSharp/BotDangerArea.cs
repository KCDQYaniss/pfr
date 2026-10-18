//Type is in global namespace

public class BotDangerArea : BotData
{
	private const float HORIZONTAL_POSIBLE_OFFSET = 3; //Field offset: 0x0
	private float _nextCheckAssaultPosibility; //Field offset: 0x18
	private readonly Dictionary _blockedCovers; //Field offset: 0x20

	public BotDangerArea(BotOwner owner) { }

	public void Activate() { }

	private void BlockCovers(AIDangerArea aiDangerArea) { }

	private void CheckAllActiveZones(HashSet activeAreas) { }

	public void Dispose() { }

	private void OnDangerAreaCreated(AIDangerArea obj) { }

	private void OnDangerAreaRemoved(AIDangerArea obj) { }

	private void UnBlockCovers(AIDangerArea aiDangerArea) { }

}

