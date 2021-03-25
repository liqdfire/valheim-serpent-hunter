using BepInEx.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ValheimSherpentHunter
{
  internal class SerpentLogListner : ILogListener
  {
    public void Dispose()
    {
    }

    public void LogEvent(object sender, LogEventArgs eventArgs)
    {
      var message = eventArgs.ToString();
      if (message.Contains("Spawned Serpent"))
      {
        MessageHud.instance.ShowBiomeFoundMsg("Serpent Spawned", true);
      }
    }
  }
}
