//Type is in global namespace

public class BotGlobalsChangeSettings
{
	[Comment("коэфициент дальности видимости когда внутри дыма")]
	public float SMOKE_VISION_DIST; //Field offset: 0x10
	[Comment("коэфициент скорости замечания когда внутри дыма")]
	public float SMOKE_GAIN_SIGHT; //Field offset: 0x14
	[Comment("коэфициент точности когда внутри дыма")]
	public float SMOKE_SCATTERING; //Field offset: 0x18
	[Comment("коэфициент скорости прицеливания когда внутри дыма")]
	public float SMOKE_PRECICING; //Field offset: 0x1C
	[Comment("коэфициент слышимости дальности когда внутри дыма")]
	public float SMOKE_HEARING; //Field offset: 0x20
	[Comment("коэфициент скорости прицеливания когда внутри дыма")]
	public float SMOKE_ACCURATY; //Field offset: 0x24
	[Comment("коэфициент шанса лечь в случае опастности внезапной когда внутри дыма")]
	public float SMOKE_LAY_CHANCE; //Field offset: 0x28
	[Comment("коэфициент дальности видимости когда ослеплен")]
	public float FLASH_VISION_DIST; //Field offset: 0x2C
	[Comment("коэфициент скорости замечания когда ослеплен")]
	public float FLASH_GAIN_SIGHT; //Field offset: 0x30
	[Comment("коэфициент точности когда ослеплен")]
	public float FLASH_SCATTERING; //Field offset: 0x34
	[Comment("коэфициент скорости прицеливания когда ослеплен")]
	public float FLASH_PRECICING; //Field offset: 0x38
	[Comment("коэфициент слышимости дальности когда ослеплен")]
	public float FLASH_HEARING; //Field offset: 0x3C
	[Comment("коэфициент скорости прицеливания когда ослеплен")]
	public float FLASH_ACCURATY; //Field offset: 0x40
	[Comment("коэфициент шанса лечь в случае опастности внезапной когда ослеплен")]
	public float FLASH_LAY_CHANCE; //Field offset: 0x44
	[Comment("коэфициент дальности слышимости когда оглушен")]
	public float STUN_HEARING; //Field offset: 0x48
	[Comment("Бот невидим на клиенте. Используется, например, для бота, управляющего башней БТРа")]
	public bool INVISIBLE_ON_CLIENT; //Field offset: 0x4C

	public BotGlobalsChangeSettings() { }

	public void Update() { }

}

