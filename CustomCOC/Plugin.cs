using BepInEx;
using System;
using UnityEngine;
using UnityEngine.UI;
using Utilla;

namespace CustomCOC
{
    /// <summary>
    /// This is your mod's main class.
    /// </summary>

    /* This attribute tells Utilla to look for [ModdedGameJoin] and [ModdedGameLeave] */
    [ModdedGamemode]
    [BepInDependency("org.legoandmars.gorillatag.utilla", "1.5.0")]
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class Plugin : BaseUnityPlugin
    {
        public string logOutput = "";
        void Start()
        {
            /* A lot of Gorilla Tag systems will not be set up when start is called /*
			/* Put code in OnGameInitialized to avoid null references */

            Utilla.Events.GameInitialized += OnGameInitialized;
        }

        void OnGameInitialized(object sender, EventArgs e)
        {
            GameObject cocHeaderObject = GameObject.Find("/Level/lower level/UI/CodeOfConduct");
            Text cocHeaderText = cocHeaderObject.GetComponent<Text>();
            cocHeaderText.text = "Custom Header";

            GameObject cocObject = GameObject.Find("/Level/lower level/UI/Tree Room Texts/COC Text");
            Text cocText = cocObject.GetComponent<Text>();
            cocText.text = "Custom Body";
        }

        void Update()
        {

        }
    }
}
