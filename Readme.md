# *Задача*

Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа.

# *Решение*

Описание работы алгоритма:

Программа формирует новый массив из строк длина которых меньше или равна 3 символам. Объявляются 2 массива введеный пользователем и второй, такой же длины. Далее работает метод проверки по заданному условию, в котором цикл соразмерный длине массива проверяет каждый элемент массива. Если элемент отвечает требованиям, то этот элемент записывается в переменную count второго массива.
Переменная count необходима для постепенного переноса элементов из первого массива во второй, без пробелов. После присвоения элемента массива, переменная count
увеличивается на 1 и возвращается к циклу, в котором переходит к следующему элементу массива и так проходит проверка до конца массива. В итоге получается массив.


1. **Prompt**

Метод принимает строку введеную пользователем и выводит её в консоль в виде сообщения. 

2. **ShowArray**

Метод принимает строковый массив, и поочередно через цикл выводит каждый элемент массива в консоль. 

3. **CreateArray**

Метод возвращает строковой массив данных, который ввёл пользователь. 

4. **CheckThreeSymbol**

Метод принимает массив и поочередно через цикл проверяет все элементы на соответствие условию. Результатом работы метода является возврат строкового маасива данных, который подходит под условие.