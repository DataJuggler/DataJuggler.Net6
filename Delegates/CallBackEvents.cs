

#region using statements

using DataJuggler.Net6.Enumerations;
using System.Collections.Generic;

#endregion

namespace DataJuggler.Net6.Delegates
{

    #region ItemChangedCallback(object itemChanged, ChangeTypeEnum changeType);
    /// <summary>
    /// This delegate is used to recieve notification event if an item is added, removed or changed.
    /// </summary>
    /// <param name="itemChanged"></param>
    /// <param name="changeType"></param>
    public delegate void ItemChangedCallback(object itemChanged, ChangeTypeEnum changeType);
    #endregion

}
