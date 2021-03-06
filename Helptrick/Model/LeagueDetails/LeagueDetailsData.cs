﻿using System.Collections.Generic;

namespace Helptrick.Model.LeagueDetails
{
    /// <summary>
    ///     Information about a League Level Unit (series)
    /// </summary>
    internal class LeagueDetailsData : BaseHattrickData
    {
        /// <summary>
        ///     Id and League name.
        /// </summary>
        public League League { get; set; } = new League();

        /// <summary>
        ///     Indicates the division/level this LeaguelevelUnit is located on. 1
        ///     is the top division, the second best is 2 and so on.
        /// </summary>
        public int LeagueLevel { get; set; }

        /// <summary>
        ///     How many divisions/levels there are in this league.
        /// </summary>
        public int MaxLevel { get; set; }

        /// <summary>
        ///     Container for the LeagueLevelUnit ('series').
        /// </summary>
        public LeagueLevelUnit LeagueLevelUnit { get; set; } = new LeagueLevelUnit();

        /// <summary>
        ///     Current match round.
        /// </summary>
        public int CurrentMatchRound { get; set; }

        /// <summary>
        ///     Container for the data for a certain team.
        /// </summary>
        public List<LeagueTeam> LeagueTeams { get; set; } = new List<LeagueTeam>();
    }
}