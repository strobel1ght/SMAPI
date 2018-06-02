using System;
using StardewModdingAPI.Events;

namespace StardewModdingAPI.Framework.Events
{
    /// <summary>Events raised when the player provides input using a controller, keyboard, or mouse.</summary>
    internal class ModInputEvents : ModEventsBase, IInputEvents
    {
        /*********
        ** Accessors
        *********/
        /// <summary>Raised when the player presses a button on the keyboard, controller, or mouse.</summary>
        public event EventHandler<InputButtonPressedArgsInput> ButtonPressed
        {
            add => this.EventManager.Input_ButtonPressed.Add(value);
            remove => this.EventManager.Input_ButtonPressed.Remove(value);
        }

        /// <summary>Raised when the player releases a button on the keyboard, controller, or mouse.</summary>
        public event EventHandler<InputButtonReleasedArgsInput> ButtonReleased
        {
            add => this.EventManager.Input_ButtonReleased.Add(value);
            remove => this.EventManager.Input_ButtonReleased.Remove(value);
        }


        /*********
        ** Public methods
        *********/
        /// <summary>Construct an instance.</summary>
        /// <param name="mod">The mod which uses this instance.</param>
        /// <param name="eventManager">The underlying event manager.</param>
        internal ModInputEvents(IModMetadata mod, EventManager eventManager)
            : base(mod, eventManager) { }
    }
}
