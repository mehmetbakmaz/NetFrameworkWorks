﻿using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFramework.S6.D6.StackGenelKullanim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack S1= new Stack();

            S1.Push("Bir");
            S1.Push("İki");
            S1.Push("Üç");
            S1.Push("Dört");

            object O1 = S1.Pop(); //datayı gönderdi remove etti
            object O2 = S1.Peek();//datayı gönderdi remove etmedi

        }
    }
}
