﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Artemis.Models;

namespace Artemis.Modules.Games.Dota2
{
    class Dota2Settings : GameSettings
    {

        public Dota2Settings()
        {
            Load();
        }


        #region Variables
        public string GameDirectory { get; set; }
        public bool CanCastAbility { get; set; }
        public bool ShowHealth { get; set; }
        public bool ShowDayCycle { get; set; }
        public bool CanCastItem { get; set; }
        public bool ShowMana { get; set; }
        public bool ShowDead { get; set; }
        #endregion


        public override void Load()
        {
            ShowHealth = Dota2.Default.ShowHealth;
            CanCastAbility = Dota2.Default.CanCastAbility;
            Enabled = Dota2.Default.Enabled;
            GameDirectory = Dota2.Default.GameDirectory;
            CanCastItem = Dota2.Default.CanCastItem;
            ShowDayCycle = Dota2.Default.ShowDayCycle;
            ShowMana = Dota2.Default.ShowMana;
            ShowDead = Dota2.Default.ShowDead;
        }

        public override void Save()
        {
            Dota2.Default.ShowDayCycle = ShowDayCycle;
            Dota2.Default.ShowHealth = ShowHealth;
            Dota2.Default.CanCastAbility = CanCastAbility;
            Dota2.Default.Enabled = Enabled;
            Dota2.Default.GameDirectory = GameDirectory;
            Dota2.Default.CanCastItem = CanCastItem;
            Dota2.Default.ShowMana = ShowMana;
            Dota2.Default.ShowDead = ShowDead;

            Dota2.Default.Save();
        }

        public override void ToDefault()
        {
           
            Enabled = false;
            GameDirectory = string.Empty;

            ShowHealth = true;
            CanCastAbility = true;
            ShowDayCycle = true;
            CanCastItem = true;
            ShowMana = true;
            ShowDead = true;

        }
    }
}
