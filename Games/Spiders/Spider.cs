// Generated by Creer at 11:41PM on April 07, 2016 UTC, git hash: 'e7ec4e35c89d7556b9e07d4331ac34052ac011bd'
// A Spider in the game. The most basic unit.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// <<-- Creer-Merge: usings -->> - Code you add between this comment and the end comment will be preserved between Creer re-runs.
// you can add addtional using(s) here
// <<-- /Creer-Merge: usings -->>

namespace Joueur.cs.Games.Spiders
{
    /// <summary>
    /// A Spider in the game. The most basic unit.
    /// </summary>
    class Spider : Spiders.GameObject
    {
        #region Properties
        /// <summary>
        /// If this Spider is dead and has been removed from the game.
        /// </summary>
        public bool IsDead { get; protected set; }

        /// <summary>
        /// The Nest that this Spider is currently on. Null when moving on a Web.
        /// </summary>
        public Spiders.Nest Nest { get; protected set; }

        /// <summary>
        /// The Player that owns this Spider, and can command it.
        /// </summary>
        public Spiders.Player Owner { get; protected set; }


        // <<-- Creer-Merge: properties -->> - Code you add between this comment and the end comment will be preserved between Creer re-runs.
        // you can add addtional properties(s) here. None of them will be tracked or updated by the server.
        // <<-- /Creer-Merge: properties -->>
        #endregion


        #region Methods
        /// <summary>
        /// Creates a new instance of Spider. Used during game initialization, do not call directly.
        /// </summary>
        protected Spider() : base()
        {
        }


        // <<-- Creer-Merge: methods -->> - Code you add between this comment and the end comment will be preserved between Creer re-runs.
        // you can add addtional method(s) here.
        // <<-- /Creer-Merge: methods -->>
        #endregion
    }
}
