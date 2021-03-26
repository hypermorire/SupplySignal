using Rocket.API;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace SupplySignal
{
    public class Config : IRocketPluginConfiguration
    {
        public bool SupplyAnnounce;
        public string SupplyPermission, AnnouncMessage, AnnouncImgUrl;
        [XmlArrayItem("SignalIDs")]
        public List<ushort> SignalSmokes { get; set; } = new List<ushort>();
        public void LoadDefaults()
        {
            SupplyAnnounce = true;
            SupplyPermission = "hyper.supply";
            AnnouncMessage = "{color=yellow}%PLAYERNAME%{/color} {color=white}called air drop.{/color}";
            AnnouncImgUrl = "";
            SignalSmokes = new List<ushort>
            {
                261,
            };
        }
    }
}
