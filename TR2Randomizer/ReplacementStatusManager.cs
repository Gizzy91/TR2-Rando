﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TR2Randomizer
{
    public static class ReplacementStatusManager
    {
        public static event EventHandler LevelProgressChanged;
        public static event EventHandler CanRandomizeChanged;
        public static event EventHandler AllowHardChanged;
        public static event EventHandler AllowHiddenChanged;

        private static int _LevelProgress;
        public static int LevelProgress 
        { 
            get { return _LevelProgress; } 
            set 
            { 
                if (value != _LevelProgress)
                {
                    _LevelProgress = value;

                    LevelProgressChanged?.Invoke(null, EventArgs.Empty);
                }
            }
        }

        private static bool _CanRandomize;
        public static bool CanRandomize 
        {
            get { return _CanRandomize; }
            set
            {
                if (value != _CanRandomize)
                {
                    _CanRandomize = value;

                    CanRandomizeChanged?.Invoke(null, EventArgs.Empty);
                }
            }
        }

        private static bool _AllowHard;
        public static bool AllowHard
        {
            get { return _AllowHard; }
            set
            {
                if (value != _AllowHard)
                {
                    _AllowHard = value;

                    AllowHardChanged?.Invoke(null, EventArgs.Empty);
                }
            }
        }

        private static bool _AllowHidden;
        public static bool AllowHidden
        {
            get { return _AllowHidden; }
            set
            {
                if (value != _AllowHidden)
                {
                    _AllowHidden = value;

                    AllowHiddenChanged?.Invoke(null, EventArgs.Empty);
                }
            }
        }
    }
}
