using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Manages the screening rooms that are available at a venue, including the creation of new rooms, removal of old ones and the 
/// updating of the capacity of existing ones
/// </summary>
/// 
namespace ClassLibrary
{
    public class clsScreen
    {
        public int ScreenID { get; set; }
        public string ScreenName { get; set; }
        public int Capacity { get; set; }
        public bool ScreenBeingUsed { get; set; }
        public int AdsAfterMovie { get; set; }
    }
}