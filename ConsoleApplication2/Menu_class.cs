﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Menu_class
    {
    public void show_menu(int OptionsCursorHeigh)
        {
            String opcje =
    "                                                                       /$$$$$$  /$$$$$$$  /$$$$$$$$ /$$$$$$  /$$$$$$  /$$   /$$  /$$$$$$           \n" +
    "                                                                      /$$__  $$| $$__  $$|__  $$__/|_  $$_/ /$$__  $$| $$$ | $$ /$$__  $$          \n" +
    "                                                                     | $$  \\ $$| $$  \\ $$   | $$     | $$  | $$  \\ $$| $$$$| $$| $$  \\__/      \n" +
    "                                                                     | $$  | $$| $$$$$$$/   | $$     | $$  | $$  | $$| $$ $$ $$|  $$$$$$           \n" +
    "                                                                     | $$  | $$| $$____/    | $$     | $$  | $$  | $$| $$  $$$$ \\____  $$         \n" +
    "                                                                     | $$  | $$| $$         | $$     | $$  | $$  | $$| $$\\  $$$ /$$  \\ $$        \n" +
    "                                                                     |  $$$$$$/| $$         | $$    /$$$$$$|  $$$$$$/| $$ \\  $$|  $$$$$$/         \n" +
    "                                                                      \\______/ |__/         |__/   |______/ \\______/ |__/  \\__/ \\______/       \n";


            String scoreboard =
"                                                       ______    ______    ______   _______   ________  _______    ______    ______   _______   _______  \n" +
"                                                      /      \\  /      \\  /      \\ /       \\ /        |/       \\  /      \\  /      \\ /       \\ /       \\ \n" +
"                                                     /$$$$$$  |/$$$$$$  |/$$$$$$  |$$$$$$$  |$$$$$$$$/ $$$$$$$  |/$$$$$$  |/$$$$$$  |$$$$$$$  |$$$$$$$  |\n" +
"                                                     $$ \\__$$/ $$ |  $$/ $$ |  $$ |$$ |__$$ |$$ |__    $$ |__$$ |$$ |  $$ |$$ |__$$ |$$ |__$$ |$$ |  $$ |\n" +
"                                                     $$      \\ $$ |      $$ |  $$ |$$    $$< $$    |   $$    $$< $$ |  $$ |$$    $$ |$$    $$< $$ |  $$ |\n" +
"                                                      $$$$$$  |$$ |   __ $$ |  $$ |$$$$$$$  |$$$$$/    $$$$$$$  |$$ |  $$ |$$$$$$$$ |$$$$$$$  |$$ |  $$ |\n" +
"                                                     /  \\__$$ |$$ \\__/  |$$ \\__$$ |$$ |  $$ |$$ |_____ $$ |__$$ |$$ \\__$$ |$$ |  $$ |$$ |  $$ |$$ |__$$ |\n" +
"                                                     $$    $$/ $$    $$/ $$    $$/ $$ |  $$ |$$       |$$    $$/ $$    $$/ $$ |  $$ |$$ |  $$ |$$    $$/ \n" +
"                                                      $$$$$$/   $$$$$$/   $$$$$$/  $$/   $$/ $$$$$$$$/ $$$$$$$/   $$$$$$/  $$/   $$/ $$/   $$/ $$$$$$$/ \n";
            Console.Write(opcje);
            Console.SetCursorPosition(0, OptionsCursorHeigh + 10);
            Console.Write(scoreboard);
        }
    }
}
