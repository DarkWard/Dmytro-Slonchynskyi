﻿using System;

/*
 * Спроектировать объектную модель для заданной предметной области. В работе в обязательном порядке должен быть реализован ВЕСЬ требующийся в задании функционал.:
 * Использовать: классы, наследование, интерфейсы, полиморфизм, инкапсуляция
 * Каждый класс, метод и переменная должны иметь исчерпывающее смысл название и информативный состав. Необходимо точно продумать, какие классы необходимы для решения задачи.
 * Наследование должно применяться только тогда, когда это имеет смысл.
 * Классы должны быть грамотно разложены по файлам.
 * Задание представляет собой какую-то предметную область, в которой требуется выделить необходимую иерархию классов и реализовать ее с помощью ООП (используя наследование, если необходимо или реализовывая интерфейсы).
 * В каждом классе должны быть поля и методы, которые вы посчитаете необходимыми. Программа должна создавать объекты различных классов в выделенной предметной области, объединять их в какой-то набор объектов (не использовать коллекции).
 * Как правило, задание требует выполнить поиск по заданным критериям объектов, удовлетворяющим условиям поиск из полученного набора объектов.
 * В качестве структур для хранения данных использовать массивы
 * Для реализации поиска реализовать методы расширения
 * Код должен быть отформатирован
 * Иерархия наследования должна быть минимум 4 шага в глубину не включая в расчет самый базовый.
 * Подумать, как можно сделать наиболее гибким  решение задания
 *
 * Варианты задания.
 * Новогодний подарок. Определить иерархию конфет и прочих сладостей. Создать несколько объектов-конфет. Собрать детский подарок с определением его веса.
 * Провести сортировку конфет в подарке на основе одного из параметров. Найти конфету в подарке, соответствующую заданному критерию параметров.
 *
 * Шеф-повар. Определить иерархию овощей. Сделать салат. Посчитать калорийность. Провести сортировку овощей для салата на основе одного из параметров. Найти овощи в салате, соответствующие заданному критерию параметров.

*/

namespace HomeTask5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Vehicle.BuildPark();
        }
    }
}