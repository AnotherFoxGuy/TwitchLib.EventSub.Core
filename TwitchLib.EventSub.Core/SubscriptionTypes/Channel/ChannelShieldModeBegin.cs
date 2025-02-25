﻿using System;
using TwitchLib.EventSub.Core.Models.ShieldMode;

namespace TwitchLib.EventSub.Core.SubscriptionTypes.Channel
{
    /// <summary>
    /// Channel Shield Mode Begin subscription type model
    /// <para>Description:</para>
    /// <para>Defines the Shield Mode data that you receive when the channel.shield_mode.begin event occurs.</para>
    /// </summary>
    public class ChannelShieldModeBegin : ShieldModeBase
    {
        /// <summary>
        /// The UTC timestamp (in RFC3339 format) of when the moderator activated Shield Mode.
        /// </summary>
        public DateTimeOffset StartedAt { get; set; } = DateTimeOffset.MinValue;
    }
}