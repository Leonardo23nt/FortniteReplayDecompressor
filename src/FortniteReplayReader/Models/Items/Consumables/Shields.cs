﻿using System;
using System.Collections.Generic;
using System.Text;
using Unreal.Core.Attributes;
using Unreal.Core.Models.Enums;

namespace FortniteReplayReader.Models.Items.Consumables
{
    public class ShieldConsumable : Consumable
    {
    }

    [NetFieldExportGroup("/Game/Abilities/Player/Generic/UtilityItems/B_ConsumableSmall_MiniShield_Athena.B_ConsumableSmall_MiniShield_Athena_C", ParseType.Normal)]
    public class MiniShields : ShieldConsumable
    {
    }

    [NetFieldExportGroup("/Game/Abilities/Player/Generic/UtilityItems/B_ConsumableSmall_HalfShield_Athena.B_ConsumableSmall_HalfShield_Athena_C", ParseType.Normal)]
    public class HalfPot : ShieldConsumable
    {
    }
}