﻿namespace Challenge02
{
    internal class Program
    {
        private static string input = "B Z\r\nB X\r\nC Y\r\nB Y\r\nB Y\r\nA X\r\nA X\r\nB Z\r\nA Z\r\nB Z\r\nB Y\r\nB X\r\nC X\r\nB Y\r\nA Z\r\nB Y\r\nA X\r\nB X\r\nC Y\r\nB Y\r\nB Y\r\nC Y\r\nB X\r\nB X\r\nC X\r\nB Y\r\nB Y\r\nB Y\r\nC Y\r\nC X\r\nB Y\r\nC X\r\nC X\r\nB Y\r\nB Z\r\nC Y\r\nB Y\r\nB Z\r\nB X\r\nB Y\r\nB Y\r\nC Y\r\nB Y\r\nC Y\r\nC Y\r\nA Z\r\nB X\r\nC X\r\nB Y\r\nB X\r\nC X\r\nA X\r\nB Y\r\nC Y\r\nB X\r\nC X\r\nC Y\r\nB X\r\nB Z\r\nB Y\r\nB X\r\nC Y\r\nB X\r\nB Y\r\nB Y\r\nB Y\r\nB Y\r\nA X\r\nA Z\r\nB Z\r\nB Y\r\nC X\r\nB Y\r\nB Y\r\nC Y\r\nC Z\r\nC Z\r\nC X\r\nB X\r\nC Z\r\nB Y\r\nB Y\r\nC X\r\nC Z\r\nC X\r\nA Z\r\nC Y\r\nB Y\r\nB Y\r\nB Y\r\nC Y\r\nC Y\r\nC X\r\nC X\r\nC Z\r\nA X\r\nB Y\r\nC X\r\nB Z\r\nB Y\r\nC X\r\nB X\r\nB Z\r\nA Z\r\nC Y\r\nB Z\r\nC X\r\nC X\r\nB Y\r\nB Y\r\nB Y\r\nC Y\r\nC X\r\nB X\r\nB Y\r\nA Z\r\nA Z\r\nC Y\r\nB Y\r\nC Y\r\nC Y\r\nC Y\r\nB X\r\nA Z\r\nC Y\r\nC Y\r\nA Z\r\nA Z\r\nB X\r\nB Y\r\nB Z\r\nA Z\r\nB X\r\nB Y\r\nC Z\r\nC Z\r\nB Z\r\nB Y\r\nB X\r\nA Y\r\nC Z\r\nC X\r\nA Z\r\nA Z\r\nB Y\r\nB Y\r\nC Y\r\nC Y\r\nB Y\r\nB Y\r\nB Y\r\nA Z\r\nC Y\r\nC Z\r\nC X\r\nA Z\r\nB X\r\nB Y\r\nA Y\r\nA Y\r\nB Y\r\nB Y\r\nC X\r\nB Y\r\nB Y\r\nC Z\r\nB Y\r\nB Y\r\nA Z\r\nC Y\r\nB X\r\nC X\r\nA X\r\nC X\r\nB Y\r\nB X\r\nA Z\r\nC X\r\nC Y\r\nA Z\r\nB Y\r\nA Z\r\nB X\r\nB X\r\nA Z\r\nB Y\r\nC X\r\nC X\r\nA Z\r\nA X\r\nC X\r\nC X\r\nC X\r\nB Y\r\nC Z\r\nC Y\r\nC X\r\nB Y\r\nB Y\r\nB Y\r\nA X\r\nA Z\r\nC Y\r\nB Y\r\nB Y\r\nA X\r\nC Y\r\nC Z\r\nC Y\r\nC X\r\nB Y\r\nB Y\r\nB Y\r\nB Y\r\nA Z\r\nB Y\r\nA Z\r\nB X\r\nB Y\r\nB Y\r\nB X\r\nC Y\r\nA X\r\nA Z\r\nB Y\r\nC Y\r\nC Y\r\nB Y\r\nB Y\r\nC X\r\nB Y\r\nB X\r\nA Z\r\nB Y\r\nB Y\r\nC Y\r\nB Y\r\nB Y\r\nB Y\r\nA X\r\nB X\r\nB Z\r\nC Y\r\nB Z\r\nC X\r\nC X\r\nB Z\r\nB Y\r\nA Z\r\nA Z\r\nB Y\r\nC X\r\nA X\r\nC Y\r\nB Y\r\nB Y\r\nA X\r\nB Y\r\nA Y\r\nC Y\r\nB Y\r\nC X\r\nB Y\r\nA Z\r\nB Z\r\nC Y\r\nB Y\r\nB Y\r\nC X\r\nB Y\r\nB Y\r\nB Y\r\nC Z\r\nA X\r\nB Y\r\nB X\r\nC X\r\nC Z\r\nC Z\r\nC Y\r\nC Y\r\nA X\r\nC Y\r\nB Y\r\nA X\r\nC X\r\nA Z\r\nC X\r\nB Y\r\nC Z\r\nC Z\r\nA Z\r\nA X\r\nC Y\r\nC X\r\nB Y\r\nC Z\r\nB Y\r\nC Y\r\nC X\r\nC Y\r\nB Y\r\nB Y\r\nB Y\r\nA X\r\nA Z\r\nB Y\r\nB X\r\nB X\r\nB Y\r\nB Y\r\nB Y\r\nA Z\r\nB Y\r\nB Y\r\nA X\r\nA X\r\nA Z\r\nA Z\r\nB X\r\nC Y\r\nA Z\r\nB Y\r\nB Y\r\nC Z\r\nC X\r\nC Y\r\nA Z\r\nC Y\r\nC Y\r\nC Y\r\nC Y\r\nC X\r\nA Z\r\nC Z\r\nA Z\r\nC Y\r\nC X\r\nB Y\r\nB Y\r\nC Z\r\nB X\r\nB Z\r\nC X\r\nA Y\r\nC Y\r\nB X\r\nB X\r\nB Y\r\nC Y\r\nA Z\r\nA Z\r\nB X\r\nB Z\r\nB X\r\nC Y\r\nA X\r\nA X\r\nC Z\r\nB Y\r\nC Y\r\nC X\r\nB Y\r\nA Z\r\nB Y\r\nC Y\r\nB Z\r\nC Z\r\nC X\r\nB Z\r\nC Z\r\nB Z\r\nA X\r\nC Y\r\nA Z\r\nB Y\r\nB Y\r\nB Y\r\nB Y\r\nB Y\r\nB Y\r\nA Z\r\nC Z\r\nB X\r\nC X\r\nC Y\r\nC Y\r\nB Y\r\nC X\r\nC X\r\nA Y\r\nC Y\r\nC Y\r\nA Z\r\nC Z\r\nB Y\r\nB X\r\nC X\r\nB Y\r\nC X\r\nB Y\r\nB Y\r\nC X\r\nB Y\r\nB Y\r\nB Y\r\nA Z\r\nC Y\r\nB Z\r\nB Y\r\nC X\r\nB Y\r\nC X\r\nA Y\r\nA Z\r\nB Y\r\nB Y\r\nB Y\r\nA Z\r\nB Y\r\nB Y\r\nB Y\r\nB Y\r\nB Z\r\nC Y\r\nB Z\r\nB Z\r\nA Z\r\nB Y\r\nB Y\r\nC X\r\nA X\r\nB Y\r\nA Z\r\nC X\r\nC X\r\nB Y\r\nB Y\r\nA X\r\nB Y\r\nB Y\r\nC X\r\nB Y\r\nC X\r\nB Y\r\nB Y\r\nB Y\r\nB Y\r\nA X\r\nB Y\r\nB Z\r\nB Y\r\nA Z\r\nC X\r\nC X\r\nC Y\r\nA Z\r\nC Y\r\nB Y\r\nB X\r\nA X\r\nB Y\r\nA Z\r\nB Y\r\nC Y\r\nB Y\r\nB Y\r\nC Y\r\nC X\r\nA Z\r\nA X\r\nA Z\r\nC Z\r\nB Y\r\nB Y\r\nC Y\r\nB X\r\nC X\r\nB Y\r\nA Z\r\nB Y\r\nC X\r\nA X\r\nC X\r\nC Y\r\nC Y\r\nB X\r\nB Y\r\nB Y\r\nC Z\r\nB Y\r\nC X\r\nA Z\r\nC Z\r\nC Y\r\nA Z\r\nC X\r\nC Y\r\nC Y\r\nC X\r\nB Y\r\nB Y\r\nC Z\r\nA Z\r\nB Y\r\nA X\r\nB Y\r\nA X\r\nA X\r\nC Y\r\nC X\r\nA Z\r\nB Y\r\nC Y\r\nC X\r\nB Y\r\nB Y\r\nB Y\r\nB X\r\nB X\r\nA X\r\nC X\r\nB Y\r\nC Y\r\nA Z\r\nA Z\r\nA Z\r\nB Y\r\nA Z\r\nB Y\r\nC X\r\nB Y\r\nC X\r\nC Y\r\nA Z\r\nB Y\r\nB Z\r\nA Z\r\nB Y\r\nA Z\r\nB Y\r\nB Y\r\nC Z\r\nB Y\r\nB Y\r\nA Z\r\nA X\r\nC Z\r\nC Z\r\nB Z\r\nB Y\r\nA Z\r\nB Y\r\nB Y\r\nB Y\r\nB Y\r\nC Z\r\nA Z\r\nC X\r\nB X\r\nB Y\r\nA X\r\nA X\r\nB Y\r\nA Z\r\nA X\r\nC Y\r\nB Y\r\nC X\r\nA Z\r\nB Y\r\nC Z\r\nC Y\r\nB Y\r\nA X\r\nC Y\r\nB Y\r\nB Z\r\nA Y\r\nB Y\r\nB Y\r\nA Z\r\nB Y\r\nC Z\r\nC X\r\nB Y\r\nA Y\r\nC Z\r\nB X\r\nA X\r\nB Y\r\nB Y\r\nB Z\r\nB Z\r\nC Y\r\nB Y\r\nB Y\r\nA Z\r\nA Z\r\nB Y\r\nB X\r\nC Y\r\nC Y\r\nB Y\r\nB Y\r\nB Z\r\nB Z\r\nB Y\r\nC Y\r\nA Z\r\nB Y\r\nA Z\r\nB Y\r\nB Y\r\nA Z\r\nA Z\r\nC X\r\nC Z\r\nB Y\r\nC X\r\nB X\r\nA Z\r\nB Y\r\nB Y\r\nC X\r\nB Y\r\nB Y\r\nB Y\r\nB Y\r\nB X\r\nB Y\r\nA X\r\nB Z\r\nA Z\r\nC Z\r\nB X\r\nA Z\r\nC Y\r\nC Y\r\nA Z\r\nB Y\r\nC Z\r\nC Z\r\nC Y\r\nB Y\r\nB Y\r\nB Y\r\nA Z\r\nB Y\r\nB X\r\nC X\r\nB Y\r\nB Y\r\nB Y\r\nB Y\r\nC Y\r\nB Y\r\nC Y\r\nB Y\r\nC Y\r\nC X\r\nA Z\r\nC Y\r\nC Z\r\nC Z\r\nB X\r\nC Y\r\nB Y\r\nB X\r\nC Y\r\nB Y\r\nB Y\r\nC Y\r\nC X\r\nC X\r\nA Z\r\nB Y\r\nC X\r\nA Z\r\nC Z\r\nB Y\r\nB Y\r\nC X\r\nC X\r\nB Y\r\nB X\r\nC Y\r\nB Y\r\nB Y\r\nA Z\r\nA Z\r\nC Z\r\nA Z\r\nB Y\r\nC X\r\nC X\r\nB X\r\nB Y\r\nB Y\r\nB Z\r\nB Y\r\nB Y\r\nB Y\r\nB Y\r\nB Z\r\nB Y\r\nC Y\r\nC Z\r\nB Y\r\nC Y\r\nC Y\r\nC Y\r\nC Y\r\nA Z\r\nA Z\r\nC Y\r\nC Y\r\nA X\r\nB Y\r\nC Y\r\nA X\r\nC X\r\nC Y\r\nA Z\r\nB Y\r\nB Z\r\nA X\r\nB Y\r\nB Z\r\nB Y\r\nB Y\r\nB Z\r\nC X\r\nC Y\r\nB Y\r\nB Z\r\nB X\r\nA Z\r\nB Y\r\nC Y\r\nB Y\r\nB Y\r\nA X\r\nC X\r\nB Y\r\nC X\r\nB Y\r\nC Y\r\nA X\r\nA X\r\nA Z\r\nC Y\r\nB Y\r\nC Y\r\nC X\r\nB X\r\nC X\r\nC X\r\nA X\r\nA Z\r\nB Y\r\nB Y\r\nB Y\r\nA Z\r\nB Y\r\nB Y\r\nB Y\r\nB Y\r\nB Y\r\nB Y\r\nB X\r\nB Y\r\nC Y\r\nB Y\r\nA Z\r\nB Y\r\nC X\r\nC Y\r\nB Z\r\nC Z\r\nB Y\r\nA Y\r\nC X\r\nB Y\r\nB Y\r\nB Y\r\nC X\r\nA Y\r\nC Z\r\nB Y\r\nC X\r\nC Y\r\nC Y\r\nC Y\r\nC X\r\nC Y\r\nB Z\r\nB Y\r\nC Y\r\nC X\r\nB Y\r\nB Y\r\nB X\r\nC Y\r\nB X\r\nC Z\r\nB Y\r\nC X\r\nB Z\r\nC X\r\nB Y\r\nC X\r\nB Y\r\nC Y\r\nC Y\r\nA Z\r\nC Y\r\nC X\r\nB Y\r\nC X\r\nB X\r\nA Z\r\nB Y\r\nA Z\r\nA Z\r\nA Z\r\nC Y\r\nB X\r\nA Y\r\nC Y\r\nB Y\r\nB Y\r\nC Y\r\nC Y\r\nC X\r\nB X\r\nA X\r\nA Z\r\nC X\r\nA Y\r\nB X\r\nC Z\r\nB Y\r\nB Y\r\nB X\r\nC X\r\nB Y\r\nB Y\r\nB Y\r\nB X\r\nB Y\r\nC X\r\nB Y\r\nB Y\r\nC Z\r\nC Y\r\nB Y\r\nC Y\r\nB Y\r\nA Z\r\nC Z\r\nA Y\r\nB Y\r\nB Y\r\nB Y\r\nC Y\r\nC Y\r\nC Y\r\nB Y\r\nC Z\r\nB Y\r\nC Z\r\nA Z\r\nA Z\r\nC Z\r\nC Y\r\nC Z\r\nC Y\r\nA Z\r\nC X\r\nB X\r\nB Y\r\nC Y\r\nB Z\r\nC Z\r\nC X\r\nB Y\r\nA Z\r\nB Y\r\nC X\r\nB Z\r\nA X\r\nB Y\r\nA Z\r\nC Z\r\nC X\r\nC X\r\nC Y\r\nB Y\r\nB Y\r\nA Z\r\nA Z\r\nB Y\r\nB X\r\nA Z\r\nB Y\r\nC Y\r\nA X\r\nC Z\r\nB Y\r\nB X\r\nB Y\r\nC Y\r\nC Z\r\nB Z\r\nA Z\r\nB Y\r\nA X\r\nC X\r\nB Y\r\nA Z\r\nC X\r\nB Z\r\nC Y\r\nC Y\r\nC X\r\nC X\r\nC Y\r\nB Y\r\nB Y\r\nB Z\r\nB X\r\nC X\r\nB Z\r\nC X\r\nB X\r\nC Z\r\nC Z\r\nC X\r\nB Y\r\nC Y\r\nC X\r\nB Y\r\nA Z\r\nC Y\r\nC Z\r\nC Z\r\nC Y\r\nB Y\r\nA X\r\nC Z\r\nC X\r\nB Y\r\nC X\r\nC Z\r\nB Y\r\nC Y\r\nB Y\r\nC Y\r\nA Z\r\nB Z\r\nC Z\r\nC X\r\nB Z\r\nB Z\r\nB Y\r\nA Y\r\nC Y\r\nC Y\r\nB X\r\nB X\r\nB Y\r\nB Y\r\nB Y\r\nC X\r\nB Z\r\nB Y\r\nB Y\r\nB Y\r\nC X\r\nA X\r\nC Y\r\nA X\r\nB Y\r\nB Y\r\nB Y\r\nB Y\r\nB Y\r\nC Y\r\nC Y\r\nB Y\r\nB Y\r\nB Y\r\nB Y\r\nC Y\r\nB Y\r\nC X\r\nB Y\r\nB Y\r\nC X\r\nA Z\r\nA X\r\nC Y\r\nC Z\r\nB Y\r\nC X\r\nB Y\r\nB X\r\nA Z\r\nB X\r\nB Y\r\nB Y\r\nA Z\r\nB Y\r\nB Y\r\nB Y\r\nB Z\r\nA Z\r\nA X\r\nB Y\r\nA Z\r\nC Y\r\nB Y\r\nC X\r\nB Y\r\nC Y\r\nB Y\r\nB Y\r\nC X\r\nC Y\r\nA Y\r\nC X\r\nC Y\r\nB Y\r\nA Y\r\nA Z\r\nC Z\r\nA Y\r\nA Z\r\nB Y\r\nC Y\r\nC Y\r\nB Y\r\nB Y\r\nB Y\r\nB Y\r\nA Z\r\nB Y\r\nB Y\r\nB Y\r\nC X\r\nC X\r\nB Y\r\nC X\r\nB Y\r\nA Z\r\nB Y\r\nB X\r\nC Z\r\nC Y\r\nA Y\r\nB Y\r\nC Y\r\nB Y\r\nC Y\r\nC Y\r\nC Y\r\nC X\r\nC Y\r\nB Y\r\nB Y\r\nC Y\r\nB Y\r\nC Y\r\nA Z\r\nA X\r\nB Y\r\nA Z\r\nB Y\r\nC X\r\nC X\r\nB Y\r\nC Z\r\nB Y\r\nB Y\r\nC Y\r\nB Y\r\nC Z\r\nA Y\r\nB Y\r\nC Y\r\nB Y\r\nA Z\r\nC Y\r\nB Z\r\nC Y\r\nC Y\r\nC Z\r\nB Y\r\nC X\r\nB Z\r\nB Y\r\nB Y\r\nB Y\r\nC Z\r\nB Y\r\nB Y\r\nB Y\r\nA Z\r\nC X\r\nB Z\r\nB Y\r\nB Y\r\nC Y\r\nB Y\r\nC X\r\nB Y\r\nB Y\r\nC Y\r\nC X\r\nC Y\r\nB Y\r\nB Y\r\nC Y\r\nB Y\r\nA Y\r\nB Y\r\nA Z\r\nB Y\r\nB Y\r\nB X\r\nA Z\r\nB Y\r\nB Y\r\nC Y\r\nC X\r\nC Z\r\nA Z\r\nA Z\r\nC X\r\nB Y\r\nC Y\r\nB Y\r\nC X\r\nB Y\r\nB Y\r\nC Y\r\nC X\r\nB Y\r\nB Y\r\nB Y\r\nB Y\r\nB Y\r\nC X\r\nB Z\r\nB Z\r\nA Z\r\nB Z\r\nB Y\r\nB Z\r\nB Y\r\nC Y\r\nA Z\r\nA X\r\nB Y\r\nC Z\r\nB X\r\nA X\r\nC Y\r\nB Y\r\nB Y\r\nC Y\r\nB Y\r\nC Y\r\nB Y\r\nA Z\r\nB Y\r\nB Y\r\nA Z\r\nB Y\r\nB Y\r\nA Z\r\nB Y\r\nB Y\r\nB Y\r\nB Y\r\nC Y\r\nB Y\r\nA X\r\nA X\r\nB Y\r\nB Y\r\nA Y\r\nC Z\r\nA Z\r\nA Z\r\nB Y\r\nA Z\r\nC Y\r\nB Y\r\nB Y\r\nB Y\r\nB Y\r\nC Y\r\nB Y\r\nA X\r\nB X\r\nB Y\r\nB Y\r\nB Y\r\nB Y\r\nB X\r\nC Y\r\nB Y\r\nB Y\r\nB X\r\nC Y\r\nA Y\r\nB Y\r\nB Y\r\nB Y\r\nA X\r\nB Z\r\nC X\r\nA X\r\nC Z\r\nB Y\r\nB Y\r\nB Y\r\nC X\r\nB Y\r\nB Y\r\nB Y\r\nB Y\r\nC Y\r\nB Z\r\nB Z\r\nB Y\r\nB Z\r\nB Y\r\nB Y\r\nC Z\r\nC Y\r\nB Y\r\nC Z\r\nC Z\r\nB Y\r\nC X\r\nA Y\r\nB Y\r\nB Z\r\nA Z\r\nB Y\r\nC X\r\nB Y\r\nB Y\r\nC Z\r\nA Z\r\nB Y\r\nB X\r\nB Y\r\nC Y\r\nB Y\r\nB Z\r\nB Y\r\nB Y\r\nC X\r\nC X\r\nC Z\r\nB Y\r\nB Y\r\nB Y\r\nA Z\r\nA X\r\nB Y\r\nA Z\r\nB Y\r\nB Y\r\nB Y\r\nB Z\r\nC X\r\nC Z\r\nB Y\r\nB Y\r\nB Y\r\nC Z\r\nB X\r\nC Z\r\nA X\r\nB Y\r\nC Y\r\nB Y\r\nA Z\r\nA X\r\nC X\r\nB X\r\nA Z\r\nC X\r\nB Y\r\nC Y\r\nB X\r\nA Z\r\nC Y\r\nC Y\r\nB Z\r\nC X\r\nB Y\r\nC X\r\nC Z\r\nC Y\r\nB Y\r\nC Z\r\nB Y\r\nB Y\r\nC X\r\nB Y\r\nB Y\r\nB Y\r\nB Y\r\nB Y\r\nB Y\r\nC X\r\nB Y\r\nB Y\r\nB Y\r\nA Z\r\nB Y\r\nB Y\r\nC Z\r\nB Y\r\nB Y\r\nB Y\r\nC X\r\nA Z\r\nB Z\r\nC Y\r\nC Y\r\nB Y\r\nA X\r\nC Y\r\nB Y\r\nC Z\r\nB Z\r\nB Y\r\nB Y\r\nC Y\r\nB Y\r\nB Y\r\nB Y\r\nC Z\r\nA X\r\nB Y\r\nC Y\r\nA X\r\nB Y\r\nB Y\r\nA X\r\nB Y\r\nA Y\r\nC X\r\nA Z\r\nA Z\r\nC Y\r\nB Y\r\nC Z\r\nC Y\r\nC Y\r\nC Z\r\nA Z\r\nA X\r\nC Z\r\nB Y\r\nC X\r\nA Z\r\nC X\r\nB Y\r\nB Y\r\nB Y\r\nC Z\r\nC Y\r\nC X\r\nC Y\r\nA Y\r\nC X\r\nA Z\r\nA Z\r\nB Z\r\nC X\r\nB Y\r\nB Y\r\nC X\r\nA Z\r\nC Z\r\nC Z\r\nB Y\r\nB Y\r\nA Y\r\nC X\r\nB Z\r\nB Y\r\nB Y\r\nC X\r\nC X\r\nC Z\r\nC Z\r\nB Y\r\nB Y\r\nB X\r\nB Y\r\nB Y\r\nC Z\r\nC Y\r\nC Z\r\nB Y\r\nB Y\r\nB Y\r\nC Y\r\nB X\r\nC X\r\nA Z\r\nC X\r\nC X\r\nC Y\r\nB Y\r\nB Y\r\nC Y\r\nB Z\r\nB Z\r\nC X\r\nC Y\r\nB Y\r\nB Z\r\nB Y\r\nB X\r\nA Z\r\nC X\r\nB Z\r\nA Z\r\nC X\r\nB Y\r\nC Y\r\nC Y\r\nB Y\r\nB Y\r\nB Y\r\nB X\r\nA X\r\nB Y\r\nA X\r\nA Z\r\nC Y\r\nB Y\r\nB Y\r\nB Y\r\nB Y\r\nB Y\r\nC Z\r\nB X\r\nB Y\r\nC X\r\nA Z\r\nB Y\r\nB Y\r\nA Z\r\nB Y\r\nC Y\r\nC Z\r\nC X\r\nC Y\r\nB Y\r\nB Y\r\nB Z\r\nB Y\r\nA X\r\nC Y\r\nB Y\r\nA X\r\nB Y\r\nC X\r\nA Z\r\nB Y\r\nC X\r\nA Z\r\nB Y\r\nC X\r\nC Y\r\nC X\r\nB Z\r\nC Z\r\nB Y\r\nC Y\r\nC X\r\nC Y\r\nB Z\r\nB X\r\nA X\r\nC Z\r\nB Y\r\nB Y\r\nC Y\r\nB Z\r\nC X\r\nC X\r\nB Y\r\nB Y\r\nC Y\r\nB X\r\nB Y\r\nC Y\r\nB Y\r\nB Y\r\nA Z\r\nB Y\r\nB Y\r\nB Y\r\nA X\r\nA Z\r\nB Z\r\nB Z\r\nB Y\r\nA Z\r\nB Y\r\nC Y\r\nB Y\r\nC X\r\nB X\r\nB Y\r\nB Y\r\nB X\r\nC Z\r\nB Y\r\nC Z\r\nC X\r\nB Y\r\nC Z\r\nB Y\r\nC Y\r\nB Z\r\nC Y\r\nC Y\r\nC Z\r\nC Z\r\nA X\r\nB Y\r\nA Z\r\nB Y\r\nB X\r\nA X\r\nB Y\r\nB Y\r\nB Y\r\nC Y\r\nB Y\r\nB X\r\nB Z\r\nC Z\r\nB X\r\nB Z\r\nB Y\r\nC Y\r\nB Y\r\nB Z\r\nC X\r\nA Z\r\nB X\r\nB Z\r\nC X\r\nC Z\r\nB Y\r\nA Z\r\nC X\r\nC Y\r\nB Z\r\nB Y\r\nC Y\r\nB Y\r\nC Y\r\nB Y\r\nB Y\r\nB Y\r\nC Y\r\nB Y\r\nC Y\r\nC X\r\nC Z\r\nB Y\r\nB Y\r\nB X\r\nC Z\r\nB X\r\nA Z\r\nC Y\r\nA Z\r\nC X\r\nC Y\r\nB Y\r\nC Z\r\nB Z\r\nC Z\r\nC Y\r\nC X\r\nB Y\r\nC Z\r\nC X\r\nB Y\r\nB Y\r\nB Y\r\nB X\r\nB Y\r\nB Y\r\nC X\r\nA X\r\nB Z\r\nC X\r\nC Z\r\nB Y\r\nC Y\r\nB Z\r\nC Z\r\nB Y\r\nC X\r\nB Y\r\nB Y\r\nA Z\r\nC Z\r\nB Y\r\nC Z\r\nC X\r\nB Y\r\nB Y\r\nC X\r\nC X\r\nC Y\r\nB Y\r\nA X\r\nA Z\r\nB Y\r\nC X\r\nB Y\r\nB Y\r\nC Y\r\nB Y\r\nA Z\r\nA Z\r\nC X\r\nC Z\r\nC X\r\nC X\r\nA X\r\nB Y\r\nB Y\r\nC Y\r\nC Z\r\nC Y\r\nB Z\r\nC Y\r\nB Y\r\nB Y\r\nB Y\r\nC Y\r\nB Z\r\nB Y\r\nB Y\r\nB X\r\nC Y\r\nC Y\r\nB Y\r\nA X\r\nC X\r\nA X\r\nC Z\r\nC Y\r\nA Y\r\nB Y\r\nB Y\r\nB Z\r\nC X\r\nC X\r\nB Y\r\nA X\r\nB Y\r\nA Z\r\nB Y\r\nA Z\r\nC X\r\nC X\r\nB Y\r\nB Y\r\nB Y\r\nB Y\r\nA X\r\nB Y\r\nB Z\r\nC Y\r\nC X\r\nC Z\r\nC Z\r\nB Y\r\nC Z\r\nB Y\r\nB Y\r\nC X\r\nB Y\r\nA X\r\nA Z\r\nB Y\r\nA Z\r\nC X\r\nB Y\r\nC Y\r\nB Z\r\nC Z\r\nB Y\r\nB Y\r\nB Y\r\nB Y\r\nC Y\r\nC Z\r\nB X\r\nB Y\r\nA Y\r\nC Y\r\nB Z\r\nB Y\r\nC Y\r\nA Z\r\nB Y\r\nB Y\r\nC Y\r\nC Y\r\nA Y\r\nC Y\r\nA Z\r\nC Y\r\nB X\r\nB Y\r\nB Y\r\nC Y\r\nA Z\r\nC Y\r\nA Z\r\nB Y\r\nB Y\r\nB Y\r\nB Y\r\nA X\r\nC Y\r\nA Z\r\nB Y\r\nB Y\r\nB Y\r\nB Y\r\nB Z\r\nC Z\r\nC Y\r\nC X\r\nB Y\r\nC X\r\nB Y\r\nB Y\r\nB Y\r\nB Y\r\nA Z\r\nB Y\r\nC Y\r\nC Y\r\nA Z\r\nA X\r\nB Y\r\nC Y\r\nC Y\r\nB Y\r\nC Y\r\nC Y\r\nC Y\r\nC Z\r\nA Z\r\nC X\r\nC Y\r\nC X\r\nB Y\r\nB Y\r\nC X\r\nC Z\r\nC X\r\nC Z\r\nB X\r\nB Y\r\nC Z\r\nB Z\r\nA Z\r\nC Y\r\nB Z\r\nC Y\r\nB Y\r\nA X\r\nB Y\r\nA Z\r\nB Y\r\nA X\r\nB Y\r\nB X\r\nB Z\r\nB X\r\nB Y\r\nB Y\r\nB Y\r\nC X\r\nB Y\r\nB X\r\nC X\r\nB Y\r\nB Z\r\nB Y\r\nC Y\r\nB Y\r\nB Y\r\nC X\r\nA Z\r\nC X\r\nB Y\r\nC Y\r\nC Z\r\nB Y\r\nC Z\r\nB Y\r\nB Y\r\nB Y\r\nB Y\r\nC Z\r\nC X\r\nC Y\r\nC Z\r\nB X\r\nA Z\r\nA Z\r\nB Y\r\nB Z\r\nC Y\r\nA X\r\nB Y\r\nB Y\r\nA Z\r\nB Y\r\nB Y\r\nB Y\r\nB Y\r\nA Z\r\nC Z\r\nB Z\r\nC Y\r\nA Z\r\nC Y\r\nB Y\r\nB Y\r\nB Y\r\nB Z\r\nB Y\r\nC X\r\nC Z\r\nB X\r\nC X\r\nB Y\r\nC Z\r\nC X\r\nB Y\r\nA Z\r\nA Z\r\nB Y\r\nB Y\r\nB Y\r\nC X\r\nA Y\r\nB Y\r\nB Y\r\nA Z\r\nA Z\r\nC Z\r\nC Y\r\nB Y\r\nB Y\r\nA X\r\nB Z\r\nA X\r\nB Y\r\nA Z\r\nB Y\r\nC X\r\nB Y\r\nA Y\r\nB Y\r\nB Z\r\nB Y\r\nB Z\r\nB Y\r\nB Y\r\nC Y\r\nC Y\r\nB Y\r\nC X\r\nC Z\r\nB Y\r\nB Y\r\nB Y\r\nC Z\r\nA Z\r\nC X\r\nB Y\r\nB Z\r\nB Y\r\nC Y\r\nB Y\r\nC X\r\nB Y\r\nB Y\r\nC Y\r\nB Y\r\nB Y\r\nB Y\r\nB Y\r\nB Y\r\nB Y\r\nB X\r\nB Y\r\nB Y\r\nC X\r\nB Y\r\nB Z\r\nA Z\r\nA Z\r\nC X\r\nB X\r\nB X\r\nC Y\r\nC Z\r\nB Y\r\nC X\r\nA X\r\nB Y\r\nC X\r\nC Z\r\nC X\r\nB Y\r\nB Y\r\nC Y\r\nB Y\r\nB Y\r\nB Y\r\nA Z\r\nC Z\r\nC X\r\nB Y\r\nB Y\r\nA X\r\nB Y\r\nC Y\r\nB Y\r\nB Y\r\nC Y\r\nB X\r\nB X\r\nA X\r\nC Y\r\nC Z\r\nC Y\r\nB Y\r\nB Y\r\nC X\r\nA X\r\nA X\r\nC X\r\nB Y\r\nC X\r\nB Y\r\nB Y\r\nB Y\r\nC Y\r\nA Z\r\nB Z\r\nA Z\r\nB Y\r\nB X\r\nC Y\r\nB Z\r\nB Y\r\nA Z\r\nB Y\r\nC Y\r\nB Y\r\nC Y\r\nA X\r\nB Y\r\nB Y\r\nB Y\r\nC X\r\nA Z\r\nC Y\r\nB Y\r\nB Y\r\nB Y\r\nC X\r\nB Y\r\nC Y\r\nB Y\r\nB X\r\nC X\r\nB Y\r\nB Y\r\nC Y\r\nC X\r\nC Z\r\nC Z\r\nB Y\r\nB Y\r\nB Y\r\nB X\r\nC X\r\nB X\r\nA Y\r\nA Z\r\nC Y\r\nA X\r\nB Y\r\nB Y\r\nB Y\r\nA Z\r\nC Y\r\nC X\r\nC Y\r\nC Z\r\nA Z\r\nB Y\r\nB Y\r\nB Y\r\nB Y\r\nA Z\r\nB Y\r\nA Z\r\nB Y\r\nB Y\r\nC Y\r\nC Z\r\nC Y\r\nA Z\r\nC Y\r\nB Y\r\nC Y\r\nB X\r\nB Y\r\nA X\r\nC Z\r\nC Z\r\nA X\r\nC X\r\nC Z\r\nC X\r\nC X\r\nB Y\r\nA X\r\nA Z\r\nC Y\r\nB Y\r\nC X\r\nB Y\r\nB Y\r\nB X\r\nC Y\r\nC Z\r\nB Y\r\nB Z\r\nA Z\r\nC Y\r\nB Y\r\nA Z\r\nB Y\r\nC X\r\nC X\r\nB Z\r\nC Y\r\nB X\r\nB Y\r\nC Y\r\nB Z\r\nA Z\r\nC X\r\nC Y\r\nC X\r\nC Z\r\nB Z\r\nC Z\r\nB Y\r\nB X\r\nB Y\r\nB X\r\nB Y\r\nB Y\r\nB Y\r\nB Y\r\nC X\r\nC X\r\nC Y\r\nB Z\r\nC X\r\nB Y\r\nB Y\r\nB Z\r\nC Z\r\nC Y\r\nB Y\r\nB Y\r\nB Y\r\nC X\r\nB Z\r\nB Y\r\nB X\r\nB Y\r\nC Y\r\nC X\r\nC Z\r\nC X\r\nC Y\r\nB Y\r\nB Y\r\nB X\r\nB Y\r\nC X\r\nB X\r\nA X\r\nB Y\r\nC Y\r\nB Y\r\nA X\r\nC Y\r\nB Z\r\nB Z\r\nC X\r\nC Z\r\nC X\r\nB Y\r\nC Y\r\nC Y\r\nB Y\r\nC Z\r\nB Y\r\nC Y\r\nB Y\r\nC Y\r\nA Z\r\nB Z\r\nC X\r\nC X\r\nB Y\r\nB Y\r\nB Z\r\nB Y\r\nB Z\r\nA X\r\nC X\r\nC X\r\nB Y\r\nC X\r\nA Z\r\nC Y\r\nB Y\r\nA Z\r\nC Z\r\nB X\r\nC Y\r\nC X\r\nC X\r\nA Z\r\nB Y\r\nB Y\r\nC Z\r\nB Y\r\nA Y\r\nC Y\r\nB Y\r\nB X\r\nB Z\r\nC X\r\nB Y\r\nB X\r\nC Z\r\nB Y\r\nB X\r\nB Y\r\nB Y\r\nB Y\r\nA Z\r\nA Z\r\nB Z\r\nA Z\r\nC Y\r\nC Z\r\nB X\r\nC X\r\nA Z\r\nC X\r\nB Y\r\nB Y\r\nA X\r\nB X\r\nB Y\r\nB X\r\nB X\r\nA Y\r\nA Z\r\nC X\r\nB Z\r\nB Z\r\nC Y\r\nC Y\r\nB Y\r\nB Y\r\nB Y\r\nA Z\r\nA Z\r\nB Y\r\nB Y\r\nC Y\r\nC Y\r\nC Y\r\nC Z\r\nC X\r\nC Y\r\nB Y\r\nB X\r\nB Y\r\nA Y\r\nA X\r\nC Y\r\nB Y\r\nA Z\r\nB Y\r\nB Y\r\nC X\r\nC X\r\nB Y\r\nB Y\r\nC Y\r\nA Z\r\nB Y\r\nC Y\r\nC Z\r\nC Z\r\nC Y\r\nA Y\r\nB Y\r\nB Y\r\nC Y\r\nB X\r\nC Z\r\nC Z\r\nC Z\r\nB Y\r\nB Y\r\nB Y\r\nC Y\r\nA Z\r\nB Y\r\nA Z\r\nB Y\r\nA Z\r\nC X\r\nC Z\r\nC Y\r\nB Y\r\nA Z\r\nB Y\r\nB Y\r\nC Z\r\nB Y\r\nC X\r\nB Y\r\nC Y\r\nC Y\r\nB Y\r\nB Y\r\nA X\r\nC Z\r\nB Y\r\nC Y\r\nC X\r\nB Y\r\nB Y\r\nB Y\r\nB Z\r\nA Z\r\nB Y\r\nB Y\r\nB Y\r\nA Z\r\nB Y\r\nA X\r\nB Y\r\nB Y\r\nB Y\r\nC Y\r\nC X\r\nC Y\r\nA Z\r\nB Y\r\nC Y\r\nB Y\r\nC Y\r\nC Y\r\nC Y\r\nA X\r\nC Z\r\nB Y\r\nB Y\r\nC Z\r\nB Y\r\nB Y\r\nC Z\r\nB Z\r\nB Y\r\nC Y\r\nB Y\r\nB Y\r\nB Y\r\nB Y\r\nB X\r\nC X\r\nC Y\r\nB Y\r\nA Z\r\nB Y\r\nA X\r\nB Y\r\nB Y\r\nB Y\r\nB Y\r\nC Z\r\nC Z\r\nB Y\r\nA Z\r\nB Y\r\nC X\r\nC X\r\nC Y\r\nB X\r\nA X\r\nB X\r\nB Y\r\nC X\r\nC Z\r\nC Y\r\nC Y\r\nB Y\r\nC Z\r\nB Y\r\nB Y\r\nC Z\r\nA X\r\nB Y\r\nC Z\r\nB Z\r\nB Y\r\nC X\r\nC X\r\nB Y\r\nB Y\r\nB X\r\nC Z\r\nA Z\r\nA X\r\nB Y\r\nC X\r\nB Y\r\nB Y\r\nC Z\r\nB Z\r\nC Y\r\nB Y\r\nB X\r\nC X\r\nC Z\r\nB Z\r\nB Z\r\nC Y\r\nB Y\r\nA X\r\nB Y\r\nB Y\r\nC X\r\nB X\r\nA Z\r\nB Y\r\nA Z\r\nB Y\r\nB Y\r\nA Z\r\nC X\r\nC X\r\nB Y\r\nB X\r\nB Y\r\nA Z\r\nC Y\r\nC Z\r\nB Y\r\nB Y\r\nA X\r\nB Y\r\nC Y\r\nC Y\r\nB Y\r\nA X\r\nB Y\r\nB Y\r\nA Z\r\nC X\r\nC X\r\nC Y\r\nB Y\r\nA X\r\nB Y\r\nB Y\r\nC Y\r\nB Y\r\nB Y\r\nB Y\r\nB Z\r\nB Y\r\nC Y\r\nC Y\r\nB Y\r\nC X\r\nC X\r\nB Y\r\nC Y\r\nB Y\r\nC X\r\nB Y\r\nB Z\r\nB Y\r\nA Z\r\nA Z\r\nC X\r\nA Z\r\nA Z\r\nB Y\r\nB X\r\nC Z\r\nB Y\r\nB Y\r\nB Y\r\nB Y\r\nB Y\r\nC X\r\nC Y\r\nB Y\r\nA X\r\nC X\r\nC X\r\nC Y\r\nB Y\r\nC X\r\nC X\r\nC Z\r\nB Z\r\nC Y\r\nC X\r\nB Y\r\nB Y\r\nC X\r\nB X\r\nC Z\r\nB Y\r\nB Y\r\nC Y\r\nA Z\r\nC Y\r\nC X\r\nC Y\r\nB Y\r\nB Y\r\nC X\r\nC Y\r\nC Y\r\nC X\r\nB Z\r\nB Z\r\nB Y\r\nB Y\r\nC Y\r\nB Y\r\nC X\r\nA Z\r\nA X\r\nC Z\r\nB Y\r\nC Y\r\nC Y\r\nB Y\r\nB Y\r\nC Y\r\nB Y";
        public enum RPS { A,B,C }
        public enum RPSS { X,Y,Z }
        static void Main(string[] args)
        {
            Console.WriteLine(TotalScore().ToString());
        }

        private static int TotalScore()
        {
            string[] allRPSrounds = input.Split("\r\n");
            return allRPSrounds.Sum((round) => ScoreCalculation(Convert(round.Split(' ')[0]).Item1, RPSSelection(Convert(round.Split(' ')[0]).Item1,Convert(round.Split(' ')[1]).Item2)));
        }

        private static RPSS RPSSelection(RPS playerSelection, RPSS ownSelection)
        {
            return (playerSelection, ownSelection) switch
            {
                (RPS.A, RPSS.Y) or (RPS.B, RPSS.X) or (RPS.C, RPSS.Z) => RPSS.X,
                (RPS.A, RPSS.Z) or (RPS.B, RPSS.Y) or (RPS.C, RPSS.X) => RPSS.Y,
                (RPS.A, RPSS.X) or (RPS.B, RPSS.Z) or (RPS.C, RPSS.Y) => RPSS.Z,
                _ => throw new NotImplementedException(),

            };
        }

        private static (RPS,RPSS) Convert(string value)
        {
            return value switch
            {
                "A" or "X" => (RPS.A, RPSS.X),
                "B" or "Y" => (RPS.B, RPSS.Y),
                "C" or "Z" => (RPS.C, RPSS.Z),
                _ => throw new NotImplementedException(),
            };
        }

        private static int ScoreCalculation(RPS player, RPSS own)
        {
            int score = 0;
            
            score += own switch
            {
                RPSS.X =>  1,
                RPSS.Y =>  2,
                RPSS.Z =>  3,
                _ => 0,
            };

            score += (player, own) switch
            {
                (RPS.A, RPSS.X) or (RPS.B, RPSS.Y) or (RPS.C, RPSS.Z) => 3,
                (RPS.B, RPSS.X) or (RPS.C, RPSS.Y) or (RPS.A, RPSS.Z) => 0,
                (RPS.C, RPSS.X) or (RPS.A, RPSS.Y) or (RPS.B, RPSS.Z) => 6,
                _ => 0,
            };

            return score;

        }
    }
}