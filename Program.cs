using System;

namespace snakeGame
{
    
    class Program
    {
        static void Main(string[] args)
        {
            // string nam;
            // int m;
            // int tuoi;
            // Console.Write("moi ban nhap năm:");
            // nam=Console.ReadLine();
            
            // if(!int.TryParse(nam, out m))
            // {
            //     Console.Write("moi ban nhap so");
            // }
            // else
            // {
            //  tuoi=DateTime.Now.Year-m;
            // Console.WriteLine("tuoi cua bạn la:{0}",tuoi);
            // if(tuoi<16)
            // {
            //     Console.WriteLine("ban {0}, tuoi vi thanh nien",tuoi);
            // }
            // else
            // if(tuoi<18 &&tuoi>=16)
            // {
            //     Console.WriteLine("ban {0}, tuoi ban truong thanh",tuoi);
            // }
            // else
            // {
            //     Console.WriteLine("ban {0}, tuoi ban gia roi",tuoi);
            // }
            // }
            
            // int Computer;
            // string Player;

            // Console.WriteLine("****************************\n*   Trò chơi Kéo Búa Bao   *\n* 1: Kéo  2: Búa  3:   Bao *\n****************************");

            // while (true) 
            // {
            //     Console.Write("\nMời bạn chọn Kéo hoặc Búa hoặc Bao theo số tương ứng: ");
            //     Player = Console.ReadLine();

            //     if (Player == "1" || Player == "2" || Player == "3")
            //     {
            //         Random rd = new Random();
            //         Computer = rd.Next(1, 4);

            //         if (Player == "1")
            //         {
            //             Console.WriteLine("\nBạn: Kéo");
            //         }
            //         else if (Player == "2")
            //         {
            //             Console.WriteLine("\nBạn: Búa");
            //         }
            //         else
            //         {
            //             Console.WriteLine("\nBạn: Bao");
            //         }

            //         if (Computer == 1)
            //         {
            //             Console.WriteLine("Máy: Kéo");
            //         }
            //         else if (Computer == 2)
            //         {
            //             Console.WriteLine("Máy: Búa");
            //         }
            //         else
            //         {
            //             Console.WriteLine("Máy: Bao");
            //         }

            //         if ((Player == "1" && Computer == 3) || (Player == "2" && Computer == 1) || (Player == "3" && Computer == 2))
            //         {
            //             Console.WriteLine("\nKết quả: Bạn đã chiến thắng!");
            //         }
            //         else if ((Player == "1" && Computer == 1) || (Player == "2" && Computer == 2) || (Player == "3" && Computer == 3))
            //         {
            //             Console.WriteLine("\nKết quả: Hòa rồi!");
            //         }
            //         else
            //         {
            //             Console.WriteLine("\nKết quả: Bạn thùa rồi!");
            //         }
            //         break;
            //     }
            // }
            // string namduong;
            // Console.WriteLine("mời bạn nhập vào năm dương lịch:");
            // namduong=Console.ReadLine();
            // int a=int.Parse(namduong);
            // string can="";
            // string chi="";
            // switch(a%10)
            // {
            //     case 0:
            //         can="canh";
            //         break;
            //     case 1:
            //         can="tân";
            //         break;
            //     case 2:
            //         can="nhâm";
            //         break;
            //     case 3:

            //         can="quý";
            //         break;

            //     case 4:
            //         can="giáp";
            //         break;
            //     case 5:
            //         can="ất";
            //         break;   
            //     case 6:
            //         can="bính";
            //         break;
            //     case 7:
            //         can="đinh";
            //         break; 
            //     case 8:
            //         can="dậu";
            //         break;     
            //     case 9:
            //         can="kỉ";
            //         break;
            // }
            // switch(a%12)
            // {
            //     case 0:
            //         chi="thân";
            //         break;
            //     case 1:
            //         chi="dậu";
            //         break;
            //     case 2:
            //         chi="tuất";
            //         break;
            //     case 3:
            //         chi="hợi";
            //         break;
            //     case 4:
            //         chi="tí";
            //         break;
            //     case 5:
            //         chi="sửu";
            //         break;
            //     case 6:
            //         chi="dần";
            //         break;
            //     case 7:
            //         chi="mẹo";
            //         break;
            //     case 8:
            //         chi="thìn";
            //         break;
            //     case 9:
            //         chi="ty";
            //         break;
            //     case 10:
            //         chi="ngọ";
            //         break;
            //     case 11:
            //         chi="mùi";
            //         break;
            // }
            // Console.WriteLine("năm {0} là năm {1}{2}",namduong,can,chi);
            Console.Clear();
            // mau nen cosole
            Console.BackgroundColor =ConsoleColor.DarkGray;
            // mau chu
            Console.ForegroundColor =ConsoleColor.Blue;
            //change size
            //Console.SetWindowSize(60,30);
            //xet vi tri cua man hinh buffer =man hin window
            //Console.SetBufferSize(Console.WindowWidth, Console.WindowHeight);
            // xac dinh vi tri con tro
            Console.SetCursorPosition(40,20);
            Console.WriteLine("welcome to snake game");
        }
    }
}