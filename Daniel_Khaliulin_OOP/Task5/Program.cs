using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Scheme of inheritance of this app look like this:
             * 
             * -BaseClass (X, Y, Lenght, SetY(), SetX())
             * --Line (override Lenght, SetLenght())
             * ---Rectangle (S, Width, SetWidth())
             * ---Circle (R, SetR())
             * ----Round (S)
             * ----Ring (SmallR, SetSmallR(), SmallLenght, SetSmallLenght(), SmallS)
             */
            while (1 == 1)
            {
                Console.WriteLine();
                Console.WriteLine("Приложение представляет из себя загоровку для векторного редактора.\r\nОно позволяет создавать и выполить тип и значения таких фигур, как линия, окружность, прямоугольник, круг, кольцо");
                Console.WriteLine();
                Console.WriteLine("Чтобы отобразить фигуру, введите её номер");
                Console.WriteLine("1 - линия \r\n2 - окружность\r\n3 - прямоугольник\r\n4 - круг\r\n5 - кольцо");

                String stringChoose = Console.ReadLine();
                int intChoose;

                if (Int32.TryParse(stringChoose, out intChoose))
                {
                    if (intChoose > 0 && intChoose < 6)
                    {
                        switch (intChoose)
                        {
                            // Case with Line.
                            case (1):
                                {
                                    Console.WriteLine("Вы выбрали линию");
                                    Line line = new Line();

                                    // X axis.
                                    line.SetX();

                                    // Y axis.
                                    line.SetY();

                                    // Lenght.
                                    line.SetLenght();
                                    Console.WriteLine();
                                    Console.WriteLine("Тип - линия. Координаты - ({0},{1}). Длина - {2}", line.X, line.Y, line.Lenght);
                                    break;
                                }

                            // Case with circle.
                            case (2):
                                {
                                    Console.WriteLine("Вы выбрали окружность");
                                    Circle circle = new Circle();

                                    // X axis.
                                    circle.SetX();

                                    // Y axis.
                                    circle.SetY();

                                    // Lenght.
                                    circle.SetLenght();

                                    // Radius.
                                    circle.SetR();

                                    Console.WriteLine();
                                    Console.WriteLine("Тип - окружность. Координаты - ({0},{1}). Длина - {2}. Радиус - {3}", circle.X, circle.Y, circle.Lenght, circle.R);
                                    break;
                                }

                            // Case with Rectangle.
                            case (3):
                                {
                                    Console.WriteLine("Вы выбрали прямоугольник");
                                    Rectangle rectangle = new Rectangle();

                                    // X axis.
                                    rectangle.SetX();

                                    // Y axis.
                                    rectangle.SetY();

                                    // Lenght.
                                    rectangle.SetLenght();

                                    // Width.
                                    rectangle.SetWidth();

                                    Console.WriteLine();
                                    Console.WriteLine("Тип - прямоугольник. Координаты - ({0},{1}). Длина - {2}. Ширина - {3}. Площадь - {4}", rectangle.X, rectangle.Y, rectangle.Lenght, rectangle.Width, rectangle.S);
                                    break;
                                }

                            // Case with Round.
                            case (4):
                                {
                                    Console.WriteLine("Вы выбрали круг");
                                    Round round = new Round();

                                    // X axis.
                                    round.SetX();

                                    // Y axis.
                                    round.SetY();

                                    // Lenght.
                                    round.SetLenght();

                                    // Radius.
                                    round.SetR();

                                    Console.WriteLine();
                                    Console.WriteLine("Тип - круг. Координаты - ({0},{1}). Длина - {2}. Радиус - {3}. Площадь - {4}", round.X, round.Y, round.Lenght, round.R, round.S);
                                    break;
                                }

                            // Case with Ring.
                            case (5):
                                {
                                    Console.WriteLine("Вы выбрали кольцо");
                                    Ring ring = new Ring();

                                    // X axis.
                                    ring.SetX();

                                    // Y axis.
                                    ring.SetY();

                                    // Lenght.
                                    ring.SetLenght();

                                    // Radius.
                                    ring.SetR();

                                    // Small lenght.
                                    ring.SetSmallLenght();

                                    // Small radius.
                                    ring.SetSmallR();

                                    Console.WriteLine();
                                    Console.WriteLine("Тип - кольцо. Координаты - ({0},{1}). Длина - {2}. Радиус - {3}. Площадь - {4}", ring.X, ring.Y, ring.Lenght, ring.R, ring.S);
                                    Console.WriteLine("Длина (мал.) - {0}. Радиус (мал.) - {1}. Площадь (мал.) - {2}", ring.SmallLenght, ring.SmallR, ring.SmallS);
                                    break;
                                }
                        }
                    }
                    else 
                    {
                        Console.WriteLine("Выберите фигуру из представленных в списке");
                    }
                }
                else
                {
                    Console.WriteLine("Введите цифру желаемой фигуры");
                }
            }
        }
    }
}
