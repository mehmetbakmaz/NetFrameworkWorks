﻿using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFramework.S6.D7.QueueGenelKullanim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue Q1 = new Queue();
            Q1.Enqueue("Bir");
            Q1.Enqueue("İki");
            Q1.Enqueue("Üç");
            Q1.Enqueue("Dört");

            object O1 = Q1.Peek();//datayı gönderdi remove etmedi
            object O2 = Q1.Dequeue(); //datayı gönderdi remove etti



        }
    }
}
