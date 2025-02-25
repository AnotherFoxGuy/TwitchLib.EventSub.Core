﻿using System;
using TwitchLib.EventSub.Core.Models.HypeTrain;

namespace TwitchLib.EventSub.Core.SubscriptionTypes.Channel
{
    /// <summary>
    /// HypeTrain End subscription type model
    /// <para>Description:</para>
    /// <para>A Hype Train ends on the specified channel.</para>
    /// </summary>
    public class HypeTrainEnd : HypeTrainBase
    {
        /// <summary>
        /// The time when the Hype Train cooldown ends so that the next Hype Train can start.
        /// </summary>
        public DateTimeOffset CooldownEndsAt { get; set; } = DateTimeOffset.MinValue;
        /// <summary>
        /// The time when the Hype Train ended.
        /// </summary>
        public DateTimeOffset EndedAt { get; set; } = DateTimeOffset.MinValue;
    }
}