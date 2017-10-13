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
· операции *: одновременно домножает поля a, b и c на скаляр.

Продемонстрировать работу класса.
*/

namespace ClassesAndObjectsTask2
{
    class Triangle
    {
        // Поля
        int a, b, c;
        int perimeter;

        // Конструктор, позволяющий создать экземпляр класса с заданными длинами сторон.
        public Triangle()
        {
            a = 0;
            b = 0;
            c = 0;
        }

        public Triangle(int a, int b, int c)
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
            int semiperimeter = perimeter / 2;
            double area = Math.Sqrt(semiperimeter * (semiperimeter - a) * (semiperimeter - b) * (semiperimeter - c));
            return $"Площадь треугольника S = {area:f2} см";
        }

        // Свойство, позволяющее получить-установить длины сторон треугольника (доступное для чтения и записи)
        public int A
        {
            get => a;
            set => a = value;
        }

        public int B
        {
            get => b;
            set => b = value;
        }

        public int C
        {
            get => c;
            set => c = value;
        }

        // Свойство, позволяющее установить, существует ли треугольник с данными длинами сторон (доступное только для чтения)
        public bool IsTriangle
        {
            get
            {
                if (a + b > c && a + c > b && b + c > a)
                {
                    return true;
                }
                return false;
            }
        }

        // Индексатор, позволяющий по индексу 0 обращаться к полю a, по индексу 1 – к полю b, по индексу 2 – к полю c, 
        // при других значениях индекса выдается сообщение об ошибке.
        public string this[double i]
        {
            get
            {
                switch (i)
                {
                    case 0:
                        return $"Индекс {i} соответствует стороне A, равной {a} см";
                    case 1:
                        return $"Индекс {i} соответствует стороне B, равной {b} см";
                    case 2:
                        return $"Индекс {i} соответствует стороне C, равной {c} см";
                    default:
                        return $"Индекс {i} является недействительным";
                }
            }
        }

        // Перегрузка операции ++: одновременно увеличивает значение полей a, b и c на 1;
        public static Triangle operator ++(Triangle side) => new Triangle(++side.a, ++side.b, ++side.c);

        // Перегрузка операции --: одновременно уменьшает значение полей a, b и c на 1;
        public static Triangle operator --(Triangle side) => new Triangle(--side.a, --side.b, --side.c);

        // Перегрузка констант true и false
        // обращение к экземпляру класса дает значение true, если треугольник с заданными длинами сторон существует, иначе false;
        public static bool operator true(Triangle side) => side.IsTriangle;

        public static bool operator false(Triangle side) => side.IsTriangle;

        // Перегрузка операции *: одновременно домножает поля a, b и c на скаляр.
        public static Triangle operator *(Triangle side, int scalar) => new Triangle(side.a *= scalar, side.b *= scalar, side.c *= scalar);
    }
}
