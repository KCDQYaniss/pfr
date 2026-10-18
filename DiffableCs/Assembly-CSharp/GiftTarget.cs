//Type is in global namespace

public class GiftTarget
{
	private const float REPEAT_TRY_GIFT_PLAYER_TIME = 60; //Field offset: 0x0
	private const float TIME_TO_LOSE_GIFT_TARGET = 20; //Field offset: 0x0
	public IPlayer player; //Field offset: 0x10
	public float prevBeginGiftNodeTime; //Field offset: 0x18
	private bool _alreadyGifted; //Field offset: 0x1C
	private int _additionalGiftsGifted; //Field offset: 0x20
	private readonly int _additionalGiftsLimit; //Field offset: 0x24
	private bool _canDoAdditionalGift; //Field offset: 0x28

	public GiftTarget(int additionalGiftsLimit) { }

	public void AllowToDropAdditionalGift() { }

	public bool CanDoGift() { }

	private bool CanDropAdditionalGift() { }

	public void MarkGifted() { }

	public bool ReadyToNextGift() { }

	public bool TargetLost() { }

}

