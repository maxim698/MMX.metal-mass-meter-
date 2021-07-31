using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MMX.metal_mass_meter_Измеритель_массы_металла_
{
    class Program
    {
        static void MaterialSelection(double materialCoefficient)
        {
           
            switch ((SteelGrade)materialCoefficient)
            {
                case SteelGrade.Сталь:
                    materialCoefficient = 1.0;
                    break;
                case SteelGrade.Асбест:
                    materialCoefficient = 0.32;
                    break;
                case SteelGrade.Асботекстолит:
                    materialCoefficient = 0.23;
                    break;
                case SteelGrade.Алюминий_АМц:
                    materialCoefficient = 0.35;
                    break;
                case SteelGrade.Бензин:
                    materialCoefficient = 0.10;
                    break;
                case SteelGrade.Бумага_Асбестовая_Изолированная:
                    materialCoefficient = 0.11;
                    break;
                case SteelGrade.Войлок:
                    materialCoefficient = 0.37;
                    break;
                case SteelGrade.ГРафик:
                    materialCoefficient = 2.52;
                    break;
                case SteelGrade.Золото:
                    materialCoefficient = 2.45;
                    break;
                case SteelGrade.Картон:
                    materialCoefficient = 0.10;
                    break;
                case SteelGrade.Картон_изолированный:
                    materialCoefficient = 0.15;
                    break;
                case SteelGrade.Керосин:
                    materialCoefficient = 0.11;
                    break;
                case SteelGrade.Масло:
                    materialCoefficient = 0.12;
                    break;
                case SteelGrade.Резина:
                    materialCoefficient = 0.23;
                    break;
                case SteelGrade.Свинец:
                    materialCoefficient = 1.44;
                    break;
                case SteelGrade.Серебро:
                    materialCoefficient = 1.33;
                    break;
                case SteelGrade.Ст_Литье:
                    materialCoefficient = 0.99;
                    break;
                case SteelGrade.Титан:
                    materialCoefficient = 0.57;
                    break;
                case SteelGrade.Эбонит:
                    materialCoefficient = 0.16;
                    break;
                case SteelGrade.Полипропилен:
                    materialCoefficient = 0.11;
                    break;
                case SteelGrade.Полиуретан:
                    materialCoefficient = 0.15;
                    break;
                case SteelGrade.Фторопласт:
                    materialCoefficient = 0.28;
                    break;
                case SteelGrade.Нержавейка:
                    materialCoefficient = 1.1;
                    break;
                case SteelGrade.Паронит_ПОН:
                    materialCoefficient = 0.25;
                    break;
                case SteelGrade.Винипласт_ВН:
                    materialCoefficient = 0.18;
                    break;
                case SteelGrade.ГЕтинакс:
                    materialCoefficient = 0.18;
                    break;
                case SteelGrade.КАпролон_ПА_6:
                    materialCoefficient = 0.15;
                    break;
                case SteelGrade.Пластикат:
                    materialCoefficient = 0.19;
                    break;
                case SteelGrade.ОРГ_Стекло:
                    materialCoefficient = 0.15;
                    break;
                case SteelGrade.Полиэтилен:
                    materialCoefficient = 0.12;
                    break;
                case SteelGrade.Текстолит:
                    materialCoefficient = 0.18;
                    break;
                case SteelGrade.Стеклотекстолит:
                    materialCoefficient = 0.24;
                    break;
                case SteelGrade.Фибра:
                    materialCoefficient = 0.15;
                    break;
                case SteelGrade.БрА_Ж9_4Л:
                    materialCoefficient = 0.97;
                    break;
                case SteelGrade.БрБ2:
                    materialCoefficient = 1.04;
                    break;
                case SteelGrade.БрМц5:
                    materialCoefficient = 1.09;
                    break;
                case SteelGrade.БрОф8:
                    materialCoefficient = 1.09;
                    break;
                case SteelGrade.БрОЦС5_5_5:
                    materialCoefficient = 1.12;
                    break;
                case SteelGrade.БрОЦС4_4_4:
                    materialCoefficient = 1.16;
                    break;
                case SteelGrade.Д_16:
                    materialCoefficient = 0.36;
                    break;
                case SteelGrade.ЛС_59_1Л:
                    materialCoefficient = 1.08;
                    break;
                case SteelGrade.Л_63:
                    materialCoefficient = 1.07;
                    break;
                case SteelGrade.Медь:
                    materialCoefficient = 1.14;
                    break;
                default:
                    Console.WriteLine("Номера материала нет в списке");
                    break;
            }
        }
        static void PrintMaterials()
        {
            foreach (SteelGrade numberMaterial in Enum.GetValues(typeof(SteelGrade)))
            {
                Console.WriteLine($"{(int)numberMaterial} - {numberMaterial}");
            }
        }
        static double MetalMass(int width,int length,double thickness,double density,int count, double materialCoefficient)
        {
            
            double weight = ((width * length * thickness * density)*count)/1000000;

            return weight*materialCoefficient;
        }
        static void Main(string[] args)
        {
            double density = 7.85;
            while (true)
            {
                Console.Clear();
                PrintMaterials();
                Console.WriteLine("Выберите материал");
                double.TryParse(Console.ReadLine(),out double materialCoefficient);
                MaterialSelection(materialCoefficient);
                Console.WriteLine("Введите ширину в мм");
                int.TryParse(Console.ReadLine(), out int width);
                Console.WriteLine("Введите длину в мм");
                int.TryParse(Console.ReadLine(), out int length);
                Console.WriteLine("Введите толщину металла в мм");
                double.TryParse(Console.ReadLine(), out double thickness);
                Console.WriteLine("Введите количество листов в шт");
                int.TryParse(Console.ReadLine(), out int count);
                double result = MetalMass(width, length, thickness, density, count,materialCoefficient);
                Console.WriteLine($"Масса металла равна : {result} кг");
                Console.ReadLine();
            }
        }    
    }
}
