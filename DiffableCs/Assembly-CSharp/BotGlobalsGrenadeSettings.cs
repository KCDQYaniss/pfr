//Type is in global namespace

public class BotGlobalsGrenadeSettings
{
	[Comment("Частота попыток проверить можно ли бросить гранату из за укрытия")]
	public float DELTA_NEXT_ATTEMPT_FROM_COVER; //Field offset: 0x10
	[Comment(null)]
	public float DELTA_NEXT_ATTEMPT; //Field offset: 0x14
	[Comment("дистанция проверки нет ли рядом с точкой броска друзей или автора броска")]
	public float MIN_DIST_NOT_TO_THROW; //Field offset: 0x18
	[Comment("Время когда считается что недавно бот бросал гранату (Нужно что бы знать что пора возвращатся в укрытие)")]
	public float NEAR_DELTA_THROW_TIME_SEC; //Field offset: 0x1C
	[Comment("Мин дистанция броска гранаты")]
	public float MIN_THROW_GRENADE_DIST; //Field offset: 0x20
	[Comment("    public float MAX_THROW_GRENADE_DIST_SQRT;")]
	public float MIN_THROW_GRENADE_DIST_SQRT; //Field offset: 0x24
	[Comment(null)]
	public float MIN_DIST_NOT_TO_THROW_SQR; //Field offset: 0x28
	[Comment("Дистанция если бот биже нее к предполагаемому месту  попадания гранаты то он запишет точку в опастность")]
	public float RUN_AWAY; //Field offset: 0x2C
	[Comment(null)]
	public float RUN_AWAY_SQR; //Field offset: 0x30
	[Comment("Дистанция если бот биже нее к предполагаемому месту  попадания гранаты то он запишет точку в опастность")]
	public float ADD_GRENADE_AS_DANGER; //Field offset: 0x34
	[Comment(null)]
	public float ADD_GRENADE_AS_DANGER_SQR; //Field offset: 0x38
	[Comment("Шанс увидеть летящую в бота гранату")]
	public float CHANCE_TO_NOTIFY_ENEMY_GR_100; //Field offset: 0x3C
	[Comment("Уровень разлета броска гранаты (Меньше == точнее)")]
	public float GrenadePerMeter; //Field offset: 0x40
	[Comment(null)]
	public float REQUEST_DIST_MUST_THROW_SQRT; //Field offset: 0x44
	[Comment("Если дистанция меньше чем Х метров до точки броска и враг виден то реквест не прервется.")]
	public float REQUEST_DIST_MUST_THROW; //Field offset: 0x48
	[Comment("2 - Убегает от точного места гранаты   .  3 - убегает от предположительного места гранаты. остальное - убегает от средней точки.")]
	public int BEWARE_TYPE; //Field offset: 0x4C
	[Comment("Вероятность желания пострелять в дым.")]
	public float SHOOT_TO_SMOKE_CHANCE_100; //Field offset: 0x50
	[Comment("Шанс что будет будет убегать будучи зафлешенным, а не стрелять по точке если может.")]
	public float CHANCE_RUN_FLASHED_100; //Field offset: 0x54
	[Comment("Если точка последней опастности ближе чем Х и бот в блайнде то он может по ней посрелять")]
	public float MAX_FLASHED_DIST_TO_SHOOT; //Field offset: 0x58
	[Comment(null)]
	public float MAX_FLASHED_DIST_TO_SHOOT_SQRT; //Field offset: 0x5C
	[Comment("Коэфицие на которое умножается время которое бот получит после расчетов слеповой грены")]
	public float FLASH_GRENADE_TIME_COEF; //Field offset: 0x60
	[Comment("дымовой гранаты. Насколько бльше считается радиус для точек которые бот не будет занимать пока идет дым чем коллайдер дыма")]
	public float SIZE_SPOTTED_COEF; //Field offset: 0x64
	[Comment("Коэфициент бота для привлечение внимания гранатой дымовой")]
	public float BE_ATTENTION_COEF; //Field offset: 0x68
	[Comment("Сколько секунд бот будет стрелять будучи зафлешеным")]
	public float TIME_SHOOT_TO_FLASH; //Field offset: 0x6C
	[Comment("Как близко к источнику дыма должна быть подозрительность что бы туда начать стрелять.")]
	public float CLOSE_TO_SMOKE_TO_SHOOT; //Field offset: 0x70
	[Comment(null)]
	public float CLOSE_TO_SMOKE_TO_SHOOT_SQRT; //Field offset: 0x74
	[Comment("Как давно в смоках должен был быть шум что бы туда пострелять")]
	public float CLOSE_TO_SMOKE_TIME_DELTA; //Field offset: 0x78
	[Comment("Частота проверки смоков.")]
	public float SMOKE_CHECK_DELTA; //Field offset: 0x7C
	[Comment("Через стлько сек после броска точка опастности станет активной (бот будет на нее реагировать => убегать если надо) (раньше было в глобалсах)")]
	public float DELTA_GRENADE_START_TIME; //Field offset: 0x80
	[Comment("Бот перейдет в состояние Ambush если в его зоне кинули смока")]
	public float AMBUSH_IF_SMOKE_IN_ZONE_100; //Field offset: 0x84
	[Comment("Через сколько секунд бот переейдет в свое прежнее состояние после смоков.")]
	public float AMBUSH_IF_SMOKE_RETURN_TO_ATTACK_SEC; //Field offset: 0x88
	[Comment("Бот НЕ будет убегать от гранат кинутых другими ботами")]
	public bool NO_RUN_FROM_AI_GRENADES; //Field offset: 0x8C
	[Comment(null)]
	public float MAX_THROW_POWER; //Field offset: 0x90
	[Comment("точность броска гранаты . меньше-точнее")]
	public float GrenadePrecision; //Field offset: 0x94
	[Comment("точность броска гранаты в порталы . меньше-точнее")]
	public float GRENADE_PRECISION_PORTALS; //Field offset: 0x98
	[Comment("Остановится ли бот для броска гранаты. Если остановится бросит точнее, если нет - может кинуть не совсем туда куда хочет.")]
	public bool STOP_WHEN_THROW_GRENADE; //Field offset: 0x9C
	[Comment("Сколько секунд ождать посл броска своей световой гранаты что бы отвернуться")]
	public float WAIT_TIME_TURN_AWAY; //Field offset: 0xA0
	[Comment("На сколько оказывает подавление дымовая граната")]
	public float SMOKE_SUPPRESS_DELTA; //Field offset: 0xA4
	[Comment("На сколько оказывает подавление дамажащая граната")]
	public float DAMAGE_GRENADE_SUPPRESS_DELTA; //Field offset: 0xA8
	[Comment("На сколько оказывает подавление светошумовая граната")]
	public float STUN_SUPPRESS_DELTA; //Field offset: 0xAC
	[Comment("Если включено то граната будет вылетать не из руки а оттуда откуда бот предпосчитал что её надо броситть")]
	public bool CHEAT_START_GRENADE_PLACE; //Field offset: 0xB0
	[Comment("Может ли бот кидать гранаты при прямом контакте с врагом")]
	public bool CAN_THROW_STRAIGHT_CONTACT; //Field offset: 0xB1
	[Comment("Делей для прямого броска гранаты после первого контакта")]
	public float STRAIGHT_CONTACT_DELTA_SEC; //Field offset: 0xB4
	[Comment("Базовый угл для расчета броска гранаты   ,1 - 45 градусов ,  2 - 25 градусов ,   3 - 65 градусов  , 4 - 15 градусов, 5 - 35, 6 - 55")]
	public int ANG_TYPE; //Field offset: 0xB8
	[Comment("Если цель находится на проценте пути дальше чем Х то бросок будет")]
	public float MIN_THROW_DIST_PERCENT_0_1; //Field offset: 0xBC
	[Comment("Насколько умножится длительность ослепления если бот был в найтвижене")]
	public float FLASH_MODIF_IS_NIGHTVISION; //Field offset: 0xC0
	[Comment("Через сколько сек после первого контакта можно кидать гранату?")]
	public float FIRST_TIME_SEEN_DELTA_CAN_THROW; //Field offset: 0xC4
	[Comment("Должен ли бот вставать когда кидает грену")]
	public bool SHALL_GETUP; //Field offset: 0xC8
	[Comment("Может ли бот кидать грену лежа")]
	public bool CAN_LAY; //Field offset: 0xC9
	[Comment("бот не будет убегать от дымовой гранаты")]
	public bool IGNORE_SMOKE_GRENADE; //Field offset: 0xCA
	[Comment("Может ли кидать бот гранату из ShootFromPlace")]
	public bool CAN_THROW_FROM_ANY_PLACE; //Field offset: 0xCB
	[Comment("Может ли кидать бот в звуковой портал (окно дверь дыра в стене и т.п.)")]
	public bool THROW_GRENADE_TO_PORTALS; //Field offset: 0xCC
	[Comment("Может ли ли бот использовать обычные броски гранат на подавление")]
	public bool THROW_GRENADE_SUPPRESS; //Field offset: 0xCD
	[Comment("Использует ли бот быстрый бросок грены")]
	public bool DO_QUICK_THROW; //Field offset: 0xCE
	[Comment("Убегают ли боты от газовой гранаты")]
	public bool NO_RUN_FROM_GAS_GRENADES; //Field offset: 0xCF

	public BotGlobalsGrenadeSettings() { }

	public void Update() { }

}

