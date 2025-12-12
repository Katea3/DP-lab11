// Устанавливаем начальный цвет светофора — красный
ColorLightTraffic currentLight = ColorLightTraffic.Red;

// Выполняем действие для первого состояния
action_to_light(currentLight);

// Переходим к следующему цвету (разово)
currentLight = NextLight(currentLight);


// Функция переключения светофора по кругу (Red → Yellow → Green → Red)
static ColorLightTraffic NextLight(ColorLightTraffic current)
{
    // Получаем числовое значение enum
    int numericLight = (int)current;

    // Переход к следующему цвету светофора по модулю 3
    return (ColorLightTraffic)((numericLight + 1) % 3);
}


// Функция запуска бесконечного переключения светофора
void change_ligth()
{
    while (true)
    {
        // Переключаем цвет
        currentLight = NextLight(currentLight);

        // Задержка 2 секунды для реалистичности
        Thread.Sleep(2000);

        // Выполняем действие в зависимости от цвета светофора
        action_to_light(currentLight);
    }
}

// Запускаем цикл переключения цветов
change_ligth();


// Функция, выполняющая действие в зависимости от текущего цвета светофора
void action_to_light(ColorLightTraffic light)
{
    switch (light)
    {
        case ColorLightTraffic.Green:
            Console.WriteLine($"Сейчас {ColorLightTraffic.Green} — можно идти!");
            break;

        case ColorLightTraffic.Yellow:
            Console.WriteLine($"Сейчас {ColorLightTraffic.Yellow} — приготовься!");
            break;

        case ColorLightTraffic.Red:
            Console.WriteLine($"Сейчас {ColorLightTraffic.Red} — нельзя идти!");
            break;

        default:
            Console.WriteLine("Неизвестное действие");
            break;
    }
}


// Перечисление цветов светофора
enum ColorLightTraffic
{
    Red = 0,     // Красный свет
    Yellow = 1,  // Жёлтый свет
    Green = 2    // Зелёный свет
}
