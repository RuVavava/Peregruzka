using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Peregruzka
{
    //Ввод информации о Питомце
    internal class Program
    {
        /// <summary>
        /// Краткая информация
        /// </summary>
        /// <param name="vladel"></param>
        /// <param name="pet"></param>
        /// <returns></returns>
        static string InformationPet(string vladel, string pet)
        {
            return $"Краткое ФИО владельца: {vladel}.\n" +
                $"Кличка питомца: {pet}.";
        }

        /// <summary>
        /// Полная информация о владельце + Питомец
        /// </summary>
        /// <param name="vladel"></param>
        /// <param name="pet"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        static string InformationPet(string vladel_F, string vladel_I, string vladel_O, string pet)
        {
            return $"ФИО владельца: {vladel_F} {vladel_I} {vladel_O}.\n" +
                $"Кличка питомца: {pet}.";
        }

        /// <summary>
        /// ФИО + Кличка + Возраст П
        /// </summary>
        /// <param name="vladel_F"></param>
        /// <param name="vladel_I"></param>
        /// <param name="vladel_O"></param>
        /// <param name="pet"></param>
        /// <param name="vozrast"></param>
        /// <returns></returns>
        static string InformationPet(string vladel_F, string vladel_I, string vladel_O, string pet, int vozrast)
        {
            return $"ФИО владельца: {vladel_F} {vladel_I} {vladel_O}.\n" +
                $"Кличка питомца: {pet}.\n" +
                $"Возраст питомца: {vozrast}.";
        }

        /// <summary>
        /// ФИО + Кличка + В + Вид/Окрас
        /// </summary>
        /// <param name="vladel_F"></param>
        /// <param name="vladel_I"></param>
        /// <param name="vladel_O"></param>
        /// <param name="pet"></param>
        /// <param name="vozrast"></param>
        /// <param name="vid_porpda"></param>
        /// <returns></returns>
        static string InformationPet(string vladel_F, string vladel_I, string vladel_O, string pet, int vozrast,
             string vid_porpda)
        {
            return $"ФИО владельца: {vladel_F} {vladel_I} {vladel_O}.\n" +
                $"Кличка питомца: {pet}.\n" +
                $"Возраст питомца: {vozrast}.\n" +
                $"Вид/порода {vid_porpda}";
        }

        /// <summary>
        /// ФИО + П + Информ П
        /// </summary>
        /// <param name="vladel_F"></param>
        /// <param name="vladel_I"></param>
        /// <param name="vladel_O"></param>
        /// <param name="pet"></param>
        /// <param name="vozrast"></param>
        /// <param name="vid_porpda"></param>
        /// <param name="pol"></param>
        /// <returns></returns>
        static string InformationPet(string vladel_F, string vladel_I, string vladel_O, string pet, int vozrast,
            string vid_porpda, string pol)
        {
            return $"ФИО владельца: {vladel_F} {vladel_I} {vladel_O}.\n" +
                $"Кличка питомца: {pet}.\n" +
                $"Возраст питомца/ пол: {vozrast} , {pol}.\n" +
                $"Вид/порода {vid_porpda}";
        }

        /// <summary>
        /// Полная инфо ФИО и Питомец
        /// </summary>
        /// <param name="vladel_F"></param>
        /// <param name="vladel_I"></param>
        /// <param name="vladel_O"></param>
        /// <param name="pet"></param>
        /// <param name="vozrast"></param>
        /// <param name="vid_porpda"></param>
        /// <param name="pol"></param>
        /// <param name="ves"></param>
        /// <returns></returns>
        static string InformationPet(string vladel_F, string vladel_I, string vladel_O, string pet, int vozrast,
            string vid_porpda, string pol, double ves)
        {
            return $"ФИО владельца: {vladel_F} {vladel_I} {vladel_O}.\n" +
                $"Кличка питомца: {pet}.\n" +
                $"Возраст питомца/ пол: {vozrast} , {pol}.\n" +
                $"Вид/порода {vid_porpda}. \n" +
                $"Вес: {ves}";
        }

        /// <summary>
        /// Полная инфо Владелец и Питомец + Дата обращения
        /// </summary>
        /// <param name="vladel_F"></param>
        /// <param name="vladel_I"></param>
        /// <param name="vladel_O"></param>
        /// <param name="pet"></param>
        /// <param name="vozrast"></param>
        /// <param name="vid_porpda"></param>
        /// <param name="pol"></param>
        /// <param name="ves"></param>
        /// <param name="date_obr"></param>
        /// <returns></returns>
        static string InformationPet(string vladel_F, string vladel_I, string vladel_O, string pet, int vozrast,
            string vid_porpda, string pol, double ves, DateTime date_obr)
        {
            return $"ФИО владельца: {vladel_F} {vladel_I} {vladel_O}.\n" +
                $"Кличка питомца: {pet}.\n" +
                $"Возраст питомца/ пол: {vozrast} , {pol}.\n" +
                $"Вид/порода {vid_porpda}. \n" +
                $"Вес: {ves}.\n" +
                $"\t Выписка из медицинской карты животного \n" +
                $"Дата обращения: {date_obr}";
        }

        /// <summary>
        /// Полн инфо Владелец + Питомец + Описание проблемы
        /// </summary>
        /// <param name="vladel_F"></param>
        /// <param name="vladel_I"></param>
        /// <param name="vladel_O"></param>
        /// <param name="pet"></param>
        /// <param name="vozrast"></param>
        /// <param name="vid_porpda"></param>
        /// <param name="pol"></param>
        /// <param name="ves"></param>
        /// <param name="date_obr"></param>
        /// <param name="anamnez"></param>
        /// <returns></returns>
        static string InformationPet(string vladel_F, string vladel_I, string vladel_O, string pet, int vozrast,
            string vid_porpda, string pol, double ves, DateTime date_obr, string anamnez)
        {
            return $"ФИО владельца: {vladel_F} {vladel_I} {vladel_O}.\n" +
                $"Кличка питомца: {pet}.\n" +
                $"Возраст питомца/ пол: {vozrast} , {pol}.\n" +
                $"Вид/порода {vid_porpda}. \n" +
                $"Вес: {ves}.\n" +
                $"\t Выписка из медицинской карты животного \n" +
                $"Дата обращения: {date_obr}\n" +
                $"\t Описание проблемы:\n" +
                $"Анамнез: {anamnez}";
        }
        static void Main(string[] args)
        {
            //Console.WriteLine(InformationPet("Корнилова В.Д", "Чипс"));
            //Console.WriteLine("\n");

            //Console.WriteLine(InformationPet("Корнилова", "Варвара", "Дмитриевна", "Чипс"));
            //Console.WriteLine("\n");

            //Console.WriteLine(InformationPet("Корнилова", "Варвара", "Дмитриевна", "Чипс", 1));
            //Console.WriteLine("\n");

            //Console.WriteLine(InformationPet("Корнилова", "Варвара", "Дмитриевна", "Чипс", 1, "Кошки/ Метис"));
            //Console.WriteLine("\n");

            //Console.WriteLine(InformationPet("Корнилова", "Варвара", "Дмитриевна", "Чипс", 1, "Кошки/ Метис", "М"));
            //Console.WriteLine("\n");

            //Console.WriteLine(InformationPet("Корнилова", "Варвара", "Дмитриевна", "Чипс", 1, "Кошки/ Метис", "М", 4.60));
            //Console.WriteLine("\n");

            //Console.WriteLine(InformationPet("Корнилова", "Варвара", "Дмитриевна", "Чипс", 1, "Кошки/ Метис", "М", 4.60,
            //    new DateTime(2023, 09, 22, 10, 45, 00)));
            //Console.WriteLine("\n");

            Console.WriteLine(InformationPet("Корнилова", "Варвара", "Дмитриевна", "Чипс", 1, "Кошки/ Метис", "М", 4.60,
                new DateTime(2023, 09, 22, 10, 45, 00), "мочеспускание отсутсвует со вчерашнего вечера, 1 раз в мес проблемы с мочеспусканием,\nсегодня " +
                "рвота 2 раза, аппетит отсутсвует. В июле завели второго котенка"));
            Console.WriteLine("\n");
        }
    }
}
