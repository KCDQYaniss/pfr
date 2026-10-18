//Type is in global namespace

public class BotGlobalAimingSettings
{
	[Comment("Время для Максимальное улучшение стрельбы в зависимости от того как долго бот целиться")]
	public float MAX_AIM_PRECICING; //Field offset: 0x10
	[Comment("Коэфициент скорость пристрелки. Больше == Лучше")]
	public float BETTER_PRECICING_COEF; //Field offset: 0x14
	[Comment("дистанции при сдвижение на который прицеливание не прерветься по Y")]
	public float RECLC_Y_DIST; //Field offset: 0x18
	[Comment("дистанции при сдвижение на который прицеливание не прерветься по XZ")]
	public float RECALC_DIST; //Field offset: 0x1C
	[Comment("    public float BASE_ANF_COEF = 7;")]
	public float RECALC_SQR_DIST; //Field offset: 0x20
	[Comment("усиленное прицеливание когда выглядываешь за укрытия")]
	public float COEF_FROM_COVER; //Field offset: 0x24
	[Comment("Время прицеливания умножается на этот коэфициент если чар паникует")]
	public float PANIC_COEF; //Field offset: 0x28
	[Comment("Коэфициент увеличения разлета при панике")]
	public float PANIC_ACCURATY_COEF; //Field offset: 0x2C
	[Comment("Коэфициент улучшенного прицеливания")]
	public float HARD_AIM; //Field offset: 0x30
	[Comment("шанс прицеливания по время стрельбы [0;100]")]
	public int HARD_AIM_CHANCE_100; //Field offset: 0x34
	[Comment("Время паники при обычное")]
	public float PANIC_TIME; //Field offset: 0x38
	[Comment("После скольки попыток доприцелится бот все равно переприцелится даже если было цель очень близко")]
	public int RECALC_MUST_TIME; //Field offset: 0x3C
	[Comment("После скольки попыток доприцелится бот все равно переприцелится даже если было цель очень близко  min max")]
	public int RECALC_MUST_TIME_MIN; //Field offset: 0x40
	[Comment("После скольки попыток доприцелится бот все равно переприцелится даже если было цель очень близко  min max")]
	public int RECALC_MUST_TIME_MAX; //Field offset: 0x44
	[Comment("Время паники при попадании по боту.")]
	public float DAMAGE_PANIC_TIME; //Field offset: 0x48
	[Comment("уровень стрельбы по опасной точке")]
	public float DANGER_UP_POINT; //Field offset: 0x4C
	[Comment("насколько лучше может стать стрельба от пристрелки - 0.15 == 85%.  0.5 == 50%  . 1 == 0%")]
	public float MAX_AIMING_UPGRADE_BY_TIME; //Field offset: 0x50
	[Comment("это вероятность того что бот скосит стрельбу при попадании по нему. Альтернатива - ухудшить время прицеливания.")]
	public float DAMAGE_TO_DISCARD_AIM_0_100; //Field offset: 0x54
	[Comment("Шанс на ухудшение времени прицеливания")]
	public float CHANCE_DISCARD_AIM_SEC; //Field offset: 0x58
	[Comment("Минимальное ухудшение времени прицеливания")]
	public float MIN_TIME_DISCARD_AIM_SEC; //Field offset: 0x5C
	[Comment("Макс ухудшение времени прицеливания")]
	public float MAX_TIME_DISCARD_AIM_SEC; //Field offset: 0x60
	[Comment("Коэфициент зависимости прицеливания в горизонтальной плоскости в зависимости от угла до цели")]
	public float XZ_COEF; //Field offset: 0x64
	[Comment("Коэфициент зависимости прицеливания в горизонтальной плоскости в зависимости от угла до цели")]
	public float XZ_COEF_STATIONARY_BULLET; //Field offset: 0x68
	[Comment("Коэфициент зависимости прицеливания в горизонтальной плоскости в зависимости от угла до цели")]
	public float XZ_COEF_STATIONARY_GRENADE; //Field offset: 0x6C
	[Comment("Сколько примерно нужно выстрелов по цели что бы поменять приоритет на стрельбу по ногам")]
	public int SHOOT_TO_CHANGE_PRIORITY; //Field offset: 0x70
	[Comment("Базовое время прицеливания. Прибавляетя к результату полученному по формуле")]
	public float BOTTOM_COEF; //Field offset: 0x74
	[Comment("Прибавляется к первому времени прицеливания в игрока ботом")]
	public float FIRST_CONTACT_ADD_SEC; //Field offset: 0x78
	[Comment("шанс срабатывания задержки указанной в FIRST_CONTACT_ADD_SEC")]
	public float FIRST_CONTACT_ADD_CHANCE_100; //Field offset: 0x7C
	[Comment("Базовое время, через которое бот отойдет от попадания по нему и перестанет афектить прицеливание")]
	public float BASE_HIT_AFFECTION_DELAY_SEC; //Field offset: 0x80
	[Comment("Минимально насколько может отойти прицел от попадания в бота в градусах")]
	public float BASE_HIT_AFFECTION_MIN_ANG; //Field offset: 0x84
	[Comment("Максимально насколько может отойти прицел от попадания в бота в градусах")]
	public float BASE_HIT_AFFECTION_MAX_ANG; //Field offset: 0x88
	[Comment("Базовый сдвиг в метрах для прицеливания (пример: BASE_SHIEF=5 => значит на расстоянии 20 метров прицеливаться будет как на 20+5=25)")]
	public float BASE_SHIEF; //Field offset: 0x8C
	[Comment("Базовый сдвиг в метрах для прицеливания (пример: BASE_SHIEF=5 => значит на расстоянии 20 метров прицеливаться будет как на 20+5=25)")]
	public float BASE_SHIEF_STATIONARY_BULLET; //Field offset: 0x90
	[Comment("Базовый сдвиг в метрах для прицеливания (пример: BASE_SHIEF=5 => значит на расстоянии 20 метров прицеливаться будет как на 20+5=25)")]
	public float BASE_SHIEF_STATIONARY_GRENADE; //Field offset: 0x94
	[Comment("Настолько бот становится косее если он был поврежден")]
	public float SCATTERING_HAVE_DAMAGE_COEF; //Field offset: 0x98
	[Comment("Модификатор зависимости прицеливанипя от дистанции не линейног (за линейность отвечает др. параметр).   //рекумендуемые знаечни 0.2..1.3.     //Меньше 1 - значит чем дальше тем будет точнее чем лнейная зависимость. Больше - косее.")]
	public float SCATTERING_DIST_MODIF; //Field offset: 0x9C
	[Comment(" Модификатор зависимости прицеливанипя от дистанции не линейног (за линейность отвечает др. параметр).   //рекумендуемые знаечни 0.2..1.3.     //Меньше 1 - значит чем дальше тем будет точнее чем лнейная зависимость. Больше - косее.")]
	public float SCATTERING_DIST_MODIF_CLOSE; //Field offset: 0xA0
	[Comment("default - в центр тушки // 1 - рандщомно + центр // 2 - рандомно кроме ног + центр // 3 - первая замеченная часть тела // 4 - рандщомно + центр + без головы // 5 - рандомно кроме ног + центр + без головы //6 - сначала голову  //7 - первые 3 сек в тело, потом в голову")]
	public int AIMING_TYPE; //Field offset: 0xA4
	[Comment("Сколько  секунд бот будет стрелять в тело при режиме прицеливания 7")]
	public float AIMING_7_PERIOD_TO_BODY; //Field offset: 0xA8
	[Comment("Если враг ближе чем Х то прицеливатся будем только в тело.")]
	public float DIST_TO_SHOOT_TO_CENTER; //Field offset: 0xAC
	[Comment("Если враг ближе чем Х то разлета не будет.")]
	public float DIST_TO_SHOOT_NO_OFFSET; //Field offset: 0xB0
	[Comment("Если больше 0 то используется сферкаст с указанным радиусом. Если меньше 0 то используется лайнкаст.")]
	public float SHPERE_FRIENDY_FIRE_SIZE; //Field offset: 0xB4
	[Comment("Настолько больше будет разлет если бот стреляет сходу")]
	public float COEF_IF_MOVE; //Field offset: 0xB8
	[Comment("Настолько дольше будет прицеливание если бот стреляет сходу")]
	public float TIME_COEF_IF_MOVE; //Field offset: 0xBC
	[Comment("Бот считается что двигается если он прошел за кадр больше чем Х")]
	public float BOT_MOVE_IF_DELTA; //Field offset: 0xC0
	[Comment("Шанс что следущем выстрелом бот промажет")]
	public float NEXT_SHOT_MISS_CHANCE_100; //Field offset: 0xC4
	[Comment("Насколько выше выстрелит бот если захочет стрелять мимо")]
	public float NEXT_SHOT_MISS_Y_OFFSET; //Field offset: 0xC8
	[Comment("Шанс что бот будет включать фонарик когда целится")]
	public float ANYTIME_LIGHT_WHEN_AIM_100; //Field offset: 0xCC
	[Comment("Через сколько секундр после первого замечания врага можно будет стрелять в любую часть тела")]
	public float ANY_PART_SHOOT_TIME; //Field offset: 0xD0
	[Comment("Дальность отступления назад для проверки возможности выстрела (Что бы нельзябыло просунуть ствол через дверь)")]
	public float WEAPON_ROOT_OFFSET; //Field offset: 0xD4
	[Comment("Минимальный урон что бы бот получил дебаффы от урона")]
	public float MIN_DAMAGE_TO_GET_HIT_AFFETS; //Field offset: 0xD8
	[Comment("Максимальное время прицеливания")]
	public float MAX_AIM_TIME; //Field offset: 0xDC
	[Comment(null)]
	public float OFFSET_RECAL_ANYWAY_TIME; //Field offset: 0xE0
	[Comment("Уровень сжатия прицельной сферы сверху")]
	public float Y_TOP_OFFSET_COEF; //Field offset: 0xE4
	[Comment("Уровень сжатия прицельной сферы снизу")]
	public float Y_BOTTOM_OFFSET_COEF; //Field offset: 0xE8
	[Comment("Если враг уйдет дальше чем Х градусов в 1 сторону то  бот покинет стационар")]
	public float STATIONARY_LEAVE_HALF_DEGREE; //Field offset: 0xEC
	[Comment("Базовое кл-во попадаий мимо МИН")]
	public int BAD_SHOOTS_MIN; //Field offset: 0xF0
	[Comment("Базовое кл-во попадаий мимо МАКС")]
	public int BAD_SHOOTS_MAX; //Field offset: 0xF4
	[Comment("сли мы стреляем мимо, то бот настолько отлоит свой прицел от цели в метрах")]
	public float BAD_SHOOTS_OFFSET; //Field offset: 0xF8
	[Comment("Базовый коэфициент из формулы == N        N*ln(x/5+1.2)")]
	public float BAD_SHOOTS_MAIN_COEF; //Field offset: 0xFC
	[Comment(null)]
	public float START_TIME_COEF; //Field offset: 0x100
	public float AIMING_ON_WAY; //Field offset: 0x104
	[Comment("Дистанция до цели, при превышении которой при первом контакте бот промахивается, если видимость затруднена")]
	public float FIRST_CONTACT_HARD_TO_SEE_MISS_SHOOTS_DISTANCE; //Field offset: 0x108
	[Comment("Количество выстрелов на которое промахивается бот при первом контакте, если видимость была затруднена")]
	public int FIRST_CONTACT_HARD_TO_SEE_MISS_SHOOTS_COUNT; //Field offset: 0x10C
	[Comment("Если выстрелов меньше чем Х и другие параметры позволяют промахнуться то промах")]
	public int MISS_FIRST_SOOTS; //Field offset: 0x110
	[Comment("Максимальное кол-во обязательных промахов")]
	public int MISS_ON_START; //Field offset: 0x114
	[Comment("Дистанция обязательного промаха")]
	public float MISS_DIST; //Field offset: 0x118
	[Comment("Прибавление к разлету если цель любым образом признана дымной")]
	public float ADDITIONAL_AIM_SMOKE_COEF; //Field offset: 0x11C
	public BotUnderbarrelLauncherAimingSettings UnderbarrelLauncherAiming; //Field offset: 0x120

	public BotGlobalAimingSettings() { }

	public void Update() { }

}

