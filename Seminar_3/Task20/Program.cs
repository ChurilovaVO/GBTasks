using static System.Console;

WriteLine("Введите количество изготовленных деталей: ");
int number = Convert.ToInt32(ReadLine());

// x = 2(y +y)

WriteLine(number % 6 == 0 && number > 0? $"Токарь сделал {number / 3 * 2}, Полутокари сделали по {number / 6}" : "Токарь ошибся");
