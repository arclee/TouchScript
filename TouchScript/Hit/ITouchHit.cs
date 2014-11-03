/*
 * @author Valentin Simonov / http://va.lent.in/
 */

using UnityEngine;

namespace TouchScript.Hit
{
    /// <summary>
    /// An object which represents abstract metadata which is generated by touches hitting objects in Unity.
    /// </summary>
    public interface ITouchHit
    {
        /// <summary>
        /// Gets the object hit by touch.
        /// </summary>
        /// <value>
        /// The object hit by touch.
        /// </value>
        Transform Transform { get; }
    }
}
