// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Pen_NEW1_014.cs" company="">
//   
// </copyright>
// <summary>
//   The pen_ ne w 1_014.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace HREngine.Bots
{
    /// <summary>
    ///     The pen_ ne w 1_014.
    /// </summary>
    internal class Pen_NEW1_014 : PenTemplate
    {
        // masterofdisguise

        // kampfschrei:/ verleiht einem befreundeten diener verstohlenheit/.
        #region Public Methods and Operators

        /// <summary>
        /// The get play penalty.
        /// </summary>
        /// <param name="p">
        /// The p.
        /// </param>
        /// <param name="m">
        /// The m.
        /// </param>
        /// <param name="target">
        /// The target.
        /// </param>
        /// <param name="choice">
        /// The choice.
        /// </param>
        /// <param name="isLethal">
        /// The is lethal.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public override int getPlayPenalty(Playfield p, Minion m, Minion target, int choice, bool isLethal)
        {
            return 0;
        }

        #endregion
    }
}