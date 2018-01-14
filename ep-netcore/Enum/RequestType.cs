using System;

namespace epnetcore.Enum
{
    [Flags]
    public enum RequestType
    {
        None,
        PlayerSearch,
        PlayerStats,
        TeamSearch,
        LeagueSearch
    }
}
