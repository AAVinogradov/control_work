# Описание логики алгоритма (Вариант 1)

1. Добавлен метод ввода-вывода массива с ручным вводом длинны и элементов массива;
2. Добавлен метод перевода элемента массива в строку с последующим удалением из строки гласных букв и нечетных числел, и заменой четных на символ " * ". 
* С помощью цикла перебираются элементы массива;
* Каждый взятый элемент переводится в строку;
* Каждый элемент сверяется на наличие предзаписанного списка переменных (букв и цифр) и перезаписывает строку;
* Перезаписанная строка записывается в элемент массива 2;
* Вывод нового массива.

# Блок-схема

![Схема](https://github.com/AAVinogradov/control_work/blob/master/img/img.jpg?raw=true)

# Описание логики алгоритма (Вариант 2)
1. Добавлен метод ввода-вывода массива с ручным вводом длинны и элементов массива;
2. Добавлен метод проверки длинны элемента в массиве; 
* С помощью цикла перебираются элементы массива;
* С помощью встроенного условия if проверяется соответствие длинны элемента;
* Каждый взятый элемент проверяется на условие по длине <= 3;
* Если элемент соответствует условию, то происходит присваивание данного элемента новому массиву matrix2;
* Добавлен счетчик для условия If - х, который также применяется в роли индекса элементов для matrix2;
* Вывод нового массива.

# Блок-схема

![Схема](https://github.com/AAVinogradov/control_work/blob/master/img/img2.jpg?raw=true)