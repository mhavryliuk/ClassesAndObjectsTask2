﻿using System;

/*
Классы и Объекты.
Задание 2. Создать класс Triangle, содержащий следующие члены класса:
1. Поля:
· int a, b, c;
2. Конструктор, позволяющий создать экземпляр класса с заданными длинами сторон.
3. Методы, позволяющие:
· вывести длины сторон треугольника на экран;
· рассчитать периметр треугольника;
· рассчитать площадь треугольника.
4. Свойство:
· позволяющее получить-установить длины сторон треугольника (доступное для чтения и записи);
· позволяющее установить, существует ли треугольник с данными длинами сторон (доступное только для чтения).
5. Индексатор, позволяющий по индексу 0 обращаться к полю a, по индексу 1 – к полю b, по индексу 2 – к полю c, 
при других значениях индекса выдается сообщение об ошибке.
6. Перегрузку:
· операции ++ (--): одновременно увеличивает(уменьшает) значение полей a, b и c на 1;
· констант true и false: обращение к экземпляру класса дает значение true, если треугольник с заданными длинами сторон существует, иначе false;
· операции*: одновременно домножает поля a, b и c на скаляр.

Продемонстрировать работу класса.
*/

namespace ClassesAndObjectsTask2
{
    class Triangle
    {
        // Поля
        double a, b, c;
        double perimeter;

        // Конструктор, позволяющий создать экземпляр класса с заданными длинами сторон.
        public Triangle()
        {
            a = 0;
            b = 0;
            c = 0;
        }

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        // Метод для вывода длины сторон треугольника на экран
        public override string ToString() => $"Длина сторон треугольника: A = {a} см, B = {b} см и C = {c} см";

        // Метод для расчёта периметра треугольника
        public string CalcPerimeter()
        {
            perimeter = a + b + c;
            return $"Периметр треугольника: P = {perimeter} см";
        }

        // Метод для расчёта площадь треугольника
        public string CalcArea()
        {
            double semiperimeter = perimeter / 2;
            double area = Math.Sqrt(semiperimeter * (semiperimeter - a) * (semiperimeter - b) * (semiperimeter - c));
            return $"Площадь треугольника S = {area:f2} см";
        }

        // Свойство, позволяющее получить-установить длины сторон треугольника (доступное для чтения и записи)
        public double A
        {
            get => a;
            set => a = value;
        }

        public double B
        {
            get => b;
            set => b = value;
        }

        public double C
        {
            get => c;
            set => c = value;
        }

        // Свойство, позволяющее установить, существует ли треугольник с данными длинами сторон (доступное только для чтения)

    }
}