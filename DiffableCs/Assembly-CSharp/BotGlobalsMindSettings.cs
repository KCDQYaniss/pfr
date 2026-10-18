//Type is in global namespace

public class BotGlobalsMindSettings
{
	[Comment("Сколько секунд стоять в укрытии после звука. 0 — холд длится, пока жива точка поиска. Таймер стартует только в укрытии и новыми звуками не продлевается.")]
	public float HEARD_HOLD_SEC; //Field offset: 0x10
	[Comment("После холда игнорировать звуки, созданные не позже этого окна. Потом бот снова может среагировать на новый звук.")]
	public float HEARD_IGNORE_SEC; //Field offset: 0x14
	[Comment("Должен ли бот игнорировать получение эффекта слезоточивого газа")]
	public bool IMMUNITY_TEARGAS; //Field offset: 0x18
	[Comment("Должен ли бот игнорировать эффект слезоточивого газа")]
	public bool CAN_HEAL_TEARGAS; //Field offset: 0x19
	[Comment("Должен ли бот игнорировать лояльность при параметрах враждебности")]
	public bool IGNORE_HOSILE_SCAVS; //Field offset: 0x1A
	[Comment("Должен ли бот игнорировать урон от гранат")]
	public bool GRENADE_DAMAGE_IGNORE; //Field offset: 0x1B
	[Comment("Мин число выстрелов наугад по позиции откуда велся огонь с близкого расстония")]
	public int MIN_SHOOTS_TIME; //Field offset: 0x1C
	[Comment("Маккс число выстрелов наугад по позиции откуда велся огонь с близкого расстония")]
	public int MAX_SHOOTS_TIME; //Field offset: 0x20
	[Comment("Бот сможет напугатся только через это время после пропадения из поля последнего замеченного врага")]
	public float TIME_TO_RUN_TO_COVER_CAUSE_SHOOT_SEC; //Field offset: 0x24
	[Comment("Время через которое бот восстановит своих характеристики после получения повреждений")]
	public float DAMAGE_REDUCTION_TIME_SEC; //Field offset: 0x28
	[Comment("Минимальный урон который должен пулучить бот что бы получить точку опастности")]
	public float MIN_DAMAGE_SCARE; //Field offset: 0x2C
	[Comment("Вероятность того что бот побежит если в него попасть пока он в укрытии и не может/видет стрелять во врага")]
	public float CHANCE_TO_RUN_CAUSE_DAMAGE_0_100; //Field offset: 0x30
	[Comment("Через Х сек враг перестает выдваться раздачиком задач ботам.")]
	public float TIME_TO_FORGOR_ABOUT_ENEMY_SEC; //Field offset: 0x34
	[Comment("Через Х сек бот будет искать врага придя на место его последнего видения! должен быть меньше чем TIME_TO_FORGOR_ABOUT_ENEMY_SEC")]
	public float TIME_TO_FIND_ENEMY; //Field offset: 0x38
	[Comment(null)]
	public float MAX_AGGRO_BOT_DIST; //Field offset: 0x3C
	[Comment("Коэфицент точности восприятия позиции ткуда по игроку попали больше - точнее;")]
	public float HIT_POINT_DETECTION; //Field offset: 0x40
	[Comment("Коэфициент точки опастности при поиске укрытия. Опасная точка")]
	public float DANGER_POINT_CHOOSE_COEF; //Field offset: 0x44
	[Comment("Коэфициент точки опастности при поиске укрытия. Простая точка")]
	public float SIMPLE_POINT_CHOOSE_COEF; //Field offset: 0x48
	[Comment("Какойто коэфициент при поиске точки укрытия")]
	public float LASTSEEN_POINT_CHOOSE_COEF; //Field offset: 0x4C
	[Comment("Какойто коэфициент при поиске точки укрытия")]
	public float COVER_DIST_COEF; //Field offset: 0x50
	[Comment(null)]
	public float DIST_TO_FOUND_SQRT; //Field offset: 0x54
	[Comment("Если флаг установлен, то босс может входить в состояние паники")]
	public bool BOSS_CAN_PANIC; //Field offset: 0x58
	[Comment("Ищет ли игрок противника при наличии GoalTarget")]
	public bool SEARCH_TARGET; //Field offset: 0x59
	[Comment(null)]
	public float ALWAYS_SEARCH_REFRESH_RND_PERIOD; //Field offset: 0x5C
	[Comment(null)]
	public bool ALWAYS_SEARCH_ADVANCED_POINT_CHECKS; //Field offset: 0x60
	[Comment("если флаг установлен хотя бы у одного бота в ботгруппе, то враждебной становится вся группа, в которой есть один враждебный игрок-ЧВК")]
	public bool ENEMY_BY_GROUPS_PMC_PLAYERS; //Field offset: 0x61
	[Comment("если флаг установлен хотя бы у одного бота в ботгруппе, то враждебной становится вся группа, в которой есть один враждебный дикий игрок")]
	public bool ENEMY_BY_GROUPS_SAVAGE_PLAYERS; //Field offset: 0x62
	[Comment("Если true то боссы не меняют своё поведение для игрока с высокой репутаций скупщика")]
	public bool BOSS_IGNORE_LOYALTY; //Field offset: 0x63
	[Comment("являются ли бировцы (живые игроки) врагами по умолчанию для этого бота")]
	public EWarnBehaviour DEFAULT_BEAR_BEHAVIOUR; //Field offset: 0x64
	[Comment("являются ли юсеки (живые игроки) врагами по умолчанию для этого бота")]
	public EWarnBehaviour DEFAULT_USEC_BEHAVIOUR; //Field offset: 0x68
	[Comment("являются ли дикие (живые игроки) врагами по умолчанию для этого бота")]
	public EWarnBehaviour DEFAULT_SAVAGE_BEHAVIOUR; //Field offset: 0x6C
	[Comment("список дружественных типов ботов")]
	public WildSpawnType[] FRIENDLY_BOT_TYPES; //Field offset: 0x70
	[Comment("список нейтральных типов ботов. Если бот не может предупреждать, то все боты из этого списка становятся дружественными или враждебными в зависимости от значения DEFAULT_ENEMY_SAVAGE")]
	public WildSpawnType[] WARN_BOT_TYPES; //Field offset: 0x78
	[Comment("список враждебных типов ботов")]
	public WildSpawnType[] ENEMY_BOT_TYPES; //Field offset: 0x80
	[Comment("список ботов которых будут преслеждовать боты как топористов особенные дистанции. Они должны совпадать со список PERSUIT_BOT_TYPES если дистанция <0 то она учитываться не будет")]
	public int[] PERSUIT_BOT_TYPES_DIST; //Field offset: 0x88
	[Comment("список ботов которых будут преслеждовать боты как топористов")]
	public WildSpawnType[] PERSUIT_BOT_TYPES; //Field offset: 0x90
	[Comment("список ботов, при атаке на которых бот будет считать игрока враждебным")]
	public WildSpawnType[] REVENGE_BOT_TYPES; //Field offset: 0x98
	[Comment("Босс может предупреждать игрока на равных со свитой")]
	public bool FOLLOWER_AND_BOSS_WARN_EQUAL_PRIORITY; //Field offset: 0xA0
	[Comment("Игнорирование дружественного огня для ботов-зомби")]
	public bool MUTUAL_IGNORE_FRIENDLY_FIRE; //Field offset: 0xA1
	public float MAX_AGGRO_BOT_DIST_UPPER_LIMIT; //Field offset: 0xA4
	[Comment(null)]
	public float MAX_AGGRO_BOT_DIST_SQR_UPPER_LIMIT; //Field offset: 0xA8
	[Comment(null)]
	public float MAX_AGGRO_BOT_DIST_SQR; //Field offset: 0xAC
	[Comment("при беге когда до точки укрытия остается меньше Х то базовые опасные точки обнуляются")]
	public float DIST_TO_STOP_RUN_ENEMY; //Field offset: 0xB0
	[Comment("Угл по которому бот понимает что противник смотриит на него")]
	public float ENEMY_LOOK_AT_ME_ANG; //Field offset: 0xB4
	[Comment("min  Уровень агрессивности. [0....inf] На этот коеф умножается собственная сила => вероятность тактических моделей.")]
	public float MIN_START_AGGRESION_COEF; //Field offset: 0xB8
	[Comment("max")]
	public float MAX_START_AGGRESION_COEF; //Field offset: 0xBC
	[Comment("Расстояние с которого бот может \"ощутить\" пулю")]
	public float BULLET_FEEL_DIST; //Field offset: 0xC0
	[Comment("Квадрат расстояния если ближе которого пуля ударится рядом с ботов то он ее воспримет (и если бы в укрытии то посчитает укрытии плохим)")]
	public float BULLET_FEEL_CLOSE_SDIST; //Field offset: 0xC4
	[Comment("Шанс на то что после потери из виду врага и не имея нового бот пойдет искать врага сразу. Применимо только при атакующей тактики. (дальше идет проверка на свою силу и силу врага.)")]
	public float ATTACK_IMMEDIATLY_CHANCE_0_100; //Field offset: 0xC8
	[Comment("Шанс показать фак в момент когда бот увидит игрока")]
	public float CHANCE_FUCK_YOU_ON_CONTACT_100; //Field offset: 0xCC
	[Comment("Насколько падает агресия бота если убьют когонить в его группе.")]
	public float FRIEND_DEAD_AGR_LOW; //Field offset: 0xD0
	[Comment("Насколько растет агресия если кто то умер недалеко от них")]
	public float FRIEND_AGR_KILL; //Field offset: 0xD4
	[Comment(null)]
	public float LAST_ENEMY_LOOK_TO; //Field offset: 0xD8
	[Comment(null)]
	public bool CAN_RECEIVE_PLAYER_REQUESTS_BEAR; //Field offset: 0xDC
	[Comment(null)]
	public bool CAN_RECEIVE_PLAYER_REQUESTS_USEC; //Field offset: 0xDD
	[Comment(null)]
	public bool CAN_RECEIVE_PLAYER_REQUESTS_SAVAGE; //Field offset: 0xDE
	[Comment("Добавлять ли во враги при нанесении урона")]
	public bool ADD_TO_ENEMY_BY_HIT; //Field offset: 0xDF
	[Comment("Если бота атакует группа и параметр равен FALSE, то бот в ответ атакует тлько агрессора. Если TRUE - то всю группу агрессора")]
	public bool REVENGE_TO_GROUP; //Field offset: 0xE0
	[Comment("Если флаг установлен, то бот атакует агрессора против игрока-дикого")]
	public bool REVENGE_FOR_SAVAGE_PLAYERS; //Field offset: 0xE1
	[Comment(null)]
	public bool CAN_USE_MEDS; //Field offset: 0xE2
	[Comment(null)]
	public float SUSPETION_POINT_CHANCE_ADD100; //Field offset: 0xE4
	[Comment(null)]
	public bool AMBUSH_WHEN_UNDER_FIRE; //Field offset: 0xE8
	[Comment("Псоле того как чела напугали выстрелами и загнали в амбуш - он будет иметь к такому резист на Х сек")]
	public float AMBUSH_WHEN_UNDER_FIRE_TIME_RESIST; //Field offset: 0xEC
	[Comment("Может ли бот лутать кластер в ботзоне с боссом")]
	public bool CAN_LOOT_BOSS_CLUSTER; //Field offset: 0xF0
	[Comment("Если чел выл виден кем то менее Х сек назад - то мы его идем атаковать")]
	public float ATTACK_ENEMY_IF_PROTECT_DELTA_LAST_TIME_SEEN; //Field offset: 0xF4
	[Comment("Если чел выл виден кем то менее Х сек назад - и мы вне укрытия и укрытия нет то мы похлдим и подожем его.")]
	public float HOLD_IF_PROTECT_DELTA_LAST_TIME_SEEN; //Field offset: 0xF8
	[Comment("Когда бот ищет укрытие (в некоторых случаях) если поселедний видимый враг был виден меньше чем Х времени назад то будет пытаться найти позицию со стрельбой")]
	public float FIND_COVER_TO_GET_POSITION_WITH_SHOOT; //Field offset: 0xFC
	[Comment("какой тип времени браться для того что бы решить атаковать или нет. Реальный видимы или \"по ощущениям\"")]
	public bool PROTECT_TIME_REAL; //Field offset: 0x100
	[Comment("Шанс что бот когда предупреждает игрока он посреляет рядом а не говорит")]
	public float CHANCE_SHOOT_WHEN_WARN_PLAYER_100; //Field offset: 0x104
	[Comment(null)]
	public bool CAN_PANIC_IS_PROTECT; //Field offset: 0x108
	[Comment("Не убегать для защиты себя")]
	public bool NO_RUN_AWAY_FOR_SAFE; //Field offset: 0x109
	[Comment("Если в части тела меньше чем Х то она будет подвержена лечению")]
	public float PART_PERCENT_TO_HEAL; //Field offset: 0x10C
	[Comment("Когда бот защищает когото и последний врга был виден больше чем Х сек назад то можно попытаться похиляться.")]
	public float PROTECT_DELTA_HEAL_SEC; //Field offset: 0x110
	[Comment(null)]
	public bool CAN_STAND_BY; //Field offset: 0x114
	[Comment("Может ли бот кдать реквесты другим ботам.")]
	public bool CAN_THROW_REQUESTS; //Field offset: 0x115
	[Comment("После того как бот скажет фразу следущий бот из этойже группы сможет сказать фразу только через Х. Если Х<0 то задержки нет.")]
	public float GROUP_ANY_PHRASE_DELAY; //Field offset: 0x118
	[Comment("Тоже самое что и GROUP_ANY_PHRASE_DELAY только относится к конкретному типу фразы")]
	public float GROUP_EXACTLY_PHRASE_DELAY; //Field offset: 0x11C
	[Comment("Тоже самое что и GROUP_ANY_PHRASE_DELAY только относится к конкретному типу фразы")]
	public float GROUP_EXACTLY_PHRASE_DELAY_MAX; //Field offset: 0x120
	[Comment("При наличие врага что бы бот начал хилится враг должен быть дальше чем Х метров")]
	public float DIST_TO_ENEMY_YO_CAN_HEAL; //Field offset: 0x124
	[Comment("Шанс что после первых 2 действий при предупреждении бот будет стоять и ждать след 4 сек.")]
	public float CHANCE_TO_STAY_WHEN_WARN_PLAYER_100; //Field offset: 0x128
	[Comment("Выйдет из догфайта")]
	public float DOG_FIGHT_OUT; //Field offset: 0x12C
	[Comment("Войдет в догфайт")]
	public float DOG_FIGHT_IN; //Field offset: 0x130
	[Comment("Если бот вошел в догфайт более 2 раз за Х сек он вместо этого будет стрелять с места.")]
	public float SHOOT_INSTEAD_DOG_FIGHT; //Field offset: 0x134
	[Comment("Дистанция для перехода в амбушь для пистолетов и шотганов")]
	public float PISTOL_SHOTGUN_AMBUSH_DIST; //Field offset: 0x138
	[Comment("Дистанция для перехода в амбушь для остального")]
	public float STANDART_AMBUSH_DIST; //Field offset: 0x13C
	[Comment("Коэфициент для пересчета силы игрока в амбуш дистанс")]
	public float AI_POWER_COEF; //Field offset: 0x140
	[Comment(null)]
	public float COVER_SECONDS_AFTER_LOSE_VISION; //Field offset: 0x144
	[Comment("При поиске укрытий бот будет всегда ныкаться если он имеет повреждения")]
	public bool COVER_SELF_ALWAYS_IF_DAMAGED; //Field offset: 0x148
	[Comment("Если врга был виден менее Х сек назад то дист до укрытия для бега будет больше на 1.5")]
	public float SEC_TO_MORE_DIST_TO_RUN; //Field offset: 0x14C
	[Comment("Перерыв между лечением.")]
	public float HEAL_DELAY_SEC; //Field offset: 0x150
	[Comment("Задержка для ощущения попадания если бот настороже")]
	public float HIT_DELAY_WHEN_HAVE_SMT; //Field offset: 0x154
	[Comment("Задержка для ощущения попадания если бот в мирном")]
	public float HIT_DELAY_WHEN_PEACE; //Field offset: 0x158
	[Comment("Бот говорит только через очередь фраз и по приоритетам")]
	public bool TALK_WITH_QUERY; //Field offset: 0x15C
	[Comment("Сколько времени бот будет паниковать min")]
	public float DANGER_EXPIRE_TIME_MIN; //Field offset: 0x160
	[Comment("Сколько времени бот будет паниковать max")]
	public float DANGER_EXPIRE_TIME_MAX; //Field offset: 0x164
	[Comment("Вес шанса бега при сильной паники")]
	public float PANIC_RUN_WEIGHT; //Field offset: 0x168
	[Comment("Вес шанса сесть при сильной паники")]
	public float PANIC_SIT_WEIGHT; //Field offset: 0x16C
	[Comment("Вес шанса лечь при сильной паники")]
	public float PANIC_LAY_WEIGHT; //Field offset: 0x170
	[Comment("При панеке в патруле nyByOne боты будут спринтовать")]
	public bool ONE_BY_ONE_PANIC_SPRINT; //Field offset: 0x174
	[Comment("Вес шанса ничего не делать при легкой панике")]
	public float PANIC_NONE_WEIGHT; //Field offset: 0x178
	[Comment("Шанс сесть если паника была легкой (выстрел не в бота или рядом)")]
	public float PANIC_SIT_WEIGHT_PEACE; //Field offset: 0x17C
	[Comment("Может ли бот исполнять реквесты")]
	public bool CAN_EXECUTE_REQUESTS; //Field offset: 0x180
	[Comment("Может ли бот предупреждать игроков")]
	public bool CAN_WARN_SELF; //Field offset: 0x181
	[Comment("Если урон был нанесет с дистанции меньше чем Х то бот этого врага \"заметит\", даже если он к нему спиной.")]
	public float DIST_TO_ENEMY_SPOTTED_ON_HIT; //Field offset: 0x184
	[Comment("Сколько бот находитьcя в режиме \"под огнем\"")]
	public float UNDER_FIRE_PERIOD; //Field offset: 0x188
	[Comment("Использовать медецину только из СейфКонтейнера")]
	public bool MEDS_ONLY_SAFE_CONTAINER; //Field offset: 0x18C
	[Comment("Может ли бот выкидывать вещи")]
	public bool CAN_DROP_ITEMS; //Field offset: 0x18D
	[Comment("Может ли бот поднимать вещи выброшеные другими игроками")]
	public bool CAN_TAKE_ITEMS; //Field offset: 0x18E
	[Comment("Дистанция с которой бот увидит и запомнит брошенный предмет")]
	public float THROW_DIST_TO_SEE; //Field offset: 0x190
	[Comment(null)]
	public bool CAN_TAKE_ANY_ITEM; //Field offset: 0x194
	[Comment("Будет ли бот преследовать топористов")]
	public bool WILL_PERSUE_AXEMAN; //Field offset: 0x195
	[Comment("Максимальная дистанция на которой бот бдует преследовать топориста бегом.")]
	public float MAX_DIST_TO_RUN_PERSUE_AXEMAN; //Field offset: 0x198
	[Comment("Максимальная дистанция на которой бот бдует преследовать топориста в режиме All Persuit")]
	public float MAX_DIST_TO_PERSUE_AXEMAN_FORCE; //Field offset: 0x19C
	[Comment("Максимальная дистанция на которой бот бдует преследовать топориста")]
	public float MAX_DIST_TO_PERSUE_AXEMAN; //Field offset: 0x1A0
	[Comment("Использование хирург набора только из сейф контейнера")]
	public bool SURGE_KIT_ONLY_SAFE_CONTAINER; //Field offset: 0x1A4
	[Comment(null)]
	public bool CAN_USE_LONG_COVER_POINTS; //Field offset: 0x1A5
	[Comment("Можно ли есть-пить")]
	public bool CAN_USE_FOOD_DRINK; //Field offset: 0x1A6
	[Comment("Минимальная переодичность для есть-пить")]
	public float FOOD_DRINK_DELAY_SEC; //Field offset: 0x1A8
	[Comment("Что именно делать когда приходишь к трупу  1 - использовать набор медециню 2 - облутать.  Дефолт - смотреть. public bool CAN_TALK = true;")]
	public int HOW_WORK_OVER_DEAD_BODY; //Field offset: 0x1AC
	[Comment("Стартовая пауза при подходе к трупу (в это время говорится фраза)")]
	public float DEADBODYWORK_INITIAL_DELAY; //Field offset: 0x1B0
	[Comment("Пауза при осмотре предметов на трупе (имитация обыска контейнеров)")]
	public float DEADBODYWORK_CHECK_ITEMS_DELAY; //Field offset: 0x1B4
	[Comment("Пауза после каждого взятия предмета")]
	public float DEADBODYWORK_MOVE_ITEMS_DELAY; //Field offset: 0x1B8
	[Comment("Пауза после каждого выбрасывания предмета")]
	public float DEADBODYWORK_DROP_ITEMS_DELAY; //Field offset: 0x1BC
	[Comment("може ли говорить    ")]
	public bool CAN_TALK; //Field offset: 0x1C0
	public bool ACTIVE_FORCE_ATTACK_EVENTS; //Field offset: 0x1C1
	public bool ACTIVE_FOLLOW_PLAYER_EVENTS; //Field offset: 0x1C2
	[Comment("Бот может быть призван на помощь боссом (Например, Тагиллой или Кабаном")]
	public bool MAY_BE_CALLED_FOR_HELP; //Field offset: 0x1C3
	[Comment("Количество дополнительных подарков, которые может бот в слое GifterLayer")]
	public int GIFTER_ADDITIONAL_GIFTS; //Field offset: 0x1C4
	[Comment("Если направление прицеливания отличается от направления на цель больше чем этот угол, то БТР не будет стрелять")]
	public float ANGLE_TO_SHOOT_BTR; //Field offset: 0x1C8
	[Comment("Скорость поворота башни БТРа")]
	public float ROTATION_SPEED_BTR; //Field offset: 0x1CC
	[Comment("Игнорирует попадания по себе от других ботов")]
	public bool IGNORE_ANOTHER_BOTS_BEING_HIT; //Field offset: 0x1D0
	[Comment("Расстояние, на котором боты держатся об БТРа")]
	public float AVOID_BTR_RADIUS_SQR; //Field offset: 0x1D4
	[Comment("Невидимые снайперы не атакуют бота с этим флагом")]
	public bool SNIPER_FIRE_IMMUNE; //Field offset: 0x1D8
	[Comment("Проверяет наличие метки неизвестных. И не добавляет во враги если она есть")]
	public bool CHECK_MARK_OF_UNKNOWS; //Field offset: 0x1D9
	[Comment("В каком радиусе бот сообщит информацию о враге когда заметит его")]
	public float SDIST_TO_DELIVER_INFO_WHEN_ENEMY; //Field offset: 0x1DC
	[Comment("Если флаг установлен, то оповещение о враге не принимается")]
	public bool IGNORE_DELIVER_ENEMY_INFO; //Field offset: 0x1E0
	[Comment("Время на которое бот поставит растяжку")]
	public int TRIPWIRE_INERT_TIME; //Field offset: 0x1E4
	[Comment("Если бот пройдет через ловушку (Это НЕ МИНЫ, это фичи из лабиринта) она не сработает")]
	public bool IGNORE_TRAP; //Field offset: 0x1E8
	[Comment("Шанс что если бот пройдет через растяжку она не сработает")]
	public float CHANCE_TO_IGNORE_TRIPWIRE; //Field offset: 0x1EC
	[Comment("Шанс того что, что боты не обнаружат растяжку, 100 = никогда не обнаружат")]
	public float CHANCE_NOT_FIND_TRIPWIRE; //Field offset: 0x1F0
	[Comment("Шанс на деактивацию растяжки")]
	public float CHACE_TO_DEACTIVATE; //Field offset: 0x1F4
	[Comment("Если плеер становиться Drunk то этот бот будет его слушаться")]
	public bool REACT_ADD_DRUNK_ENEMY; //Field offset: 0x1F8
	[Comment("Если враг дальше чем Х то асаутеры и марксмены будут прятаться")]
	public float DIST_TO_HIDE_ASSAULT; //Field offset: 0x1FC
	[Comment("Как долго боты из волнового спавна будут патрулироват зону при включенном параметре KeepZoneOnSpawn")]
	public float KEEP_ZONE_ON_SPAWN_TIME_SEC; //Field offset: 0x200
	[Comment("Бот игнорирует всякие разные точки опастности (ловушки к примеру)")]
	public bool IGNORE_DANGER_PLACES; //Field offset: 0x204
	[Comment("Для слоя PushAndSuppressLayer дистанция с которой бот НЕ будет пушить")]
	public float PUSH_AND_SUPPRESS_HIDE; //Field offset: 0x208
	[Comment("Для слоя PushAndSuppressLayer дистанция с которой бот будет СИЛЬНО пушить")]
	public float PUSH_AND_SUPPRESS_PUSH; //Field offset: 0x20C
	[Comment("Если стоит в тру боты при видимости врага, будут в него стрелять даже под арт обстрелом")]
	public bool PRIORITY_FIGHT_UNDER_ARTILLERY; //Field offset: 0x210
	[Comment("Через сколько времени бот потеряет интерес к топористу когда тот выйдет за пределы радиуса")]
	public float LOST_PERIOD_AXE_TARGET; //Field offset: 0x214
	[Comment("в ноде GoToEnemy мы разрешаем смотреть только по ходу движения если врага не видно")]
	public bool GO_TO_ENEMY_LOOK_ONLY_STRAIGHT; //Field offset: 0x218
	[Comment("в ноде GoToEnemy мы будем тильтить в строну врага")]
	public bool GO_TO_ENEMY_USE_TILT; //Field offset: 0x219

	public BotGlobalsMindSettings() { }

	public void Update() { }

}

