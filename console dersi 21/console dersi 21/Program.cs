﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace console_dersi_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SoundPlayer ses = new SoundPlayer();
            string yol;
            yol = "C:\\Users\\ismai\\Music\\asktan_da_ote_seksenler_enstrumantal_album_aac_34239.wav";
            ses.SoundLocation= yol;
            ses.Play();
            Console.ReadLine();
            //System.Diagnostics.Process.Start("C:\\Users\\ismai\\Music\\asktan_da_ote_seksenler_enstrumantal_album_aac_34239.m4a");
        }
    }
}
