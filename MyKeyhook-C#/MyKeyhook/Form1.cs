﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities;

namespace MyKeyhook
{
    public partial class Form1 : Form
    {
        Boolean loggingKeys = false;
        globalKeyboardHook logAllKeysHook;
        globalKeyboardHook checkShortcut;

        public Form1()
        {
            InitializeComponent();
            logAllKeysHook = new globalKeyboardHook();
           // logAllKeysHook.unhook();
            checkShortcut = new globalKeyboardHook();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //init all alphabet keys
            logAllKeysHook.HookedKeys.Add(Keys.A);
            logAllKeysHook.HookedKeys.Add(Keys.B);
            logAllKeysHook.HookedKeys.Add(Keys.C);
            logAllKeysHook.HookedKeys.Add(Keys.D);
            logAllKeysHook.HookedKeys.Add(Keys.E);
            logAllKeysHook.HookedKeys.Add(Keys.F);
            logAllKeysHook.HookedKeys.Add(Keys.G);
            logAllKeysHook.HookedKeys.Add(Keys.H);
            logAllKeysHook.HookedKeys.Add(Keys.I);
            logAllKeysHook.HookedKeys.Add(Keys.J);
            logAllKeysHook.HookedKeys.Add(Keys.K);
            logAllKeysHook.HookedKeys.Add(Keys.L);
            logAllKeysHook.HookedKeys.Add(Keys.M);
            logAllKeysHook.HookedKeys.Add(Keys.N);
            logAllKeysHook.HookedKeys.Add(Keys.O);
            logAllKeysHook.HookedKeys.Add(Keys.P);
            logAllKeysHook.HookedKeys.Add(Keys.Q);
            logAllKeysHook.HookedKeys.Add(Keys.R);
            logAllKeysHook.HookedKeys.Add(Keys.S);
            logAllKeysHook.HookedKeys.Add(Keys.T);
            logAllKeysHook.HookedKeys.Add(Keys.U);
            logAllKeysHook.HookedKeys.Add(Keys.V);
            logAllKeysHook.HookedKeys.Add(Keys.W);
            logAllKeysHook.HookedKeys.Add(Keys.X);
            logAllKeysHook.HookedKeys.Add(Keys.Y);
            logAllKeysHook.HookedKeys.Add(Keys.Z);
            logAllKeysHook.HookedKeys.Add(Keys.LControlKey);
            logAllKeysHook.HookedKeys.Add(Keys.RControlKey);
            logAllKeysHook.HookedKeys.Add(Keys.LShiftKey);
            logAllKeysHook.HookedKeys.Add(Keys.RShiftKey);
            logAllKeysHook.HookedKeys.Add(Keys.D0);
            logAllKeysHook.HookedKeys.Add(Keys.D1);
            logAllKeysHook.HookedKeys.Add(Keys.D2);
            logAllKeysHook.HookedKeys.Add(Keys.D3);
            logAllKeysHook.HookedKeys.Add(Keys.D4);
            logAllKeysHook.HookedKeys.Add(Keys.D5);
            logAllKeysHook.HookedKeys.Add(Keys.D6);
            logAllKeysHook.HookedKeys.Add(Keys.D7);
            logAllKeysHook.HookedKeys.Add(Keys.D8);
            logAllKeysHook.HookedKeys.Add(Keys.D9);

            logAllKeysHook.KeyUp += new KeyEventHandler(logAll_keyUp);

            //init shortcut key
            checkShortcut.HookedKeys.Add(Keys.A);
        }

        void logAll_keyUp(object sender, KeyEventArgs e)
        {
            myTxt.AppendText("Pressed\t" + e.KeyCode.ToString() +"\n");
        }

    }
}