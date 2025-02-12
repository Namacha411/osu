﻿// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

#nullable disable

using System;
using osu.Framework.Graphics.Sprites;
using osu.Game.Overlays.Dialog;

namespace osu.Game.Overlays.Settings.Sections.Maintenance
{
    public class MassDeleteConfirmationDialog : PopupDialog
    {
        public MassDeleteConfirmationDialog(Action deleteAction)
        {
            BodyText = "Everything?";

            Icon = FontAwesome.Regular.TrashAlt;
            HeaderText = @"Confirm deletion of";
            Buttons = new PopupDialogButton[]
            {
                new PopupDialogDangerousButton
                {
                    Text = @"Yes. Go for it.",
                    Action = deleteAction
                },
                new PopupDialogCancelButton
                {
                    Text = @"No! Abort mission!",
                },
            };
        }
    }
}
