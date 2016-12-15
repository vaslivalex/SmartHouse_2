using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse2
{
    class Menu
    {
        public void Show()
        {
            Dictionary<string, Device> MyDevice = new Dictionary<string, Device>();
            MyDevice.Add("Лампа", new Lamp(true, EColour.Red));
            MyDevice.Add("Телевизор", new TV(true, ESound.Middle));
            MyDevice.Add("Телефон", new Phone(true, ESound.Max, EBright.Low));
            MyDevice.Add("Микроволновка", new Microwave(true, EModeMicrowave.Defrost));

            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Название устройства: ");
                foreach (KeyValuePair<string, Device> dev in MyDevice)
                {
                    Console.Write(new String(' ', 5));
                    Console.ResetColor();
                    Console.WriteLine("{0,-15} {1,5}", dev.Key, dev.Value.ToString());

                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Введите команду: ");
                Console.ResetColor();

                string[] commands = Console.ReadLine().Split(' ');
                if (commands[0].ToLower() == "exit" & commands.Length == 1)
                {
                    return;
                }
                if (commands.Length != 3)
                {
                    Help();
                    continue;
                }
                if (commands[0].ToLower() == "add" && !MyDevice.ContainsKey(commands[2]))
                {
                    if (commands[1] == "Microwave")
                    {
                        MyDevice.Add(commands[2], new Microwave(true, EModeMicrowave.Defrost));
                        continue;
                    }
                    else if (commands[1] == "Lamp")
                    {
                        MyDevice.Add(commands[2], new Lamp(true, EColour.Red));
                        continue;
                    }
                    else if (commands[1] == "TV")
                    {
                        MyDevice.Add(commands[2], new TV(true, ESound.Min));
                        continue;
                    }
                    else if (commands[1] == "Phone")
                    {
                        MyDevice.Add(commands[2], new Phone(true, ESound.Min, EBright.Low));
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("\nНеизвестное устройство\nДля продолжение нажмите любую клавишу.");
                        Console.ReadKey();
                        continue;
                    }
                }
                if (commands[0].ToLower() == "add" && MyDevice.ContainsKey(commands[2]))
                {
                    Console.WriteLine("Устройство с таким именем уже существует");
                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                    Console.ReadLine();
                    continue;
                }
                if (!MyDevice.ContainsKey(commands[2]))
                {
                    Help();
                    continue;
                }
                switch (commands[0].ToLower())
                {
                    case "del":
                        MyDevice.Remove(commands[2]);
                        break;
                    case "on":
                        MyDevice[commands[2]].On();
                        break;
                    case "off":
                        MyDevice[commands[2]].Off();
                        break;
                    //case "set":
                    //    byte number;
                    //    bool result = byte.TryParse(Console.ReadLine(), out number);
                    //    if (result)
                    //    {
                    //        ((TV)MyDevice[commands[2]]).SetChanel(number);
                    //    }
                        //break;
                    case "red":
                        if (MyDevice[commands[2]] is Lamp)
                        {
                            ((Lamp)MyDevice[commands[2]]).SetRedColor();
                        }
                        break;
                    case "green":
                        if (MyDevice[commands[2]] is Lamp)
                        {
                            ((Lamp)MyDevice[commands[2]]).SetGreenColor();
                        }
                        break;
                    case "blue":
                        if (MyDevice[commands[2]] is Lamp)
                        {
                            ((Lamp)MyDevice[commands[2]]).SetBlueColor();
                        }
                        break;
                    case "defrost":
                        if (MyDevice[commands[2]] is Microwave)
                        {
                            ((Microwave)MyDevice[commands[2]]).SetPowerDefrost();
                        }
                        break;
                    case "min":
                        if (MyDevice[commands[2]] is Microwave)
                        {
                            ((Microwave)MyDevice[commands[2]]).SetPowerMin();
                        }
                        else if (MyDevice[commands[2]] is TV)
                        {
                            ((TV)MyDevice[commands[2]]).SetLevelSoundMin();
                        }
                        else if (MyDevice[commands[2]] is Phone)
                        {
                            ((Phone)MyDevice[commands[2]]).SetLevelSoundMin();
                        }
                        break;
                    case "middle":
                        if (MyDevice[commands[2]] is Microwave)
                        {
                            ((Microwave)MyDevice[commands[2]]).SetPowerMiddle();
                        }
                        else if (MyDevice[commands[2]] is TV)
                        {
                            ((TV)MyDevice[commands[2]]).SetLevelSoundMiddle();
                        }
                        else if (MyDevice[commands[2]] is Phone)
                        {
                            ((Phone)MyDevice[commands[2]]).SetLevelSoundMin();
                        }
                        break;
                    case "max":
                        if (MyDevice[commands[2]] is Microwave)
                        {
                            ((Microwave)MyDevice[commands[2]]).SetPowerMax();
                        }
                        else if (MyDevice[commands[2]] is TV)
                        {
                            ((TV)MyDevice[commands[2]]).SetLevelSoundMax();
                        }
                        else if (MyDevice[commands[2]] is Phone)
                        {
                            ((Phone)MyDevice[commands[2]]).SetLevelSoundMin();
                        }
                        break;
                    case "mute":
                        if (MyDevice[commands[2]] is TV)
                        {
                            ((TV)MyDevice[commands[2]]).SetLevelSoundMute();
                        }
                        else if (MyDevice[commands[2]] is Phone)
                        {
                            ((Phone)MyDevice[commands[2]]).SetLevelSoundMin();
                        }
                        break;
                    default:
                        Help();
                        break;
                }
            }
        }
        private static void Help()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Доступные команды:");
            Console.WriteLine(new String('-', 40));
            Console.WriteLine("\tДля лампы:");
            Console.WriteLine(" ");
            Console.WriteLine("\tadd Lamp nameLamp");
            Console.WriteLine("\tdel Lamp nameLamp");
            Console.WriteLine("\ton Lamp nameLamp");
            Console.WriteLine("\toff Lamp nameLamp");
            Console.WriteLine("\tred Lamp nameLamp");
            Console.WriteLine("\tgreen Lamp nameLamp");
            Console.WriteLine("\tblue Lamp nameLamp");

            Console.WriteLine(new String('-', 40));
            Console.WriteLine("\tДля микроволновой печи:");
            Console.WriteLine(" ");
            Console.WriteLine("\tadd Microwave nameMicrowave");
            Console.WriteLine("\tdel Microwave nameMicrowave");
            Console.WriteLine("\ton Microwave nameMicrowave");
            Console.WriteLine("\toff Microwave nameMicrowave");
            Console.WriteLine("\tdefrost Microwave nameMicrowave");
            Console.WriteLine("\tmin Microwave nameMicrowave");
            Console.WriteLine("\tmiddle Microwave nameMicrowave");
            Console.WriteLine("\tmax Microwave nameMicrowave");
            Console.WriteLine(" ");

            Console.WriteLine(new String('-', 40));
            Console.WriteLine("\tДля телевизора:");
            Console.WriteLine(" ");
            Console.WriteLine("\tadd TV nameTV");
            Console.WriteLine("\tdel TV nameTV");
            Console.WriteLine("\ton TV nameTV");
            Console.WriteLine("\toff TV nameTV");
            Console.WriteLine("\tmute TV nameTV");
            Console.WriteLine("\tmin TV nameTV");
            Console.WriteLine("\tmiddle TV nameTV");
            Console.WriteLine("\tmax TV nameTV");
            Console.WriteLine(" ");

            Console.WriteLine(new String('-', 40));
            Console.WriteLine("\tДля телефона:");
            Console.WriteLine(" ");
            Console.WriteLine("\tadd Phone namePhone");
            Console.WriteLine("\tdel Phone namePhone");
            Console.WriteLine("\ton Phone namePhone");
            Console.WriteLine("\toff Phone namePhone");
            Console.WriteLine("\tmute Phone namePhone");
            Console.WriteLine("\tmin Phone namePhone");
            Console.WriteLine("\tmiddle Phone namePhone");
            Console.WriteLine("\tmax Phone namePhone");
            Console.WriteLine(" ");

            Console.WriteLine(new String('-', 40));
            Console.WriteLine("\tОбщие команды:");
            Console.WriteLine("\texit");
            Console.WriteLine(" ");
            Console.WriteLine(new String('-', 40));
            Console.WriteLine("Нажмите любую клавишу для продолжения");
            Console.ReadLine();
        }
    }
}
