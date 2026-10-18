//Type is in global namespace

public class BotUnderbarrelLauncherAimingSettings
{
	public float AIMING_ON_WAY; //Field offset: 0x10
	[Comment("Шанс что бот будет включать фонарик когда целится")]
	public float ANYTIME_LIGHT_WHEN_AIM_100; //Field offset: 0x14
	[Comment("Базовое кл-во попадаий мимо МИН")]
	public int BAD_SHOOTS_MIN; //Field offset: 0x18
	[Comment("Базовое кл-во попадаий мимо МАКС")]
	public int BAD_SHOOTS_MAX; //Field offset: 0x1C
	public float START_TIME_COEF; //Field offset: 0x20
	[Comment("это вероятность того что бот скосит стрельбу при попадании по нему. Альтернатива - ухудшить время прицеливания.")]
	public float DAMAGE_TO_DISCARD_AIM_0_100; //Field offset: 0x24
	[Comment("Минимальное ухудшение времени прицеливания")]
	public float MIN_TIME_DISCARD_AIM_SEC; //Field offset: 0x28
	[Comment("Макс ухудшение времени прицеливания")]
	public float MAX_TIME_DISCARD_AIM_SEC; //Field offset: 0x2C
	[Comment("Время для Максимальное улучшение стрельбы в зависимости от того как долго бот целиться")]
	public float MAX_AIM_PRECICING; //Field offset: 0x30
	[Comment("насколько лучше может стать стрельба от пристрелки - 0.15 == 85%.  0.5 == 50%  . 1 == 0%")]
	public float MAX_AIMING_UPGRADE_BY_TIME; //Field offset: 0x34
	[Comment("Бот считается что двигается если он прошел за кадр больше чем Х")]
	public float BOT_MOVE_IF_DELTA; //Field offset: 0x38
	[Comment("Время паники при обычное")]
	public float PANIC_TIME; //Field offset: 0x3C
	[Comment("После скольки попыток доприцелится бот все равно переприцелится даже если было цель очень близко  min max")]
	public int RECALC_MUST_TIME_MIN; //Field offset: 0x40
	[Comment("После скольки попыток доприцелится бот все равно переприцелится даже если было цель очень близко  min max")]
	public int RECALC_MUST_TIME_MAX; //Field offset: 0x44
	[Comment("дистанции при сдвижение на который прицеливание не прерветься по Y")]
	public float RECLC_Y_DIST; //Field offset: 0x48
	[Comment("    float BASE_ANF_COEF = 7;")]
	public float RECALC_SQR_DIST; //Field offset: 0x4C
	[Comment("Настолько дольше будет прицеливание если бот стреляет сходу")]
	public float TIME_COEF_IF_MOVE; //Field offset: 0x50
	[Comment("Время прицеливания умножается на этот коэфициент если чар паникует")]
	public float PANIC_COEF; //Field offset: 0x54
	[Comment("усиленное прицеливание когда выглядываешь за укрытия")]
	public float COEF_FROM_COVER; //Field offset: 0x58
	[Comment("Базовое время прицеливания. Прибавляетя к результату полученному по формуле")]
	public float BOTTOM_COEF; //Field offset: 0x5C
	[Comment("Максимальное время прицеливания")]
	public float MAX_AIM_TIME; //Field offset: 0x60
	[Comment("Модификатор зависимости прицеливанипя от дистанции не линейног (за линейность отвечает др. параметр).   //рекумендуемые знаечни 0.2..1.3.     //Меньше 1 - значит чем дальше тем будет точнее чем лнейная зависимость. Больше - косее.")]
	public float SCATTERING_DIST_MODIF; //Field offset: 0x64
	[Comment(" Модификатор зависимости прицеливанипя от дистанции не линейног (за линейность отвечает др. параметр).   //рекумендуемые знаечни 0.2..1.3.     //Меньше 1 - значит чем дальше тем будет точнее чем лнейная зависимость. Больше - косее.")]
	public float SCATTERING_DIST_MODIF_CLOSE; //Field offset: 0x68
	[Comment("Если враг ближе чем Х то разлета не будет.")]
	public float DIST_TO_SHOOT_NO_OFFSET; //Field offset: 0x6C
	[Comment("Коэфициент увеличения разлета при панике")]
	public float PANIC_ACCURATY_COEF; //Field offset: 0x70
	[Comment("Коэфициент улучшенного прицеливания")]
	public float HARD_AIM; //Field offset: 0x74
	[Comment("Настолько больше будет разлет если бот стреляет сходу")]
	public float COEF_IF_MOVE; //Field offset: 0x78
	[Comment("Уровень сжатия прицельной сферы сверху")]
	public float Y_TOP_OFFSET_COEF; //Field offset: 0x7C
	[Comment("Уровень сжатия прицельной сферы снизу")]
	public float Y_BOTTOM_OFFSET_COEF; //Field offset: 0x80
	[Comment("Насколько выше выстрелит бот если захочет стрелять мимо")]
	public float NEXT_SHOT_MISS_Y_OFFSET; //Field offset: 0x84
	[Comment("если мы стреляем мимо, то бот настолько отводит свой прицел от цели в метрах")]
	public float BAD_SHOOTS_OFFSET; //Field offset: 0x88
	[Comment("Базовый коэфициент из формулы == N        N*ln(x/5+1.2)")]
	public float BAD_SHOOTS_MAIN_COEF; //Field offset: 0x8C
	public float OFFSET_RECAL_ANYWAY_TIME; //Field offset: 0x90

	public BotUnderbarrelLauncherAimingSettings() { }

}

