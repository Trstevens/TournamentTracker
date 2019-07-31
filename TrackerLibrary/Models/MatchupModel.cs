using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represents one match in the tournament.
    /// </summary>
    public class MatchupModel
    {
        /// <summary>
        /// The set of teams that were involved in this match.
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// Represents the Winning Team of the model.
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// Represents the round in which the matchups are happening.
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
