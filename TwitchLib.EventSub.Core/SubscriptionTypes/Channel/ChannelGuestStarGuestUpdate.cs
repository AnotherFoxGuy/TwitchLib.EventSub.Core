using TwitchLib.EventSub.Core.Models.GuestStar;

namespace TwitchLib.EventSub.Core.SubscriptionTypes.Channel
{
    /// <summary>
    /// Channel GuestStar Guest Update subscription type model
    /// <para>Description:</para>
    /// <para>The channel.guest_star_guest.update subscription type sends a notification when a guest moves between interaction states in an active Guest Star session.</para>
    /// </summary>
    public class ChannelGuestStarGuestUpdate : ChannelGuestStarBase
    {
        /// <summary>
        /// The current state of the user after the update has taken place. Can be one of the following:
        /// <para>
        /// invited — The guest has transitioned to the invite queue. This can take place when the guest was previously assigned a slot, but have been removed from the call and are sent back to the invite queue.
        /// </para>
        /// <para>
        /// ready — The guest has signaled they are ready and can be assigned a slot.
        /// </para>
        /// <para>
        /// backstage — The guest has been assigned a slot in the session, but is not currently seen live in the broadcasting software.
        /// </para>
        /// <para>
        /// live — The guest is now live in the host's broadcasting software.
        /// </para>
        /// <para>
        /// removed — The guest was removed from the call or queue.
        /// </para>
        /// </summary>
        public string State { get; set; } = string.Empty;
    }
}